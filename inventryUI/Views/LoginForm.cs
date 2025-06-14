using inventryUI.Controllers;
using Menu;
using System;
using System.Windows.Forms;

namespace inventryUI.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a temporary controller (no form needed)
            var controller = new UserController(viewSign: null); // Login only needs one side

            bool loginSuccess = controller.LoginValid(username, password);

            if (loginSuccess)
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Show App Menu after successful login
                var appMenu = new AppMenuForm();
                appMenu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }
    }
}
