namespace Asset.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AssetTransfer
    {
        [Key]
        public int TID { get; set; }

        [Required]
        public int SUBSEC_ID { get; set; }

        [Required]
        public int PID { get; set; }

        [Required]
        public int FROM_BRANCH { get; set; }

        [Required]
        public int TO_BRANCH { get; set; }

        [ForeignKey("SUBSEC_ID")]
        public virtual AssetSubSection AssetSubSection { get; set; }

        [ForeignKey("PID")]
        public virtual PBill PBill { get; set; }

        //[ForeignKey("FROM_BRANCH")]
        //public virtual Branch FromBranch { get; set; }

        [ForeignKey("TO_BRANCH")]
        public virtual Branch ToBranch { get; set; }
    }

}
