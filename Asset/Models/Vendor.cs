namespace Asset.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Vendor
{
    [Key]
    public int Vendor_Code { get; set; }

    [Required]
    [MaxLength(30)]
   // [Index(IsUnique = true)]
    public string VName { get; set; }

    [Required]
    [MaxLength(30)]
    public string Person_Name { get; set; }

    [Required]
    public long Mobile_No { get; set; }

    public long? Phone_No { get; set; }

    [Required]
    [MaxLength(50)]
    public string VAddress { get; set; }

    
    [MaxLength(15)]
    public string City { get; set; }

    [Required]
    [MaxLength(15)]
    public string State { get; set; }

    [Required]
    [MaxLength(20)]
    //[Index(IsUnique = true)]
    public string GST_No { get; set; }

    [Required]
    [MaxLength(10)]
    //[Index(IsUnique = true)]
    public string PAN_No { get; set; }

    [MaxLength(20)]
    public string TIN_No { get; set; }
}
