using inventryUI.Models;
using inventryUI.Views;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace inventryUI.Controllers
{
    public class SupplierController
    {
        private readonly SupplierForm view;

        // ⬇️ These used to be in SupplierRepository.cs
        private List<Supplier> suppliers = new();
        private int nextId = 1;

        public SupplierController(SupplierForm view)
        {
            this.view = view;
            LoadSuppliers();
        }

        public void LoadSuppliers()
        {
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

            // Add supplier if all checks pass
            Supplier supplier = new Supplier
            {
                SupplierID = nextId++,
                Name = name,
                ContactInfo = contact,
                Product = product
            };


            suppliers.Add(supplier);
            LoadSuppliers();
            return true;
        }
        public List<Supplier> SearchSuppliers(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return suppliers;

            return suppliers.Where(s =>
                s.Name.ToLower().Contains(query) ||
                s.SupplierID.ToString().Contains(query)
            ).ToList();
        }







        public void UpdateSupplier(Supplier updatedSupplier)
        {
            var existing = suppliers.FirstOrDefault(s => s.SupplierID == updatedSupplier.SupplierID);
            if (existing != null)
            {
                existing.Name = updatedSupplier.Name;
                existing.ContactInfo = updatedSupplier.ContactInfo;
                existing.Product = updatedSupplier.Product;

                LoadSuppliers();
            }
        }

        public void DeleteSupplier(int supplierId)
        {
            var supplier = suppliers.FirstOrDefault(s => s.SupplierID == supplierId);
            if (supplier != null)
            {
                suppliers.Remove(supplier);
                LoadSuppliers();
            }
        }
       


    }
}
