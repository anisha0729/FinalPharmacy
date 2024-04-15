using System.ComponentModel.DataAnnotations;

namespace FinalPharmacy.Models.Admin
{
    public class Supplier
    {
        [Key]
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

}
