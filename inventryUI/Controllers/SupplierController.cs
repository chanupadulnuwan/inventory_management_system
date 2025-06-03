using inventryUI.Models;
using inventryUI.Views;
using System.Collections.Generic;
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

        public void AddSupplier(string name, string contact)
        {
            Supplier supplier = new Supplier
            {
                SupplierID = nextId++,
                Name = name,
                ContactInfo = contact
            };

            suppliers.Add(supplier);
            LoadSuppliers();
        }

        public void UpdateSupplier(Supplier updatedSupplier)
        {
            var existing = suppliers.FirstOrDefault(s => s.SupplierID == updatedSupplier.SupplierID);
            if (existing != null)
            {
                existing.Name = updatedSupplier.Name;
                existing.ContactInfo = updatedSupplier.ContactInfo;
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
