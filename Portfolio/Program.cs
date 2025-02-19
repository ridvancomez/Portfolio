using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.DependencyResolves;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation();

builder.Services.AddHttpClient();

builder.Services.AddBusinessServices();



builder.Services.AddMvc();
builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x =>
    {
        x.LoginPath = "/Panel/Login/login";
    });

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Panel/Login/login";
    options.LogoutPath = "/AdminLogin/Logout";
    options.AccessDeniedPath = "/ErrorPage/Index";
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = System.TimeSpan.FromMinutes(100);
    options.Cookie = new Microsoft.AspNetCore.Http.CookieBuilder
    {
        HttpOnly = true,
        Name = ".CoreProje.Security.Cookie",
        SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict
    };
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "common",
    pattern: "Common/{controller=Auth}/{action=Login}/{id?}");

app.Run();