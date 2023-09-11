namespace Asset.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SaleEntry
    {
        [Key]
        public int SID { get; set; }

        [Required]
        public int PID { get; set; }

        public int? BRCODE { get; set; }

        [Required]
        public int VENDOR_CODE { get; set; }

        [Required]
        public DateTime ENTRY_DATE { get; set; }

        [Required]
        public int A_ID { get; set; }

        [Required]
        public int ASEC_ID { get; set; }

        [Required]
        public int ASUBSEC_ID { get; set; }

        [MaxLength]
        public string SOLD_ITEM { get; set; }

        public int? QUANTITY { get; set; }

        public byte[] INVOICE { get; set; }

        [ForeignKey("PID")]
        public virtual PurchaseEntry PurchaseEntry { get; set; }

        [ForeignKey("BRCODE")]
        public virtual Branch Branch { get; set; }

        [ForeignKey("VENDOR_CODE")]
        public virtual Vendor Vendor { get; set; }

        //[ForeignKey("A_ID")]
        //public virtual Assets Asset { get; set; }

        //[ForeignKey("ASEC_ID")]
        //public virtual AssetSection AssetSection { get; set; }

        [ForeignKey("ASUBSEC_ID")]
        public virtual AssetSubSection AssetSubSection { get; set; }
    }

}
