using Airport_v2.Services;
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
    public partial class WorkerForm : MaterialForm
    {
        IOtherWorkerService _workerService = new OtherWorkerService();
        public WorkerForm()
        {
            InitializeComponent();
            if (!Status.Value) { addButton.Enabled = false; editButton.Enabled = false; deleteButton.Enabled = false; }
            FillWorkerList();
        }

        private void FillWorkerList()
        {
            workerListView.Items.Clear();
            workerListView.GridLines = true;

            var workers = _workerService.GetWorker();

            foreach (var worker in workers)
            {
                var lvi = new ListViewItem(new[]
                {
                    worker.Id.ToString(),
                    worker.Firstname,
                    worker.Lastname,
                    worker.Age,
                    worker.Experience,
                    worker.Position,
                 //   pilot.Plane.Model,
                   // pilot.Plane.PlaneType
                });
                workerListView.Items.Add(lvi);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (workerListView.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(workerListView.SelectedItems[0].SubItems[0].Text);
                var fullName = workerListView.SelectedItems[0].SubItems[1].Text + " " + workerListView.SelectedItems[0].SubItems[2].Text;
                if (MessageBox.Show($"Do you really want to delete this entry: {idx} - {fullName}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _workerService.RemoveWorker(idx);
                    FillWorkerList();
                }
            }
            else
            {
                MessageBox.Show("Select one entry you want to delete.",
                 "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //WorkerAddForm wAddform = new WorkerAddForm();
            //wAddform.Show();
            //this.Hide();


            WorkerAddForm wAddform = new WorkerAddForm();

            if (wAddform.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var newWorker = wAddform.OtherWorker;

            _workerService.AddWorker(newWorker);

            FillWorkerList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (workerListView.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(workerListView.SelectedItems[0].SubItems[0].Text);
                var fullName = workerListView.SelectedItems[0].SubItems[1].Text + " - " + workerListView.SelectedItems[0].SubItems[2].Text;
                if (MessageBox.Show($"Are you sure you want to edit this post: {idx}.{fullName}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Status.Update = true;
                    Status.Id = idx;
                    WorkerAddForm update = new WorkerAddForm
                    {
                        Text = "Update Worker"
                    };
                    if (update.ShowDialog() != DialogResult.OK)
                    {
                        Status.Update = false;
                        return;
                    }
                    var newWorker = update.OtherWorker;
                    newWorker.Id = idx;
                    _workerService.UpdateWorker(newWorker, idx);
                    FillWorkerList();
                    string info = null;
                    if (newWorker.Firstname + " - " + newWorker.Lastname != fullName) { info = "on " + idx + "." + newWorker.Firstname + " - " + newWorker.Lastname; }
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
