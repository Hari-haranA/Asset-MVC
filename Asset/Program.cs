using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Asset.Data;
using Asset.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'AssetContextConnection' not found.");

// Add Identity services and configure them
builder.Services.AddIdentity<LoginModel, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<LoginDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddDbContext<LoginDbContext>(options => options.UseSqlServer(connectionString));   
//builder.Services.AddDbContext<LoginDbContext>(options => options.UseSqlServer(connectionString));
//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<LoginDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//app.UseAuthentication(); // Middleware for authentication
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Dashboard}/{id?}");

app.Run();
