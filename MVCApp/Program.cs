using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MVCApp.Filter;
using MVCApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<MyActionFilter1>();
    options.Filters.Add<MyActionFilter2>();
});
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<KcgContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("KcgDatabase")));
// 添加 Identity 服務
builder.Services.AddDefaultIdentity<IdentityUser>(options => { options.SignIn.RequireConfirmedAccount = true; // 可選：啟用帳戶確認
                        }) .AddEntityFrameworkStores<KcgContext>(); // 添加 Razor Pages 支持（這是 Identity UI 的必要部分）
builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
