using inventryUI.Models;
using System.Collections.Generic;

namespace inventryUI.Views
{
    public interface ISupplierView
    {
        void DisplaySuppliers(List<Supplier> suppliers);
        Supplier GetSelectedSupplier();
    }
}
