using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using DataAccess.Models; // namespace c?a DbContext (nõi scaffold ra)

var builder = WebApplication.CreateBuilder(args);

	// ? c?u h?nh DbContext dùng connection string trong appsettings.json
builder.Services.AddDbContext<ShoppingCartDbFirstContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
