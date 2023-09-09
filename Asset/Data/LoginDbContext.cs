using Microsoft.EntityFrameworkCore;
using Asset.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;    
namespace Asset.Data
{
    public class LoginDbContext: IdentityDbContext<LoginModel>
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options)
            : base(options)
        {
        }
        //public DbSet<LoginModel> AspNetUsers { get; set; }
    }
}
