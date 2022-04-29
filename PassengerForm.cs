using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_v2
{
    public partial class PassengerForm : MaterialForm
    {
        public PassengerForm()
        {
            InitializeComponent();
        }

        private void flightButton_Click(object sender, EventArgs e)
        {
            FlightForm flyForm = new FlightForm();
            flyForm.Show();
        }

        private void ticketButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you have lost your ticket, contact the check-in point and present your passport and explain the situation to the employee.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lostButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\admin\Desktop\2 Semestr alex.sueta\курсач\Airport_v2\Resources\planAir.gif");
        }

        private void lostButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\admin\Desktop\2 Semestr alex.sueta\курсач\Airport_v2\Resources\fon2.jpg");
            }
        }
    }
}
