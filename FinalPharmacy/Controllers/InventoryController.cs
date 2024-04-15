using FinalPharmacy.Data;
using FinalPharmacy.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using FinalPharmacy.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace FinalPharmacy.Controllers
{
    public class InventoryController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<InventoryController> _logger;
        public InventoryController(ApplicationDbContext dbContext, ILogger<InventoryController> logger)
        {
            this.dbContext = dbContext;
            _logger = logger;
        }
      
        [HttpGet]
        public IActionResult AddInventory()
        { try
            {
                var suppliers = dbContext.Supplier.ToList();
                var supplierItems = suppliers.Select(s => new SelectListItem { Value = s.SupplierId.ToString(), Text = s.SupplierName });
                ViewBag.Suppliers = supplierItems;

                return View();
            }
            catch (Exception ex)
            {
                // Log the exception or perform any necessary error handling
                // For example, you can log the exception and return a custom error view
                _logger.LogError(ex, "An error occurred while fetching data for AddInventory view");
                return RedirectToAction("Error", "Home");
            }
        }
       
        [HttpPost]
        public async Task<IActionResult>AddInventory(InventoryVM ViewModels)
        {
            var inventory = new Inventory
            {
                ProductName = ViewModels.ProductName,
                ProductCategory = ViewModels.ProductCategory,
                PurchaseDate = ViewModels.PurchaseDate,
                SupplierId = ViewModels.SupplierId,
                UnitCost = ViewModels.UnitCost,
                TotalCost = ViewModels.TotalCost,
                BatchNumber = ViewModels.BatchNumber,
                Capacity = ViewModels.Capacity,
                Quantity = ViewModels.Quantity,


            };

            await dbContext.Inventory.AddAsync(inventory);
            await dbContext.SaveChangesAsync();
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> ListInventory()
        {
            var inventory = await dbContext.Inventory.ToListAsync();
            return View(inventory);
        }
        [HttpGet]
        public async Task<IActionResult>EditInventory(Guid ProductId)
        {

            var inventory = await dbContext.Inventory.FindAsync(ProductId);
            var suppliers = await dbContext.Supplier.ToListAsync();
            var supplierItems = suppliers.Select(s => new SelectListItem { Value = s.SupplierId.ToString(), Text = s.SupplierName });
            ViewBag.Suppliers = supplierItems;

            return View(inventory);
        }
        [HttpPost]
        public async Task<IActionResult>EditInventory(Inventory viewModel)
        {
            var inventory = await dbContext.Inventory.FindAsync(viewModel.ProductId);
            if(inventory is not null) { 
            inventory.ProductName = viewModel.ProductName;
                inventory.ProductCategory = viewModel.ProductCategory;
                inventory.PurchaseDate = viewModel.PurchaseDate;
                inventory.SupplierId = viewModel.SupplierId;
                inventory.UnitCost = viewModel.UnitCost;
                inventory.TotalCost = viewModel.TotalCost;
                inventory.BatchNumber = viewModel.BatchNumber;
                inventory.Capacity = viewModel.Capacity;
                inventory.Quantity = viewModel.Quantity;
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("ListInventory", "Inventory");
        }




    }
}
