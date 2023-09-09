namespace Asset.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class StockDetails
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int BRCODE { get; set; }

        [Required]
        public int ASSET_ID { get; set; }

        [Required]
        public int SECTION_ID { get; set; }

        [Required]
        public int SUBSEC_ID { get; set; }

        [Required]
        public int QUANTITY { get; set; }

        [ForeignKey("BRCODE")]
        public virtual Branch Branch { get; set; }

        [ForeignKey("ASSET_ID")]
        public virtual Asset Asset { get; set; }

        [ForeignKey("SECTION_ID")]
        public virtual AssetSection AssetSection { get; set; }

        [ForeignKey("SUBSEC_ID")]
        public virtual AssetSubSection AssetSubSection { get; set; }
    }

}
