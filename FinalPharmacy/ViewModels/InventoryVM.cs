using FinalPharmacy.Models.Admin;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalPharmacy.ViewModels
{
    public class InventoryVM
    {
        public Guid ProductId { get; set; }

        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitCost { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCost { get; set; }
        public int BatchNumber { get; set; }
        public int Capacity { get; set; }
        public int Quantity { get; set; }

        public string StockStatus
        {
            get
            {
                int frac = Capacity / 4;


                if (2 * frac >= Quantity)
                {
                    return "CHECK ⚠️";

                }
                else if (frac < Quantity)
                {
                    return "OK ✅";
                }

                else
                {
                    return "UNKNOWN !";
                }
            }
        }
    }
}
