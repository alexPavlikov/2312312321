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
    public partial class PilotForm : MaterialForm
    {
        IPilotService _pilotService = new PilotService();
        public PilotForm()
        {
            InitializeComponent();
            // pilotListView.Items = _pilotService.GetPilot();
            if (!Status.Value) { addButton.Enabled = false; editButton.Enabled = false; deleteButton.Enabled = false; }
            FillPilotList();


        }

        private void FillPilotList()
        {
            pilotListView.Items.Clear();
            pilotListView.GridLines = true;

            var pilots = _pilotService.GetPilot();

            foreach (var pilot in pilots)
            {
                var lvi = new ListViewItem(new[]
                {
                    pilot.Id.ToString(), 
                    pilot.Firstname,
                    pilot.Lastname,
                    pilot.Age, 
                    pilot.Experience, 
                    pilot.Position,
                    pilot.Plane.Model,
                    pilot.Plane.PlaneType
                });
                pilotListView.Items.Add(lvi);
            }
        }


        private void PilotForm_Load(object sender, EventArgs e)
        {
           // FillPilotList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm formadd = new AddForm();

            if (formadd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var newPilot = formadd.Pilot;

            _pilotService.AddPilot(newPilot);

            FillPilotList();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (pilotListView.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(pilotListView.SelectedItems[0].SubItems[0].Text);
                var fullName = pilotListView.SelectedItems[0].SubItems[1].Text + " " + pilotListView.SelectedItems[0].SubItems[2].Text;
                if (MessageBox.Show($"Do you really want to delete this entry: {idx} - {fullName}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _pilotService.RemovePilot(idx);
                    FillPilotList();
                }
            }
            else
            {
                MessageBox.Show("Select one entry you want to delete.",
                 "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void pilotListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i <= pilotListView.Items.Count; i++)
            //{
            //    if (pilotListView.SelectedItems[i].Text == "Not have")
            //    {
            //        pilotListView.SelectedItems[i].BackColor = Color.Red;
            //          //  SubItems[2].BackColor = Color;
            //    }       
            //}
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (pilotListView.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(pilotListView.SelectedItems[0].SubItems[0].Text);
                var fullName = pilotListView.SelectedItems[0].SubItems[1].Text;
                if (MessageBox.Show($"Are you sure you want to edit this post: {idx}.{fullName}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Status.Update = true;
                    Status.Id = idx;
                    AddForm update = new AddForm
                    {
                        Text = "Update Pilot"
                    };
                    if (update.ShowDialog() != DialogResult.OK)
                    {
                        Status.Update = false;
                        return;
                    }
                    var newPilot = update.Pilot;
                    newPilot.Id = idx;
                    _pilotService.UpdatePilot(newPilot, idx);
                    FillPilotList();
                    string info = null;
                    if (newPilot.Lastname != fullName) { info = "on " + idx + "." + newPilot.Lastname; }
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
    }
}
