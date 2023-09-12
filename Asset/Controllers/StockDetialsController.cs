using Asset.Data;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers
{
    public class StockDetailsController : Controller
    {
        //private AssetManagementDbContext db = new AssetManagementDbContext();
        public readonly AssetManagementDbContext db;
        public StockDetailsController(AssetManagementDbContext context) { db = context; }
        // Action for viewing stock details (Branch Wise)
        public ActionResult BranchWiseStock()
        {
            // Implement logic for viewing stock details by branch
            return View();
        }

        // Action for viewing stock details (Asset Wise)
        public ActionResult AssetWiseStock()
        {
            // Implement logic for viewing stock details by asset
            return View();
        }

        // Action for viewing stock details (Asset Section Wise)
        public ActionResult AssetSectionWiseStock()
        {
            // Implement logic for viewing stock details by asset section
            return View();
        }

        // Action for viewing stock details (Asset Sub Section Wise)
        public ActionResult AssetSubSectionWiseStock()
        {
            // Implement logic for viewing stock details by asset sub-section
            return View();
        }
    }
}
