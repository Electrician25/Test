using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Test.Areas.Identity.Data;
using Test.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<TestContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddDefaultIdentity<TestUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<TestContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseAuthorization();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
