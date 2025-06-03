using inventryUI.Models;
using inventryUI.Views;

namespace inventryUI.Controllers
{
    public class SupplierController
    {
        private readonly ISupplierView view;
        private readonly SupplierRepository repository;

        public SupplierController(ISupplierView view)
        {
            this.view = view;
            this.repository = new SupplierRepository();
            LoadSuppliers();
        }

        public void LoadSuppliers()
        {
            var suppliers = repository.GetAll();
            view.DisplaySuppliers(suppliers);
        }

        public void AddSupplier(string name, string contact)
        {
            var supplier = new Supplier { Name = name, ContactInfo = contact };
            repository.Add(supplier);
            LoadSuppliers();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            repository.Update(supplier);
            LoadSuppliers();
        }

        public void DeleteSupplier(int supplierId)
        {
            repository.Delete(supplierId);
            LoadSuppliers();
        }
    }
}
