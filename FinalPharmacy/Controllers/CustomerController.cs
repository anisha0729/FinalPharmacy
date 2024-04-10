using FinalPharmacy.Data;
using FinalPharmacy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace FinalPharmacy.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public CustomerController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public IActionResult CustomerProfile()
        {
            return View();
        }
        public IActionResult MedicalHistory()
        {
            return View();
        }
        public IActionResult PurchaseHistory()
        {
            return View();
        }
    }
}
