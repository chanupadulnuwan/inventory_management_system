using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventryUI.Models
{
        public class PurchaseOrder
        {
            public int OrderId { get; set; }
            public string ProductName { get; set; }
            public string SupplierName { get; set; }
            public int Quantity { get; set; }
            public string Status { get; set; } // "Pending", "Completed"
            public DateTime ExpectedDelivery { get; set; }

            public int MinStockThreshold { get; set; } = 5;
        }
    
}
