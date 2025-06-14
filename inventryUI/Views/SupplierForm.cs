using inventryUI.Models;
using inventryUI.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace inventryUI.Controllers
{
    public class SupplierController
    {
        private readonly SupplierForm view;
        private List<Supplier> suppliers = new(); // holds current DB copy
        private int nextId = 1;

        public SupplierController(SupplierForm view)
        {
            this.view = view;
            LoadSuppliers();
        }

        public void LoadSuppliers()
        {
            suppliers = GetAllSuppliersFromDatabase(); // update local cache
            view.DisplaySuppliers(suppliers);
        }

        public bool AddSupplier(string name, string contact, string product)
        {
            // Check for duplicate name
            var sameName = suppliers.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (sameName != null)
            {
                view.ShowMessage($"A supplier with the name '{name}' already exists.", "Duplicate Name", MessageBoxIcon.Warning);
                return false;
            }

            // Check for duplicate contact info
            var sameContact = suppliers.FirstOrDefault(s => s.ContactInfo.Equals(contact, StringComparison.OrdinalIgnoreCase));
            if (sameContact != null)
            {
                view.ShowMessage($"A supplier with the contact info '{contact}' already exists.", "Duplicate Contact", MessageBoxIcon.Warning);
                return false;
            }

            // Save to DB
            AddSupplierToDatabase(name, contact, product);
            LoadSuppliers();
            return true;
        }

        public List<Supplier> SearchSuppliers(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return suppliers;

            return suppliers.Where(s =>
                s.Name.ToLower().Contains(query.ToLower()) ||
                s.SupplierID.ToString().Contains(query)
            ).ToList();
        }

        public void AddSupplierToDatabase(string name, string contact, string product)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO suppliers (Name, ContactInfo, Product) VALUES (@name, @contact, @product)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@product", product);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Supplier> GetAllSuppliersFromDatabase()
        {
            var list = new List<Supplier>();

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM suppliers";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Supplier
                        {
                            SupplierID = reader.GetInt32("SupplierID"),
                            Name = reader.GetString("Name"),
                            ContactInfo = reader.GetInt32("ContactInfo").ToString(), // assuming DB column is INT
                            Product = reader.GetString("Product")
                        });
                    }
                }
            }

            return list;
        }

        public void UpdateSupplier(Supplier updatedSupplier)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE suppliers SET Name = @name, ContactInfo = @contact, Product = @product WHERE SupplierID = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", updatedSupplier.Name);
                    cmd.Parameters.AddWithValue("@contact", updatedSupplier.ContactInfo);
                    cmd.Parameters.AddWithValue("@product", updatedSupplier.Product);
                    cmd.Parameters.AddWithValue("@id", updatedSupplier.SupplierID);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadSuppliers();
        }

        public void DeleteSupplier(int supplierId)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM suppliers WHERE SupplierID = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", supplierId);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadSuppliers();
        }
    }
}
