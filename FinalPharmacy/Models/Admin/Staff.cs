using System.ComponentModel.DataAnnotations.Schema;

namespace FinalPharmacy.Models.Admin
{
    public class Staff:ApplicationUser
    {
        public Guid StaffId { get; set; }
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
       
       public string Department { get; set; }
       
        [Column(TypeName = "decimal(18,2)")]

        public decimal Salary { get; set; }
        public DateOnly HireDate { get; set; }

        public string Position { get; set; }

    }
}
