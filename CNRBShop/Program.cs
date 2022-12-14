using CNRBShop.DbContexts;
using CNRBShop.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddScoped<IProductRepository,ProductRepository>();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CNRBShopContext>(
    dbContextOptions => {
        dbContextOptions.UseSqlite(builder.Configuration["ConnectionStrings:CNRBShopMvcDBConnectionString"]);
        });

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
