namespace Asset.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Branch
{
    [Key]
    public int BrCode { get; set; }

    [Required]
    [MaxLength(50)]
    public string BrName { get; set; }

    [Required]
    [MaxLength(25)]
    public string BrDistrict { get; set; }
}
