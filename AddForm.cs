using Airport_v2.Data;
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
    partial class AddForm : MaterialForm
    {
        IPilotService _pilotService = new PilotService();
        public Pilot Pilot { get; set; }
        public AddForm()
        {
            InitializeComponent();
            
        }
        string a;
     //   string m;
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainCrewForm comback = new MainCrewForm();
            comback.Show();
            this.Hide();
        }
        private void ageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var id = _pilotService.GetMaxId();

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
            //else
            //{
            //    string m = "Not have";
            //    a = m;
            //    modelBox.Text = m;
            //}


            Pilot = new Pilot
            {
                Id = id + 1,
                Firstname = firstNameBox.Text,
                Lastname = lastNameBox.Text,
                Age = ageBox.Text,
                Experience = expBox.Text,
                Position = positionComboBox.Text,
                Plane = new Plane
                {

                    Id = 1003,
                    PlaneType = a,
                    Model = modelBox.Text,
                    Capacity = capacityBox.Text,
                    Status = statusComboBox.Text

                }

                //_PilotService
            };
            DialogResult = DialogResult.OK;
            //_pilotService.Add
            //  _pilotService.AddPilot(newPilot);

            //SaveChanges()
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();// создаем диалоговое окно
            openFile.ShowDialog();// открываем окно
            string FileName = openFile.FileName;// берем полный адрес картинки            
            pictureBox1.ImageLocation = FileName;// грузим картинку в pictureBox

        }
    }
}
