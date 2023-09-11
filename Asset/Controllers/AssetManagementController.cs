

using Asset.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Asset.Models;
using System.Data.Entity;

namespace Asset.Controllers
{
    public class AssetManagementController : Controller
    {
        private AssetManagementDbContext db = new AssetManagementDbContext();

        // Action for Asset Creation
        public ActionResult CreateAsset()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsset(CreateAssetView createAssetView)
        {
            if (ModelState!=null)
            {
                db.Assets.Add(createAssetView.Asset);
                db.Asset_Section.Add(createAssetView.AssetSection);
                db.Asset_Sub_Section.Add(createAssetView.AssetSubSection);
                await db.SaveChangesAsync();
                return RedirectToAction("ViewAssets");
            }

            return View(createAssetView);
        }

        public ActionResult CreateSection()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CreateSection(AssetSection section)
        {
            if (ModelState.IsValid)
            {
                db.Asset_Section.Add(section);
                await db.SaveChangesAsync();
                return RedirectToAction("ViewAssetsSection");
            }

            return View(section);
        }   
        public ActionResult CreateSubSection()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CreateSubSection(AssetSubSection subsection)
        {
            if (ModelState.IsValid)
            {
                db.Asset_Sub_Section.Add(subsection);
                await db.SaveChangesAsync();
                return RedirectToAction("ViewAssetsSubSection");
            }

            return View(subsection);
        }

        // Action for viewing assets
       public async Task<ActionResult> ViewAssets()
        {
            return db.Assets != null ?
                View(await db.Assets.ToListAsync()) : Problem("Table is Null.");
        }
        public async Task<ActionResult> ViewAssetsSection()
        {
            return db.Asset_Section != null ?
                View(await db.Asset_Section.ToListAsync()) : Problem("Table is Null.");
        }
        public async Task<ActionResult> ViewAssetsSubSection()
        {
            return db.Asset_Sub_Section != null ?
                View(await db.Asset_Sub_Section.ToListAsync()) : Problem("Table is Null.");
        }

        public ActionResult EditAsset()
        {
            return View();
        }

        public ActionResult EditSection()
        {
            return View();
        }

        public ActionResult EditSubSection() 
        {
            return View();
        }

        // Other CRUD actions for assets
    }
}
