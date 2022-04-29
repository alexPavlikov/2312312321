using MaterialSkin;
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
    public partial class MainCrewForm : MaterialForm
    {
        public MainCrewForm()
        {
            InitializeComponent();

            if (Status.User == "1")
            {
                userName.Text = "Admin";
            }
            else userName.Text = Status.User;

            //if (!Status.Value)
            //{
            //    RegistrationForm reg = new RegistrationForm();
            //    string a = reg.fNametextBox.Text.ToString();   // dont worked
            //    string b = reg.lNametextBox.Text.ToString();
            //    string c = a + b;
            //    userName.Text = Convert.ToString(c);
            //}
            //else
            //{
            //    userName.Text = "Admin";
            //}
        }

        private void materialButton4_Click(object sender, EventArgs e) //close
        {
            if (materialButton4.Enabled == true)
            {
               // MessageBox.Show("Select one entry you want to delete.", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (MessageBox.Show("Do you really need an exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Hide();
                }
                
            }
        }

        private void AirInfButton_Click(object sender, EventArgs e)
        {
            FlightForm flyform = new FlightForm();
            flyform.Show();
           // this.Hide();
        }

        private void planeInfButton_Click(object sender, EventArgs e)
        {
            PlaneForm planefrm = new PlaneForm();
            planefrm.Show();
          //  this.Hide();
        }

        private void materialButton3_Click(object sender, EventArgs e) //pilot
        {
            PilotForm pilotfrm = new PilotForm();
            pilotfrm.Show();
           // this.Hide();
        }

        private void workerButton_Click(object sender, EventArgs e)
        {
            WorkerForm wform = new WorkerForm();
            wform.Show();
          //  this.Hide();
        }

        private void userName_Click(object sender, EventArgs e)
        {
            
        }
    }
}
