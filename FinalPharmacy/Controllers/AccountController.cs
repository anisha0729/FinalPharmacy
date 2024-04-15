using FinalPharmacy.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalPharmacy.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<InventoryController> _logger;
        public AccountController(ApplicationDbContext dbContext, ILogger<InventoryController> logger)
        {
            this.dbContext = dbContext;
            _logger = logger;
        }

        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult Staff()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> StaffList()
        {
            var staff = await dbContext.Staff.ToListAsync();
            return View(staff);
        }
    }
}
