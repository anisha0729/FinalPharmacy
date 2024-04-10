using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FinalPharmacy.Models.Customer
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        public Guid Id {  get; set; }
        public ApplicationUser User { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string BloodType { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmergencyContactNumber {  get; set; }
        public string Email { get; set; }

    }
}
