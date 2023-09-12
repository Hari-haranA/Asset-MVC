using Asset.Data;
using Asset.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers
{
    public class VendorManagementController : Controller
    {
        //private AssetManagementDbContext db = new AssetManagementDbContext();
        public readonly AssetManagementDbContext db;
        public VendorManagementController(AssetManagementDbContext context) { db = context; }
        // Action for Vendor Creation
        public ActionResult CreateVendor()
        {
            // Implement logic for creating vendors
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateVendor(Vendor model)
        {
            if(ModelState.IsValid)
            {
                db.Vendor.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction("ViewVendors");
            }
            // Implement logic for creating vendors
            return View(model);
        }
        // Action for viewing vendors
        public ActionResult ViewVendors()
        {
            //Implement logic for viewing vendors (CRUD operations)
           var vendors = db.Vendor.ToList();
            return View(vendors);
        }

        [HttpGet]
        public async Task<ActionResult> EditVendor(int? id)
        {
            if(id == null || db.Vendor == null)
            {
                return NotFound();
            }
            var vendor = await db.Vendor.FindAsync(id);
            if(vendor == null)
            {
                return NotFound();
            }
            return View(vendor);
        }
        [HttpPost]
        public async Task<IActionResult> EditVendor(int id, [Bind("vendor_code,vname,person_name,mobile_no,phone_no,vaddress,city,state,gst_no,pan_no,tin_no")] Vendor vendor)
        {
            if(ModelState!=null)
            {
                db.Vendor.Update(vendor);
                await db.SaveChangesAsync();
                return RedirectToAction("ViewVendors");
            }
            return View(vendor);

        }

        public async Task<ActionResult> DetailsVendor(int ? id)
        {
            if (id == null || db.Vendor == null)
            {
                return NotFound();
            }
            var vendor = await db.Vendor.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
            return View(vendor);
        }

        // Other CRUD actions for vendors
    }
}
