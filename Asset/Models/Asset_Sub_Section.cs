namespace Asset.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Asset_Sub_Section
{
    [Key]
    public int SubSec_Id { get; set; }

    public int Section_Id { get; set; }

    [Required]
    [MaxLength(30)]
    [Index(IsUnique = true)]
    public string Name { get; set; }

    [ForeignKey("Section_Id")]
    public virtual Asset_Section Section { get; set; }
}
