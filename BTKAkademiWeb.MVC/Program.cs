using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;
using BTKAkademiWeb.MVC.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
    b => b.MigrationsAssembly("BTKAkademiWeb.MVC"));
});
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.Cookie.Name = "BTKAkademiWeb.MVC.Session";
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<Cart>();

builder.Services.AddSingleton<Cart>();

builder.Services.AddScoped<Cart>(c => SessionCart.GetCart(c));

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

app.UseStaticFiles();
app.UseSession();
app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapRazorPages();
});

app.Run();
