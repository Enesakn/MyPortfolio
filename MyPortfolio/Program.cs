using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Context;
using System;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<MyPortfolioDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
