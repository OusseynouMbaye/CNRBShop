using CNRBShop.DbContexts;
using CNRBShop.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IProductRepository, MockProductRepository>();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CNRBShopContext>(
    dbContextOptions =>
    {
        dbContextOptions.UseSqlite(builder.Configuration["ConnectionStrings:CNRBShopDBConnectionString"]);
    });

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
