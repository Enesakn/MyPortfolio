using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Context;
using System;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<MyPortfolioDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}"
);

app.Run();
