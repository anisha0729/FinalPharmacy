using FinalPharmacy.Models.Customer;
namespace FinalPharmacy.Models.Admin
{
    public class Invoice
    {
        public Guid InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerData Customer { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsPaid { get; set; }
    }
}
