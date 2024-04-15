using FinalPharmacy.Models.Customer;

namespace FinalPharmacy.Models.Admin
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid CustomerId { get; set; }

        public CustomerData Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal TotalAmount
        {
            get
            {
                decimal total = 0;
                foreach (var item in OrderItems)
                {
                    total += item.Quantity * item.UnitPrice;
                }
                return total;
            }
        }
    }

    public class OrderItem
    {
        public Guid OrderItemId { get; set; }
        public Medicine Medicine { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

}
