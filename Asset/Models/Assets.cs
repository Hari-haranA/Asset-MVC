using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Asset.Models
{
    public class Assets
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Asset_Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [Required]
        //[Column(TypeName = "decimal(18,2)")]
        public decimal Depreciation { get; set; }

        public virtual ICollection<Asset_Section> Sections { get; set; }
    }

}