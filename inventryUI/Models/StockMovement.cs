
namespace inventryUI.Models
{
    public class StockMovement
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string MovementType { get; set; } // increase, decrease, adjust
        public int Quantity { get; set; }
        public string Reason { get; set; }
        public DateTime MovementDate { get; set; }
    }
}
