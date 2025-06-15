using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using inventryUI.Models;
using inventryUI.Controllers;
using Menu;

namespace inventryUI.Views
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierController presenter;
        private readonly AppMenuForm _mainMenu;

        public SupplierForm(AppMenuForm mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            // Event bindings
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSearch.Click += btnSearch_Click;
            backbtn.Click += backbtn_Click;

            // Form layout
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 600);
            this.FormClosed += SupplierForm_FormClosed;

            // Label styling
            label1.Dock = DockStyle.Top;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new Font("Arial", 18, FontStyle.Bold);

            // DataGridView setup
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Controller
            presenter = new SupplierController(this);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string contact = txtContact.Text.Trim();
            string product = textProduct.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(product))
            {
                MessageBox.Show("Please enter Name, Contact Info, and Product.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidInput(name, contact, product)) return;

            bool success = presenter.AddSupplier(name, contact, product);
            if (success)
            {
                MessageBox.Show("Supplier added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to update.");
                return;
            }

            var supplier = GetSelectedSupplier();
            if (supplier != null)
            {
                string name = txtName.Text.Trim();
                string contact = txtContact.Text.Trim();
                string product = textProduct.Text.Trim();

                if (!IsValidInput(name, contact, product)) return;

                supplier.Name = name;
                supplier.ContactInfo = contact;
                supplier.Product = product;
                presenter.UpdateSupplier(supplier);
                ClearFields();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            var supplier = GetSelectedSupplier();
            if (supplier != null)
            {
                presenter.DeleteSupplier(supplier.SupplierID);
                ClearFields();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();
            var filteredSuppliers = presenter.SearchSuppliers(query);

            if (filteredSuppliers.Count == 0)
            {
                MessageBox.Show("No supplier found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DisplaySuppliers(filteredSuppliers);
        }

        public void DisplaySuppliers(List<Supplier> suppliers)
        {
            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = suppliers;
        }

        public Supplier GetSelectedSupplier()
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
                return null;

            return dgvSuppliers.SelectedRows[0].DataBoundItem as Supplier;
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtContact.Clear();
            textProduct.Clear();
        }

        public void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        private bool IsValidInput(string name, string contact, string product)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Name must contain only letters.");
                return false;
            }

            if (!Regex.IsMatch(contact, @"\d"))
            {
                MessageBox.Show("Contact info must include at least one number.");
                return false;
            }

            if (!Regex.IsMatch(product, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Product must contain only letters.");
                return false;
            }

            return true;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Will trigger FormClosed
        }

        private void SupplierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu?.Show();
        }
    }
}
