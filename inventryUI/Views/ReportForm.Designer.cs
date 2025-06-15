namespace inventryUI.Models
{
    public class StockReportEntry
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class OrderHistoryEntry
    {
        public string OrderID { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }

    public class TopOrderedItem
    {
        public string ProductName { get; set; }
        public int OrderedCount { get; set; }
    }
}
