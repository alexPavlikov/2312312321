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
    public partial class FlightForm : MaterialForm
    {
        IFlightsService _flightService = new FlightsService();

        public FlightForm()
        {
            InitializeComponent();
            if (!Status.Value) { addButton.Enabled = false; editButton.Enabled = false; deleteButton.Enabled = false; }
            FillFlightList();
        }

        private void FillFlightList()
        {
            flightListView.Items.Clear();
            flightListView.GridLines = true;

            var flights = _flightService.GetFlight();

            foreach (var flight in flights)
            {
                var lvi = new ListViewItem(new[]
                {
                    //pilot.Id.ToString(),
                    //pilot.Firstname,
                    //pilot.Lastname,
                    //pilot.Age.ToString(),
                    //pilot.Experience.ToString(),
                    //pilot.Position,
                    flight.Id.ToString(),
                    $"{flight.StartingTown + ", "} {flight.CountryS}",
                    $"{flight.EndingTown + ", "} {flight.CountryE}",
                    flight.DispatchTime.ToString("dd.MM.yyyy HH:mm"), //
                    flight.Distance,
                    flight.Playground,                     
                    flight.Status,

                });
                flightListView.Items.Add(lvi);
            }
        }

        private void FlightForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddFlightForm formadd = new AddFlightForm();

            if (formadd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var newFlight = formadd.Flight;

            _flightService.AddFlight(newFlight);

            FillFlightList();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (flightListView.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(flightListView.SelectedItems[0].SubItems[0].Text);
                var fullName = flightListView.SelectedItems[0].SubItems[1].Text + " " + flightListView.SelectedItems[0].SubItems[2].Text;
                if (MessageBox.Show($"Do you really want to delete this entry: {idx} - {fullName}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _flightService.RemoveFlight(idx);
                    FillFlightList();
                }
            }
            else
            {
                MessageBox.Show("Select one entry you want to delete.",
                 "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (flightListView.SelectedIndices.Count == 1)
            {
                var idx = int.Parse(flightListView.SelectedItems[0].SubItems[0].Text);
                var fullName = flightListView.SelectedItems[0].SubItems[1].Text + " - " + flightListView.SelectedItems[0].SubItems[2].Text;
                if (MessageBox.Show($"Are you sure you want to edit this post: {idx}.{fullName}",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Status.Update = true;
                    Status.Id = idx;
                    AddFlightForm update = new AddFlightForm
                    {
                        Text = "Update Flight"
                    };
                    if (update.ShowDialog() != DialogResult.OK)
                    {
                        Status.Update = false;
                        return;
                    }
                    var newFlight = update.Flight;
                    newFlight.Id = idx;
                    _flightService.UpdateFlight(newFlight, idx);
                    FillFlightList();
                    string info = null;
                    if (newFlight.CountryS + " - " + newFlight.CountryE != fullName) { info = "on " + idx + "." + newFlight.CountryS + " - " + newFlight.CountryE; }
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
