namespace Asset.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Vendor
{
    [Key]
    public int VendorCode { get; set; }

    [Required]
    [MaxLength(30)]
   // [Index(IsUnique = true)]
    public string VName { get; set; }

    [Required]
    [MaxLength(30)]
    public string PersonName { get; set; }

    [Required]
    public long MobileNo { get; set; }

    public long? PhoneNo { get; set; }

    [Required]
    [MaxLength(50)]
    public string VAddress { get; set; }

    [Required]
    [MaxLength(15)]
    public string City { get; set; }

    [Required]
    [MaxLength(15)]
    public string State { get; set; }

    [Required]
    [MaxLength(20)]
    //[Index(IsUnique = true)]
    public string GSTNo { get; set; }

    [Required]
    [MaxLength(10)]
    //[Index(IsUnique = true)]
    public string PANNo { get; set; }

    [MaxLength(20)]
    public string TINNo { get; set; }
}
