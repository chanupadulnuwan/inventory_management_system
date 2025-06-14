using System;
using System.Windows.Forms;
using inventryUI.Controllers;
using Menu;

namespace inventryUI.Views
{
    public partial class ProductForm : Form
    {
        private ProductController _controller;

        public ProductForm()
        {
            InitializeComponent();
            _controller = new ProductController(this);

            // Event hooks
            this.Load += ProductForm_Load;
            this.Resize += ProductForm_Resize;
            dgvProducts.CellClick += dgvProducts_CellClick;
            btnBack.Click += btnBack_Click; // Event hook for Back button
        }

        // Center the title label when form loads
        private void ProductForm_Load(object sender, EventArgs e)
        {
            CenterTitleLabel();
        }

        // Re-center on resize
        private void ProductForm_Resize(object sender, EventArgs e)
        {
            CenterTitleLabel();
        }

        private void CenterTitleLabel()
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        }

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppMenuForm menuForm = new AppMenuForm();
            menuForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional — handle label clicks if needed
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Add edit functionality
        }
    }
}
