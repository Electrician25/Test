using Microsoft.EntityFrameworkCore;
using Test.Areas.Identity.Data;
using Test.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc(options => { options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute()); });

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<TestContext>(options => options.UseNpgsql(connectionString));
builder.Services.AddDbContext<KeysContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddDefaultIdentity<TestUser>(options => 
	options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<TestContext>();

builder.Services.AddDataProtection().PersistKeysToDbContext<KeysContext>();

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