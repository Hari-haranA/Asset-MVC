namespace Asset.Models
{
    public class CreateAssetView
    {
        public Assets Asset { get; set; }
        public AssetSection AssetSection { get; set; }
        public AssetSubSection AssetSubSection { get; set; }

        public CreateAssetView()
        {
            Asset = new Assets();
            AssetSection = new AssetSection();
            AssetSubSection = new AssetSubSection();
        }
    }

}
