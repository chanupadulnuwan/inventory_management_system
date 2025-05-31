using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using inventryUI.Models;
using inventryUI.Views;

namespace inventryUI.Controllers
{
    public class ProductController
    {
        private readonly ProductForm _view;
        private readonly List<Product> _products = new();

        public ProductController(ProductForm view)
        {
            _view = view;

            // Wire up UI events
            _view.btnAdd.Click += OnAddProduct;
            _view.btnEdit.Click += OnEditProduct;
            _view.btnDelete.Click += OnDeleteProduct;
            _view.btnSearch.Click += OnSearchProduct;
            _view.Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            RefreshProductList(_products);
        }

        private void OnAddProduct(object sender, EventArgs e)
        {
            string name = _view.txtName.Text.Trim();
            string sku = _view.txtSKU.Text.Trim();
            bool isQtyValid = int.TryParse(_view.txtQty.Text, out int quantity);
            bool isPriceValid = decimal.TryParse(_view.txtPrice.Text, out decimal price);

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(sku))
            {
                MessageBox.Show("Product Name and SKU are required.");
                return;
            }

            if (_products.Any(p => p.SKU == sku))
            {
                MessageBox.Show("Product with this SKU already exists.");
                return;
            }

            if (!isQtyValid || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid whole number greater than 0.");
                return;
            }

            if (!isPriceValid || price <= 0)
            {
                MessageBox.Show("Price must be a valid positive number.");
                return;
            }

            _products.Add(new Product
            {
                Name = name,
                SKU = sku,
                Quantity = quantity,
                Price = price
            });

            RefreshProductList(_products);
            MessageBox.Show("Product added successfully!");
            ClearFields();
        }

        private void OnEditProduct(object sender, EventArgs e)
        {
            string sku = _view.txtSKU.Text.Trim();
            bool isQtyValid = int.TryParse(_view.txtQty.Text, out int quantity);
            bool isPriceValid = decimal.TryParse(_view.txtPrice.Text, out decimal price);

            var product = _products.FirstOrDefault(p => p.SKU == sku);
            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            if (!isQtyValid || quantity < 0)
            {
                MessageBox.Show("Quantity must be a valid whole number.");
                return;
            }

            if (!isPriceValid || price < 0)
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            product.Quantity = quantity;
            product.Price = price;

            RefreshProductList(_products);
            MessageBox.Show("Product updated successfully.");
        }

        private void OnDeleteProduct(object sender, EventArgs e)
        {
            string sku = _view.txtSKU.Text.Trim();
            var product = _products.FirstOrDefault(p => p.SKU == sku);

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            _products.Remove(product);
            RefreshProductList(_products);
            MessageBox.Show("Product deleted successfully.");
            ClearFields();
        }

        private void OnSearchProduct(object sender, EventArgs e)
        {
            string keyword = _view.txtSearch.Text.Trim();

            var result = _products.Where(p =>
                p.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                p.SKU.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

            RefreshProductList(result);
        }

        private void RefreshProductList(List<Product> list)
        {
            _view.dgvProducts.DataSource = null;
            _view.dgvProducts.DataSource = list;
        }

        private void ClearFields()
        {
            _view.txtName.Clear();
            _view.txtSKU.Clear();
            _view.txtQty.Clear();
            _view.txtPrice.Clear();
        }
    }
}
