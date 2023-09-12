
    using Asset.Models;
    //using System.Data.Entity;
    using Microsoft.EntityFrameworkCore;
   
namespace Asset.Data
{
    public class AssetManagementDbContext : DbContext
    {
        public AssetManagementDbContext(DbContextOptions<AssetManagementDbContext>options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false; // To disable lazy loading
        }
        public DbSet<Assets> Assets { get; set; }
        public DbSet<Asset_Section> Asset_Section { get; set; }
        public DbSet<Asset_Sub_Section> Asset_Sub_Section { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<PurchaseEntry> Purchase_Entry { get; set; }
        public DbSet<SaleEntry> Sale_Entry { get; set; }
        public DbSet<PBill> PBill { get; set; }
        public DbSet<SBill> SBill { get; set; }
        public DbSet<StockDetails> Stock_Details { get; set; }
        public DbSet<AssetTransfer> Asset_Transfer { get; set; }
    }

}
