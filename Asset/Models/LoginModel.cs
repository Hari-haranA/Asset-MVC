using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
namespace Asset.Models
{
    public class LoginModel : IdentityUser  
    {
       // public int EmployeeId { get; set; }

        
        public string UserName { get; set; }

        public string Password { get; set; }

       // public bool RememberMe { get; set; }
    }
}
