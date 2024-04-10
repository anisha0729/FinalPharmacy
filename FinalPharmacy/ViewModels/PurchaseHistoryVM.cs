namespace FinalPharmacy.ViewModels
{
    public class PurchaseHistoryVM
    {
        public int OrderId { get; set; } // Assuming you have a Product model
        public DateTime PurchaseDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
