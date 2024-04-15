namespace FinalPharmacy.Models.Admin
{
    public class Transactions
    {
        public int TransactionId { get; set; }
        public DateTime DateTime { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        
    }
}
