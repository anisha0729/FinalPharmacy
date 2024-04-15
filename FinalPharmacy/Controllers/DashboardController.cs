using Microsoft.AspNetCore.Mvc;

namespace FinalPharmacy.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult CustomerDashboard()
        {
            return View();
        }
        public IActionResult AdminStaffDashboard()
        {
            return View();
        }
    }
}
