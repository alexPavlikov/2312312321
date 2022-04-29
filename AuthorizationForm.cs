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
    public partial class AuthorizationForm : MaterialForm
    {
        private IAuthService _authService = new AuthService();

        public AuthorizationForm()
        {
            InitializeComponent();
            Status.Enter = false;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_authService.Authorize(loginTextBox.Text.ToString(), passwordTextBox.Text.ToString()) == true)
            {
                if (Status.Value)
                {
                    MessageBox.Show("You are logged in as administrator", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You logged in on behalf of an employee", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Status.Enter = true;
                Status.User = loginTextBox.Text.ToString();
                Log.Information($"User {Status.User} entered the network.");
                DialogResult = DialogResult.OK;
                MainCrewForm crewForm = new MainCrewForm();
                crewForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong login or password!");
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
           RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
            loginTextBox.Text = regForm.loginTextBox.Text;
            passwordTextBox.Text = regForm.passwordTextBox.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) passwordTextBox.PasswordChar = (char)0;
            else  passwordTextBox.PasswordChar = '*';
        }
    }
}
