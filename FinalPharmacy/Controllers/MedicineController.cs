/*using FinalPharmacy.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalPharmacy.Controllers
{
    public class MedicineController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public MedicineController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost]
        public async Task<IActionResult> SellMedicine(Guid medicineId, int quantity)
        {
            var medicine = await dbContext.Medicine.FindAsync(medicineId);
            if (medicine == null)
            {
                return NotFound(); // Handle case where medicine is not found
            }

            // Check if there is enough quantity in inventory
            var inventoryItem = await dbContext.Inventory.FindAsync(medicine.ProductId);
            if (inventoryItem.Quantity < quantity)
            {
                ModelState.AddModelError(string.Empty, "Insufficient quantity in inventory.");
                return View("Sell", medicine); // Return to the sell page with error message
            }

            // Update medicine and inventory quantities
            medicine.Quantity -= quantity;
            inventoryItem.Quantity -= quantity;

            // Save changes to the database
            await dbContext.SaveChangesAsync();

            return RedirectToAction("ListInventory", "Inventory");
        }
    }
}
*/