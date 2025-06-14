using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using inventryUI.Models;
using inventryUI.Views;
using inventryUI; // Now matches the correct namespace

namespace inventryUI.Controllers
{
    public class ProductController
    {
        private readonly ProductForm _view;

        public ProductController(ProductForm view)
        {
            _view = view;

            _view.btnAdd.Click += OnAddProduct;
            _view.btnEdit.Click += OnEditProduct;
            _view.btnDelete.Click += OnDeleteProduct;
            _view.btnSearch.Click += OnSearchProduct;
            _view.Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            RefreshProductList(GetAllProductsFromDB());
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

            if (IsProductExists(sku))
            {
                MessageBox.Show("Product with this SKU already exists.");
                return;
            }

            if (!isQtyValid || quantity <= 0 || !isPriceValid || price <= 0)
            {
                MessageBox.Show("Enter valid quantity and price.");
                return;
            }

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO products (ProductName, SKU, Quantity, Price) VALUES (@name, @sku, @qty, @price)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@sku", sku);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
            }

            RefreshProductList(GetAllProductsFromDB());
            ClearFields();
            MessageBox.Show("Product added successfully!");
        }

        private void OnEditProduct(object sender, EventArgs e)
        {
            string sku = _view.txtSKU.Text.Trim();
            bool isQtyValid = int.TryParse(_view.txtQty.Text, out int quantity);
            bool isPriceValid = decimal.TryParse(_view.txtPrice.Text, out decimal price);

            if (!IsProductExists(sku))
            {
                MessageBox.Show("Product not found.");
                return;
            }

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE products SET Quantity=@qty, Price=@price WHERE SKU=@sku", conn);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@sku", sku);
                cmd.ExecuteNonQuery();
            }

            RefreshProductList(GetAllProductsFromDB());
            MessageBox.Show("Product updated successfully.");
        }

        private void OnDeleteProduct(object sender, EventArgs e)
        {
            string sku = _view.txtSKU.Text.Trim();

            if (!IsProductExists(sku))
            {
                MessageBox.Show("Product not found.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM products WHERE SKU=@sku", conn);
                cmd.Parameters.AddWithValue("@sku", sku);
                cmd.ExecuteNonQuery();
            }

            RefreshProductList(GetAllProductsFromDB());
            ClearFields();
            MessageBox.Show("Product deleted successfully.");
        }

        private void OnSearchProduct(object sender, EventArgs e)
        {
            string keyword = _view.txtSearch.Text.Trim();
            var list = new List<Product>();

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM products WHERE ProductName LIKE @key OR SKU LIKE @key", conn);
                cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Product
                    {
                        SKU = reader["SKU"].ToString(),
                        Name = reader["ProductName"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        Price = Convert.ToDecimal(reader["Price"])
                    });
                }
            }

            RefreshProductList(list);
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

        private bool IsProductExists(string sku)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT COUNT(*) FROM products WHERE SKU = @sku", conn);
                cmd.Parameters.AddWithValue("@sku", sku);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private List<Product> GetAllProductsFromDB()
        {
            var list = new List<Product>();

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM products", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Product
                    {
                        SKU = reader["SKU"].ToString(),
                        Name = reader["ProductName"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        Price = Convert.ToDecimal(reader["Price"])
                    });
                }
            }

            return list;
        }
    }
}