namespace Asset.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PBill
    {
        [Key]
        public int PBID { get; set; }

      //  [Required]
        public int PID { get; set; }

        [Required]
        public long BILL_NO { get; set; }

        [Required]
        public DateTime BILL_DATE { get; set; }

        [Required]
        public int VENDOR_CODE { get; set; }

        [Required]
        [MaxLength(30)]
        public string COMPANY_NAME { get; set; }

        [Required]
        [MaxLength]
        public string PRODUCT_DESCRIPTION { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public decimal PAMOUNT { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public decimal TAMOUNT { get; set; }

        [ForeignKey("PID")]
        public virtual PurchaseEntry PurchaseEntry { get; set; }

        [ForeignKey("VENDOR_CODE")]
        public virtual Vendor Vendor { get; set; }
    }

}
