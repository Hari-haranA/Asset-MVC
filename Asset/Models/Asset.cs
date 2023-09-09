using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Asset.Models;
public class Asset
{
    [Key]
    public int AssetId { get; set; }

    [Required]
    [MaxLength(30)]
    [Index(IsUnique = true)]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Depreciation { get; set; }

    public virtual ICollection<AssetSection> Sections { get; set; }
}

