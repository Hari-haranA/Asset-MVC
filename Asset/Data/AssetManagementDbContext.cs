namespace Asset.Data
{
    using Asset.Models;
    using System.Data.Entity;

    public class AssetManagementDbContext : DbContext
    {
        public AssetManagementDbContext() : base("DefaultConnection")
        {
        }
        public DbSet<Assets> Assets { get; set; }
        public DbSet<AssetSection> Asset_Section { get; set; }
        public DbSet<AssetSubSection> Asset_Sub_Section { get; set; }
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
