namespace Asset.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class AssetSubSection
{
    [Key]
    public int SubSectionId { get; set; }

    [Required]
    public int SectionId { get; set; }

    [Required]
    [MaxLength(30)]
    [Index(IsUnique = true)]
    public string Name { get; set; }

    [ForeignKey("SectionId")]
    public virtual AssetSection Section { get; set; }
}
