using Asset.Data;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers
{
    public class SalesManagementController : Controller
    {
        private AssetManagementDbContext db = new AssetManagementDbContext();

        // Action for Sales Entry (Create)
        public ActionResult CreateSale()
        {
            // Implement logic for creating sales entries
            return View();
        }

        // Action for viewing sales entries
        public ActionResult ViewSales()
        {
            // Implement logic for viewing sales entries (search by branch or sale ID)
            var sales = db.Sale_Entry.ToList();
            return View(sales);
        }

        // Other actions for CRUD operations in sales management
    }
}
