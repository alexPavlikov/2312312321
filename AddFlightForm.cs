using Airport_v2.Entities;
using Airport_v2.Services;
using MaterialSkin.Controls;
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
    partial class AddFlightForm : MaterialForm
    {
        IFlightsService _flightService = new FlightsService();
        public Flights Flight { get; set; }
        public AddFlightForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var id = _flightService.GetMaxId();
            Flight = new Flights
            {

                Id = id + 1,
                CountryS = depCountrytextBox.Text,
                StartingTown = depTowntextBox.Text,
                CountryE = arrCountrytextBox.Text,
                EndingTown = arrTowntextBox.Text,
                DispatchTime = dateTimePicker.Value,
                Distance = DistancetextBox.Text,               
                Playground = PlaygroundBox.Text,
                Status = StatuscomboBox.Text,

            };
            DialogResult = DialogResult.OK;
        }
    }
}
