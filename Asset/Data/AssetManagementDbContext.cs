namespace Asset.Data
{
    using Asset.Models;
    using System.Data.Entity;

    public class AssetManagementDbContext : DbContext
    {
        public AssetManagementDbContext() : base("DefaultConnection")
        {
        }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetSection> AssetSections { get; set; }
        public DbSet<AssetSubSection> AssetSubSections { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<PurchaseEntry> PurchaseEntries { get; set; }
        public DbSet<SaleEntry> SaleEntries { get; set; }
        public DbSet<PBill> PBills { get; set; }
        public DbSet<SBill> SBills { get; set; }
        public DbSet<StockDetails> StockDetails { get; set; }
        public DbSet<AssetTransfer> AssetTransfers { get; set; }
    }

}
