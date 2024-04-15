namespace FinalPharmacy.Models.Customer
{
    public class PurchaseHistory
    {
        public int PurchaseHistoryId { get; set; }

        // Foreign key to link with Customer
        public int CustomerId { get; set; }
        public CustomerData Customer { get; set; }

        public int OrderId { get; set; } // Assuming you have a Product model
        public DateTime PurchaseDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
