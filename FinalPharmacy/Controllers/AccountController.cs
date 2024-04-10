using Microsoft.AspNetCore.Mvc;

namespace FinalPharmacy.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult Staff()
        {
            return View();
        }
    }
}
