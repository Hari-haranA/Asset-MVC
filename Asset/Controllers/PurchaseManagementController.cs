using Asset.Data;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers
{
    public class PurchaseManagementController : Controller
    {
        //public AssetManagementDbContext db = new AssetManagementDbContext();
         public readonly AssetManagementDbContext db;
        public PurchaseManagementController(AssetManagementDbContext context) {             db=context;   }
        [HttpGet]
        public ActionResult branchjson()
        {
            var asset = db.Branch.ToList();
            var response = asset.Select(x => new { branchid = x.BrCode , branchname = x.BrName }); // create JSON object
            return Json(response);
        }
        [HttpGet]
        public ActionResult vjson()
        {
            var asset = db.Vendor.ToList();
            var response = asset.Select(x => new { vid = x.Vendor_Code, vname = x.VName }); // create JSON object
            return Json(response);
        }
        // Action for Purchase Entry (Create)
        public ActionResult CreatePurchase()
        {
            // Implement logic for creating purchase entries
            return View();
        }

        // Action for viewing purchase entries
        public ActionResult ViewPurchases()
        {
            // Implement logic for viewing purchase entries (search by branch or purchase ID)
         //   var purchases = db.Purchase_Entry.ToList();
            return View();
        }

        public ActionResult EditPurchases()
        {
            return View();
        }

        // Action for Asset Transfer Entry (Create)
        public ActionResult CreateAssetTransfer()
        {
            // Implement logic for creating asset transfer entries
            return View();
        }

        // Other actions for CRUD operations in purchase management
    }
}
