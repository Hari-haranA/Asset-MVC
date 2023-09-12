namespace Asset.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Asset_Section
{
    [Key]
    public int Section_Id { get; set; }

    public int Asset_Id { get; set; }

    
    [MaxLength(30)]
    [Index(IsUnique = true)]
    public string Name { get; set; }

    [ForeignKey("Asset_Id")]
    public virtual Assets Asset { get; set; }

    public virtual ICollection<Asset_Sub_Section> SubSections { get; set; }
}
