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
    public partial class RegistrationForm : MaterialForm
    {
        private IRegService _regService = new RegService();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length > 0)
            {
                if (passwordTextBox.Text.Length > 0 || repPasTextBox.Text.Length > 0)
                {
                    string output = _regService.Check(loginTextBox.Text, passwordTextBox.Text, repPasTextBox.Text, fNametextBox.Text, lNametextBox.Text);
                    MessageBox.Show(output, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (output == "User successfully registered")
                    {
                        //MainCrewForm mainForm = new MainCrewForm();
                        //mainForm.Show();
                        this.Close();
                    }
                }
                else MessageBox.Show("Enter a password in the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Enter a login in the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTextBox.PasswordChar = (char)0;
                repPasTextBox.PasswordChar = (char)0;
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
                repPasTextBox.PasswordChar = '*';
            }
        }
    }
}
