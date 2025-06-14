using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions; // For validation
using inventryUI.Models;
using inventryUI.Controllers;
using inventryUI.Views;
using Menu;
using System.Xml.Linq;

namespace inventryUI.Views
{
    public partial class SupplierForm
    {
        private SupplierController presenter;

        public SupplierForm()
        {
            InitializeComponent();

            // Hook up buttons
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSearch.Click += btnSearch_Click;


            // Set up DataGridView behavior
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Create controller
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


            if (!IsValidInput(name, contact, product))
            {
                MessageBox.Show("Input contains invalid characters or is too long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = presenter.AddSupplier(name, contact, product);


            if (success)
            {
                MessageBox.Show("Supplier added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            // ? Duplicate messages are shown by presenter via view.ShowMessage(...)
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
                supplier.Product = product;



                if (!IsValidInput(name, contact, product))

                    return;

                supplier.Name = name;
                supplier.ContactInfo = contact;
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
            txtName.Text = "";
            txtContact.Text = "";
            textProduct.Text = "";

        }

        public void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }




        private bool IsValidInput(string name, string contact, string product)

        {
            // Name must contain only letters and spaces
            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Name must contain only letters.");
                return false;
            }

            // Contact must contain at least one number (e.g., phone or email with number)
            if (!Regex.IsMatch(contact, @"\d"))
            {
                MessageBox.Show("Contact info must include at least one number (e.g., phone or email).");
                return false;
            }
            // Product must contain only letters and spaces
            if (!Regex.IsMatch(product, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Product must contain only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {

        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textProduct_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
