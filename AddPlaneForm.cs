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
    partial class AddPlaneForm : MaterialForm
    {
        public Plane Plane { get; set; }

        IPlaneService _planeService = new PlaneService();
        IPilotService _pilotService = new PilotService();

        public AddPlaneForm()
        {
            InitializeComponent();
            LoadComboBoxItems();
        }

        string a;

        private void LoadComboBoxItems()
        {
            var books = _pilotService.GetPilot();
            foreach (var item in books)
            {
                nameComboBox.Items.Add(item.Firstname + " " + item.Lastname);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var id = _planeService.GetMaxId();

            if (passengerRadioButton.Checked == true)
            {
                string p = "Passenger plane";
                a = p;
            }
            else //cargoRadioButton.Checked == true
            {
                string c = "Cargo plane";
                a = c;
            }

            Plane = new Plane
            {

                Id = id + 1,
                PlaneType = a,
                Model = modelBox.Text,
                Capacity = capacityBox.Text,
                Status = statusComboBox.Text,
                Pilot = nameComboBox.Text
                //pilot = new Pilot
                //{
                //    Firstname = firstNameBox.Text,
                //    Lastname = lastNameBox.Text,
                //}
            };
            DialogResult = DialogResult.OK;
        }
       
    }
}
     

