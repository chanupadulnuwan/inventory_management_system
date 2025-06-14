﻿using System;
using System.Windows.Forms;
using inventryUI.Controllers;
using Menu;

namespace inventryUI.Views
{
    public partial class ProductForm : Form
    {
        private ProductController _controller;
        private Form _previousForm;

        public ProductForm(Form previousForm)
        {
            InitializeComponent();
            _controller = new ProductController(this);
            _previousForm = previousForm;

            this.Load += ProductForm_Load;
            this.Resize += ProductForm_Resize;
            dgvProducts.CellClick += dgvProducts_CellClick;
            btnBack.Click += btnBack_Click;

            // Uniform window size
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 600);
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            CenterTitleLabel();
        }

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
            this.Close(); // Close ProductForm
            _previousForm.Show(); // Show the previous form again
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Add edit functionality
        }
    }
}
