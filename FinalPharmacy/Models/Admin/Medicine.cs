using System.ComponentModel.DataAnnotations.Schema;

namespace FinalPharmacy.Models.Admin
{
    public class Medicine
    {
        public Guid MedicineId { get; set; }

        // Specific properties for Medicine items
        public string MedicineName { get; set; }
        public string Manufacturer { get; set; }
        public float Quantity { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime ManufactureDate { get; set; }

        public decimal Price { get; set; }

        // Foreign key relationship with Inventory
        [ForeignKey("Inventory")]
        public Guid ProductId { get; set; }
        public Inventory Inventory { get; set; }


    }
}
