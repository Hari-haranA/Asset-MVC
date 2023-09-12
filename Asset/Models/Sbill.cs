namespace Asset.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SBill
    {
        [Key]
        public int SBID { get; set; }

        [Required]
        public int SID { get; set; }

        [Required]
        public int VENDOR_CODE { get; set; }

        [Required]
        public long BILL_NO { get; set; }

        [Required]
        public DateTime BILL_DATE { get; set; }

        [Required]
        [MaxLength]
        public string PROD_DESCRIPTION { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public decimal DEP_VALUE { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public decimal AFTER_DEP { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public decimal SALEAMOUNT { get; set; }

        //[ForeignKey("SID")]
        //public virtual SaleEntry SaleEntry { get; set; }

        //[ForeignKey("VENDOR_CODE")]
        //public virtual Vendor Vendor { get; set; }
    }

}
