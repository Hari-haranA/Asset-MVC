﻿using Asset.Data;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Controllers
{
    public class VendorManagementController : Controller
    {
        private AssetManagementDbContext db = new AssetManagementDbContext();

        // Action for Vendor Creation
        public ActionResult CreateVendor()
        {
            // Implement logic for creating vendors
            return View();
        }

        // Action for viewing vendors
        public ActionResult ViewVendors()
        {
            // Implement logic for viewing vendors (CRUD operations)
            var vendors = db.Vendor.ToList();
            return View(vendors);
        }

        // Other CRUD actions for vendors
    }
}
