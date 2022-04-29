using Airport_v2.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_v2
{
    public partial class PlaneForm : MaterialForm
    {
        IPlaneService _planeService = new PlaneService();
        public PlaneForm()
        {
            InitializeComponent();
            if (!Status.Value) { addButton.Enabled = false; editButton.Enabled = false; deleteButton.Enabled = false; }
            FillPlaneList();
        }

        private void FillPlaneList()
        {
              planeListView.Items.Clear();
              planeListView.GridLines = true;

            var planes = _planeService.GetPlane();

            foreach (var plane in planes)
            {
                var lvi = new ListViewItem(new[]
                {
                    //pilot.Id.ToString(),
                    //pilot.Firstname,
                    //pilot.Lastname,
                    //pilot.Age.ToString(),
                    //pilot.Experience.ToString(),
                    //pilot.Position,

                    plane.Id.ToString(),
                    plane.PlaneType,
                    plane.Model,
                    plane.Capacity,
                    plane.Status,
                    plane.Pilot,
                   // $"{plane.pilot.Firstname} {plane.pilot.Lastname}",

                });
                planeListView.Items.Add(lvi);
            }
        }

        private void closeButton_Click(object sender, EventArgs e) //EDIT
        {
            if (planeListView.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(planeListView.SelectedItems[0].SubItems[0].Text);
                var fullName = planeListView.SelectedItems[0].SubItems[0].Text + " - " + planeListView.SelectedItems[0].SubItems[1].Text;
                if (MessageBox.Show($"Are you sure you want to edit this post: {idx}.{fullName}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Status.Update = true;
                    Status.Id = idx;
                    AddPlaneForm update = new AddPlaneForm
                    {
                        Text = "Update Plane"
                    };
                    if (update.ShowDialog() != DialogResult.OK)
                    {
                        Status.Update = false;
                        return;
                    }
                    var newPlane = update.Plane;
                    newPlane.Id = idx;
                    _planeService.UpdatePlane(newPlane, idx);
                    FillPlaneList();
                    string info = null;
                    if (newPlane.Id + " - " + newPlane.Model != fullName) { info = "on " + idx + "." + newPlane.Id + " - " + newPlane.Model; }
                    Status.Update = false;
                    Log.Information($"User {Status.User} edit this post {idx}.{fullName} {info}.");
                }
            }
            else
            {
                MessageBox.Show("Select one post you want to edit.",
                 "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addPlaneButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= planeListView.Items.Count; i++)
            {
                if (columnHeader3.Text == "")
                {
                    planeListView.SelectedItems[i].Remove();
                    // lvi.Remove();
                }
            }


            AddPlaneForm addplane = new AddPlaneForm();

            if (addplane.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var newPlane = addplane.Plane;
            _planeService.AddPlane(newPlane);
            FillPlaneList();

        }

        private void planeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void planeDelButton_Click(object sender, EventArgs e)
        {
            //if(planeListView.Items.Count > 0)
            //{
            //    planeListView.Items.Remove(planeListView.SelectedItems[0]);

            //}


            if (planeListView.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(planeListView.SelectedItems[0].SubItems[0].Text);
                var fullName = planeListView.SelectedItems[0].SubItems[1].Text + " " + planeListView.SelectedItems[0].SubItems[2].Text;
                if (MessageBox.Show($"Do you really want to delete this entry: {idx} - {fullName}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _planeService.RemovePlane(idx);
                    FillPlaneList();
                }
            }
            else
            {
                MessageBox.Show("Select one entry you want to delete.",
                 "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void сохранитьToolStripButton_Click(object sender, EventArgs e) //save
        //{

        //}

        //private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        //{
        //    if (planeListView.Items.Count > 0)
        //    {
        //        planeListView.Items.Remove(planeListView.SelectedItems[0]);
        //    }
        //}

        //private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        //{
        //    //AddForm formadd = new AddForm();

        //    //if (formadd.ShowDialog() != DialogResult.OK)
        //    //{
        //    //    return;
        //    //}
        //    //var newPilot = formadd.Pilot;
        //    //_pilotService.AddPilot(newPilot);
        //    //FillPilotList();
        //}
    }
}
