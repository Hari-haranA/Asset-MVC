using Asset.Data;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers
{
    public class AssetManagementController : Controller
    {
        private AssetManagementDbContext db = new AssetManagementDbContext();

        // Action for Asset Creation
        public ActionResult CreateAsset()
        {
            // Implement logic for creating assets
            return View();
        }

        // Action for viewing assets
        public ActionResult ViewAssets()
        {
            // Implement logic for viewing assets (CRUD operations)
            var assets = db.Assets.ToList();
            return View(assets);
        }

        // Other CRUD actions for assets
    }
}
