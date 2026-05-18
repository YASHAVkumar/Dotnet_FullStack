using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using mvc_project.EMS.Infrastructure.Data;
using mvc_project.EMS.Application.Interfaces;
using mvc_projectEMS.Infrastructure.Repositories;
using mvc_project.EMS.Application.Services;
using mvc_project.EMS.Web.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(
    options =>
    options.UseSqlServer(
        builder.Configuration
               .GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<EmployeeService>();

builder.Services.AddScoped<IEmployeeRepository,EmployeeRepositoryEF>();
//builder.Services.AddScoped<IEmployeeRepository,EmployeeRepositoryADO>();

builder.Services
.AddAuthentication(
CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie(options =>
{
    options.LoginPath = "/Account/Login";
});

builder.Services.AddAuthorization();

 builder.Services.AddMemoryCache();

builder.Services.AddSignalR();

builder.Services.AddSession();

// builder.Services
// .AddAuthentication(options =>
// {
//     options.DefaultAuthenticateScheme =
//         JwtBearerDefaults.AuthenticationScheme;

//     options.DefaultChallengeScheme =
//         JwtBearerDefaults.AuthenticationScheme;
// })
// .AddJwtBearer(options =>
// {
//     options.TokenValidationParameters =
//         new TokenValidationParameters
//         {
//             ValidateIssuer = true,
//             ValidateAudience = true,
//             ValidateLifetime = true,
//             ValidateIssuerSigningKey = true,

//             ValidIssuer =
//                 builder.Configuration["Jwt:Issuer"],

//             ValidAudience =
//                 builder.Configuration["Jwt:Audience"],

//             IssuerSigningKey =
//                 new SymmetricSecurityKey(
//                     Encoding.UTF8.GetBytes(
//                         builder.Configuration["Jwt:Key"]))
//         };
// });


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
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
app.MapHub<NotificationHub>("/notify");
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}")
    .WithStaticAssets();


app.Run();
