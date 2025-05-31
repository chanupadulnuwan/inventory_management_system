using inventryUI;
using inventryUI.Controllers; 
using inventryUI.Views;
using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class AppMenuForm : Form
    {
        private AppMenuController _controller;

        public AppMenuForm()
        {
            InitializeComponent();
            _controller = new AppMenuController(this);

            this.Load += AppMenuForm_Load;
            btnLogout.Click += BtnLogout_Click;
        }

        private void AppMenuForm_Load(object sender, EventArgs e)
        {
            lblUserRole.Text = $"Logged in as: {Session.CurrentUserRole}";

            if (Session.CurrentUserRole == "User")
            {
                btnPurchases.Enabled = false;
                btnSuppliers.Enabled = false;
                btnBackup.Enabled = false;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
