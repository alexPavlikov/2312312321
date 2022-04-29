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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange400, Primary.Orange800, Primary.DeepOrange500, Accent.Orange200, TextShade.WHITE);
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void crewButton_Click(object sender, EventArgs e)
        {
            //AirportForm newForm = new AirportForm();
            //newForm.Show();
            //this.Hide();
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.Show();
            this.Hide();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            MainCrewForm form = new MainCrewForm();
            form.Show();
            this.Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            PassengerForm pasForm = new PassengerForm();
            pasForm.Show();
            //this.Hide();
            //Close();
        }
    }
}
