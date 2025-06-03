using inventryUI.Models;
using System.Collections.Generic;
using System.Linq;

namespace inventryUI.Controllers
{
    public class SupplierRepository
    {
        private List<Supplier> suppliers = new();
        private int nextId = 1;

        public List<Supplier> GetAll()
        {
            return suppliers;
        }

        public void Add(Supplier supplier)
        {
            supplier.SupplierID = nextId++;
            suppliers.Add(supplier);
        }

        public void Update(Supplier supplier)
        {
            var existing = suppliers.FirstOrDefault(s => s.SupplierID == supplier.SupplierID);
            if (existing != null)
            {
                existing.Name = supplier.Name;
                existing.ContactInfo = supplier.ContactInfo;
            }
        }

        public void Delete(int supplierId)
        {
            var supplier = suppliers.FirstOrDefault(s => s.SupplierID == supplierId);
            if (supplier != null)
                suppliers.Remove(supplier);
        }
    }
}
