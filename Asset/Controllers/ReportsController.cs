using Asset.Data;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers
{
    public class ReportsController : Controller
    {
        private AssetManagementDbContext db = new AssetManagementDbContext();

        // Action for Asset Transaction List Report
        public ActionResult AssetTransactionList()
        {
            // Implement logic for generating the asset transaction list report
            return View();
        }

        // Action for Purchase Amount Wise Report
        public ActionResult PurchaseAmountWise()
        {
            // Implement logic for generating the purchase amount-wise report
            return View();
        }
    }

}
