using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
namespace Asset.Models
{
    public class LoginModel : IdentityUser
    {
        // public int EmployeeId { get; set; }

        //[Required]
        //public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

       // public bool RememberMe { get; set; }
    }
}
