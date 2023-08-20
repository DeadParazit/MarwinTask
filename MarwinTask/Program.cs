using MarwinTask.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using MarwinTask.Repository.Repositories;
using MarwinTask.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MarwinDbContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));

builder.Services.AddScoped(typeof(ICompanyRepository), typeof(CompanyRepository));
builder.Services.AddScoped(typeof(IEmployeeRepository), typeof(EmployeeRepository));

builder.Services.AddScoped(typeof(ICompanyService), typeof(CompanyService));
builder.Services.AddScoped(typeof(IEmployeeService), typeof(EmployeeService));

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
