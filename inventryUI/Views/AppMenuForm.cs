using inventryUI;
using inventryUI.Controllers;
using inventryUI.Views;
using System;
using System.Windows.Forms;
using WinFormsApp1;

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
            btnSuppliers.Click += btnSuppliers_Click;
            btnPurchases.Click += btnPurchases_Click;
            btnUser.Click += btnUser_Click;
            btnNotification.Click += btnNotification_Click; // Added friend's feature
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

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            PurchaseOrderForm purchaseForm = new PurchaseOrderForm();
            purchaseForm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            // Friend's feature logic here — update with actual functionality if needed
            MessageBox.Show("Notifications clicked.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional - No logic needed
        }

        private void AppMenuForm_Load_1(object sender, EventArgs e)
        {
            // Optional - safe to keep or remove
        }
    }
}
