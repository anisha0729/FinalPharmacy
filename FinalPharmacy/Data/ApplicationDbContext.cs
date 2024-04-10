using FinalPharmacy.Models;
using FinalPharmacy.Models.Customer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalPharmacy.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       

        public DbSet<Customer> Customer { get; set; }
        public DbSet<MedicalHistory> MedicalHistory { get; set; }

       
    }


 }


