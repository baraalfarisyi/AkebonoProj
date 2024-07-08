using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AkebonoProj.Data;
using AkebonoProj.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AkebonoProjContextConnection") ?? throw new InvalidOperationException("Connection string 'AkebonoProjContextConnection' not found.");

builder.Services.AddDbContext<AkebonoProjContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<AkebonoProjUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AkebonoProjContext>();

// Add services to the container.
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

app.MapRazorPages();

app.Run();
