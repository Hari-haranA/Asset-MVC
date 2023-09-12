namespace Asset.Models
{
    public class CreateAssetView
    {
        // Properties for Asset
        public string AssetName { get; set; }
        public decimal Depreciation { get; set; }

       // public int Asset_Id { get; set; }

        // Properties for AssetSection
        public string SectionName { get; set; }

        // Properties for AssetSubSection
        public string SubSectionName { get; set; }

        //public Assets Asset { get; set; }
        //public AssetSection AssetSection { get; set; }
        //public AssetSubSection AssetSubSection { get; set; }

        //public CreateAssetView()
        //{
        //    Asset = new Assets();
        //    AssetSection = new AssetSection();
        //    AssetSubSection = new AssetSubSection();
        //}
    }

}
