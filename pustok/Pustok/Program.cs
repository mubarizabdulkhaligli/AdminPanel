using Microsoft.EntityFrameworkCore;
using Pustok.DAL;
using Pustok.Services;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PustokDbContext>(opt =>
{
    opt.UseSqlServer("Server=WIN-V54CU0NE9TB; Database=Pustok; Trusted_Connection=True");
});


builder.Services.AddScoped<LayoutService>();

builder.Services.AddHttpContextAccessor();


var app = builder.Build();


app.UseStaticFiles();


app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
