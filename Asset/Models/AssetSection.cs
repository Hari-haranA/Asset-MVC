namespace Asset.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class AssetSection
{
    [Key]
    public int SectionId { get; set; }

    [Required]
    public int AssetId { get; set; }

    [Required]
    [MaxLength(30)]
    [Index(IsUnique = true)]
    public string Name { get; set; }

    [ForeignKey("AssetId")]
    public virtual Assets Asset { get; set; }

    public virtual ICollection<AssetSubSection> SubSections { get; set; }
}
