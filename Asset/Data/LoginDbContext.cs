using Microsoft.EntityFrameworkCore;
using Asset.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Asset.Data
{
    public class LoginDbContext: IdentityDbContext<IdentityUser>
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options)
            : base(options)
        {
        }
        //public DbSet<LoginModel> AspNetUsers { get; set; }
    }
}
