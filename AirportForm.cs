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
    public partial class AirportForm : MaterialForm
    {
        public AirportForm()
        {
            InitializeComponent();
        }

        private void materialButton3_Click(object sender, EventArgs e) // close
        {
            // Application.Exit();
            MainCrewForm nwfrm = new MainCrewForm();
            nwfrm.Show();
            this.Hide();
        }
    }
}
