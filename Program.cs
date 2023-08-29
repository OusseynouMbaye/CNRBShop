using CNRBShop.DbContexts;
using CNRBShop.Services.Implementations;
using CNRBShop.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductRepository, ProductRepository>();    

// Serilog, logging, repository
builder.Services.AddControllersWithViews();

// db context
builder.Services.AddDbContext<CNRBShopDbContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:CNRBShopDb123ConnectionString"]));

var app = builder.Build();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
