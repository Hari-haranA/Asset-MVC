
using Asset.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Asset.Models;
using System.Data.Entity;
using System.Text.Json;
using System.Data.Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Asset.Controllers
{
    public class AssetManagementController : Controller
    {
       // private AssetManagementDbContext db = new AssetManagementDbContext();
        public readonly AssetManagementDbContext db;
        public AssetManagementController(AssetManagementDbContext context) { db = context; }

        // Action for Asset Creation
        public ActionResult CreateAsset()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsset(CreateAssetView model)
        {
            if (ModelState!=null)
            {
                // Create Asset
                var asset = new Assets
                {
                    Name = model.AssetName,
                    Depreciation = model.Depreciation
                };
                db.Assets.Add(asset);
                await db.SaveChangesAsync();

                // Create AssetSection
                var section = new Asset_Section
                {
                    Name = model.SectionName,
                    Asset = asset,
                    //Asset_Id = asset.Asset_Id // Set the foreign key
                };
                db.Asset_Section.Add(section);
                await db.SaveChangesAsync();
               
                // Create AssetSubSection
                var subSection = new Asset_Sub_Section
                {
                    Name = model.SubSectionName,
                    Section = section,
                    //Section_Id = section.Section_Id // Set the foreign key
                };
                db.Asset_Sub_Section.Add(subSection);
                await db.SaveChangesAsync(); // Use async method

                //return RedirectToAction("CreateAssets");

                //db.Assets.Add(createAssetView.Asset);
                //db.Asset_Section.Add(createAssetView.AssetSection);
                //db.Asset_Sub_Section.Add(createAssetView.AssetSubSection);
                //await db.SaveChangesAsync();
                return RedirectToAction("ViewAssets");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult CreateSection()
        {
           return View();
            
        }
        [HttpGet]
        public ActionResult sectionjson()
        {
            var asset = db.Assets.ToList();
            var response = asset.Select(x => new { AssetId = x.Asset_Id, AssetName = x.Name }); // create JSON object
            return Json(response);
        }
        [HttpGet]
        public ActionResult subsectionjson()
        {
            var section = db.Asset_Section.ToList();
            var response = section.Select(x => new { SectionId = x.Section_Id, SectionName = x.Name }); // create JSON object
            return Json(response);
        }
        [HttpGet]
        public ActionResult asubsectionjson()
        {
            var sub_Section = db.Asset_Sub_Section.ToList();
            var response = sub_Section.Select(x => new { SubSecId = x.SubSec_Id, SubSecName = x.Name }); // create JSON object
            return Json(response);
        }
        [HttpPost]
        public async Task<ActionResult> CreateSection(CreateSectionView model)
        {
            if (ModelState.IsValid)
            {
                // Create a new AssetSection object and set its properties
                var assetSection = new Asset_Section
                {
                    // Set other properties based on the form input
                    Name=model.SectionName,
                    // Set the AssetTypeId based on the selected dropdown value
                    Asset_Id = model.Asset_Id
                };
                db.Asset_Section.Add(assetSection);
                await db.SaveChangesAsync();
                 // Create AssetSubSection
                var subSection = new Asset_Sub_Section
                {
                    Name = model.SubSectionName,
                    Section_Id = assetSection.Section_Id   
                   // Section = assetSection,
                    //Section_Id = section.Section_Id // Set the foreign key
                };
                db.Asset_Sub_Section.Add(subSection);
                await db.SaveChangesAsync(); // Use async method
                return RedirectToAction("ViewAssetsSection");
            }

            return View(model);
        }   
        public ActionResult CreateSubSection()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CreateSubSection(CreateSubSectionView model)
        {
            if (ModelState!=null)
            {
                var assetSubSection = new Asset_Sub_Section
                {
                    Name = model.SubSectionName, //using model createsubsectionview
                    Section_Id = model.Section_Id
                };
                db.Asset_Sub_Section.Add(assetSubSection);
                await db.SaveChangesAsync();
                return RedirectToAction("ViewAssetsSubSection");
            }
            return View();
        }

        // Action for viewing assets
       public async Task<ActionResult> ViewAssets()
        {
            return db.Assets != null ?
                View( db.Assets.ToList()) : Problem("Table 'AssetManagementDbContext.Assets' is Null.");
            //var assets = await db.Assets.ToListAsync();
            //return View(assets);
        }
    
        public  async Task<ActionResult> ViewAssetsSection()
        {
            return View(); 
                              
        }

        public async Task<ActionResult> viewsectionjson()
        {
            var queryResult = from asset in db.Assets
                              join section in db.Asset_Section
                              on asset.Asset_Id equals section.Asset_Id into joinedAssets
                              from section in joinedAssets.DefaultIfEmpty()
                              orderby asset.Asset_Id // Add this line to order by AssetId
                              select new
                              {
                                  AssetId = asset.Asset_Id,
                                  AssetName = asset.Name,
                                  Depreciation = asset.Depreciation,
                                  SectionId = section != null ? section.Section_Id : (int?)null,
                                  SectionName = section != null ? section.Name : null
                              };
            var resultList = queryResult.ToList();
            var response = resultList.Select(x => new { AssetId = x.AssetId, AssetName = x.AssetName, Depreciation = x.Depreciation, SectionId = x.SectionId, SectionName = x.SectionName }); // create JSON object
                                                                                                                                                                                              // Serialize the query result to JSON
                                                                                                                                                                                              //string jsonResult = JsonSerializer.Serialize(resultList);
                                                                                                                                                                                              // Return the JSON result
            return Json(resultList);

        }

        public async Task<ActionResult> ViewAssetsSubSection()
        {
              return  View();
        }
        public async Task<ActionResult> viewsubsectionjson()
        {
            var queryResult = from asset in db.Assets
                              join section in db.Asset_Section 
                              on asset.Asset_Id equals section.Asset_Id 
                             // from Section in db.Asset_Section
                              join subSection in db.Asset_Sub_Section
                              on section.Section_Id equals subSection.SubSec_Id into joinedAssets
                              from subSection in joinedAssets.DefaultIfEmpty()
                              orderby asset.Asset_Id // Add this line to order by AssetId
                              select new
                              {
                                  AssetId = asset.Asset_Id,
                                  AssetName = asset.Name,
                                  Depreciation = asset.Depreciation,
                                  SectionId = section != null ? section.Section_Id : (int?)null,
                                  SectionName = section != null ? section.Name : null,
                                  SubSectionId = subSection != null ? subSection.SubSec_Id : (int?)null,
                                  SubSectionName = subSection != null ? subSection.Name : null
                              };
            var resultList = queryResult.ToList();
            var response = resultList.Select(x => new { 
                AssetId = x.AssetId,
                AssetName = x.AssetName,
                Depreciation = x.Depreciation,
                SectionId = x.SectionId,
                SectionName = x.SectionName,
                SubSectionId = x.SubSectionId,
                SubSectionName = x.SubSectionName
                    }); // create JSON object
                                                                                                                                                                                              // Serialize the query result to JSON
                                                                                                                                                                                              //string jsonResult = JsonSerializer.Serialize(resultList);
                                                                                                                                                                                              // Return the JSON result
             return Json(resultList);

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
