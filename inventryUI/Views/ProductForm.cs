using System;
using System.Windows.Forms;
using inventryUI.Controllers;

namespace inventryUI.Views
{
    public partial class ProductForm : Form
    {
        private ProductController _controller;

        public ProductForm()
        {
            InitializeComponent();
            _controller = new ProductController(this);

            // Handle DataGridView row selection
            dgvProducts.CellClick += dgvProducts_CellClick;
        }

        // Auto-fill fields when selecting a row
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

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }


    }
}
