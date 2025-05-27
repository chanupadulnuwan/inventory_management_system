using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using inventryUI.Models;
using inventryUI.Views;

namespace inventryUI.Presenters
{
    public class ProductPresenter
    {
        private readonly IProductView _view;
        private readonly List<Product> _products = new();

        public ProductPresenter(IProductView view)
        {
            _view = view;

            _view.AddProduct += OnAddProduct;
            _view.EditProduct += OnEditProduct;
            _view.DeleteProduct += OnDeleteProduct;
            _view.SearchProduct += OnSearchProduct;
            _view.LoadView += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _view.SetProductList(_products);
        }

        private void OnAddProduct(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(_view.ProductName) || string.IsNullOrWhiteSpace(_view.SKU))
            {
                _view.ShowMessage("Product Name and SKU are required.");
                return;
            }

            // Ensure SKU is unique
            if (_products.Any(p => p.SKU == _view.SKU))
            {
                _view.ShowMessage("Product with this SKU already exists.");
                return;
            }

            // Validate Quantity
            if (_view.Quantity == -1)
            {
                _view.ShowMessage("Quantity must be a valid whole number greater than 0.");
                return;
            }

            // Validate Price
            if (_view.Price == -1)
            {
                _view.ShowMessage("Price must be a valid positive number.");
                return;
            }

            // Add product to list
            _products.Add(new Product
            {
                Name = _view.ProductName,
                SKU = _view.SKU,
                Quantity = _view.Quantity,
                Price = _view.Price
            });

            _view.SetProductList(_products);
            _view.ShowMessage("Product added successfully!");
            _view.ClearFields();
        }

        private void OnEditProduct(object sender, EventArgs e)
        {
            // Find product by SKU
            var product = _products.FirstOrDefault(p => p.SKU == _view.SKU);
            if (product == null)
            {
                _view.ShowMessage("Product not found.");
                return;
            }

            // Validate Quantity
            if (_view.Quantity == -1)
            {
                _view.ShowMessage("Quantity must be a valid whole number.");
                return;
            }

            // Validate Price
            if (_view.Price == -1)
            {
                _view.ShowMessage("Price must be a valid number.");
                return;
            }

            // Update product details
            product.Quantity = _view.Quantity;
            product.Price = _view.Price;

            _view.SetProductList(_products);
            _view.ShowMessage("Product updated successfully.");
        }

        private void OnDeleteProduct(object sender, EventArgs e)
        {
            // Find product by SKU
            var product = _products.FirstOrDefault(p => p.SKU == _view.SKU);
            if (product == null)
            {
                _view.ShowMessage("Product not found.");
                return;
            }

            // Ask for confirmation before deleting
            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            // Remove product
            _products.Remove(product);
            _view.SetProductList(_products);
            _view.ShowMessage("Product deleted successfully.");
            _view.ClearFields();
        }

        private void OnSearchProduct(object sender, EventArgs e)
        {
            // Search by name or SKU
            var result = _products.Where(p =>
                p.Name.Contains(_view.SearchKeyword, StringComparison.OrdinalIgnoreCase) ||
                p.SKU.Contains(_view.SearchKeyword, StringComparison.OrdinalIgnoreCase)).ToList();

            _view.SetProductList(result);
        }
    }
}
