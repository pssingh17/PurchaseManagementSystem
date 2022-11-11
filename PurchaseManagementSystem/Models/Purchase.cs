namespace PurchaseManagementSystem.Models
{
    public class Purchase
    {
        public int ID { get; set; }
        public string? ItemName { get; set; }

        public int Price { get; set; }

        public int Availability { get; set; }
    }
}
