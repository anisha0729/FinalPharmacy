using FinalPharmacy.Data;
using FinalPharmacy.Models.Admin;
using FinalPharmacy.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalPharmacy.Controllers
{
    public class SupplierController:Controller
    {
        private readonly ApplicationDbContext dbContext;
        public SupplierController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult AddSupplier()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSupplier(SupplierVM ViewModels)
        {
            var supplier = new Supplier
            {
                SupplierName = ViewModels.SupplierName,
                SupplierId = ViewModels.SupplierId,
                Phone = ViewModels.Phone,
                ContactPerson = ViewModels.ContactPerson,
                Email = ViewModels.Email,

            };
            await dbContext.Supplier.AddAsync(supplier);
            await dbContext.SaveChangesAsync();
            return View();


        }
        [HttpGet]

        public async Task<IActionResult> ListSupplier()
        {
            var supplier = await dbContext.Supplier.ToListAsync();
            return View(supplier);
        }

    }
}
