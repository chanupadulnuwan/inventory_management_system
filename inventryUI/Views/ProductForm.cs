using inventryUI.Models;
using inventryUI.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace inventryUI.Views
{
    public partial class ProductForm : Form, IProductView
    {
        public ProductForm()
        {
            InitializeComponent();

            // Hook button clicks to interface events
            btnAdd.Click += (s, e) => AddProduct?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (s, e) => EditProduct?.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (s, e) => DeleteProduct?.Invoke(this, EventArgs.Empty);
            btnSearch.Click += (s, e) => SearchProduct?.Invoke(this, EventArgs.Empty);
            this.Load += (s, e) => LoadView?.Invoke(this, EventArgs.Empty);

            // Handle DataGridView row selection
            dgvProducts.CellClick += dgvProducts_CellClick;
        }

        // IProductView: Property bindings
        public string ProductName => txtName.Text;
        public string SKU => txtSKU.Text;

        // Validates quantity input and returns -1 if invalid
        public int Quantity
        {
            get
            {
                if (!int.TryParse(txtQty.Text, out var q) || q <= 0)
                    return -1;
                return q;
            }
        }

        // Validates price input and returns -1 if invalid
        public decimal Price
        {
            get
            {
                if (!decimal.TryParse(txtPrice.Text, out var p) || p <= 0)
                    return -1;
                return p;
            }
        }

        public string SearchKeyword => txtSearch.Text;

        // Displays product list in grid
        public void SetProductList(List<Product> products)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }

        // Displays popup messages
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        // Clears all input fields
        public void ClearFields()
        {
            txtName.Clear();
            txtSKU.Clear();
            txtQty.Clear();
            txtPrice.Clear();
        }

        // Autofills input fields when selecting a row in the grid
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProducts.Rows[e.RowIndex].Cells["SKU"].Value != null)
            {
                txtName.Text = dgvProducts.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtSKU.Text = dgvProducts.Rows[e.RowIndex].Cells["SKU"].Value.ToString();
                txtQty.Text = dgvProducts.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                txtPrice.Text = dgvProducts.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
        }

        // Events from IProductView
        public event EventHandler AddProduct;
        public event EventHandler EditProduct;
        public event EventHandler DeleteProduct;
        public event EventHandler SearchProduct;
        public event EventHandler LoadView;
    }
}
