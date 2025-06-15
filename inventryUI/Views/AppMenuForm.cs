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
            btnSuppliers.Click += BtnSuppliers_Click;
            btnPurchases.Click += BtnPurchases_Click;
            btnUser.Click += BtnUser_Click;
            btnReports.Click += BtnReports_Click;
            btnStockTracking.Click += BtnStockTracking_Click;
            btnManageProducts.Click += BtnManageProducts_Click;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(900, 600);
        }

        private void AppMenuForm_Load(object sender, EventArgs e)
        {
            lblUserRole.Text = $"Logged in as: {Session.CurrentUserRole}";
            ApplyPermissions(Session.CurrentUserRole);
        }

        private void ApplyPermissions(string role)
        {
            if (role == "Admin")
            {
                // No restrictions
                EnableAllButtons();
            }
            else if (role == "User")
            {
                EnableAllButtons();
                btnSuppliers.Enabled = false;
                btnPurchases.Enabled = false;
            }
            else if (role == "Supplier")
            {
                DisableAllButtons();
                btnSuppliers.Enabled = true;
                btnReports.Enabled = true;
                btnUser.Enabled = true;
                btnLogout.Enabled = true;
            }
        }

        private void EnableAllButtons()
        {
            btnManageProducts.Enabled = true;
            btnSuppliers.Enabled = true;
            btnPurchases.Enabled = true;
            btnStockTracking.Enabled = true;
            btnReports.Enabled = true;
            btnUser.Enabled = true;
            btnLogout.Enabled = true;
        }

        private void DisableAllButtons()
        {
            btnManageProducts.Enabled = false;
            btnSuppliers.Enabled = false;
            btnPurchases.Enabled = false;
            btnStockTracking.Enabled = false;
            btnReports.Enabled = false;
            btnUser.Enabled = false;
            btnLogout.Enabled = false;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Close();
        }

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            var form = new SupplierForm(this);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {
            var form = new PurchaseOrderForm();
            form.ShowDialog();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            var form = new UserForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            var form = new ReportForm(this);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void BtnStockTracking_Click(object sender, EventArgs e)
        {
            var form = new StockForm(this);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void BtnManageProducts_Click(object sender, EventArgs e)
        {
            var form = new ProductForm(this);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
