using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using rincon.implementation;
using rincon.Models;
using rincon.Services;
using rincon.Views.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Defaultconnection");



// Add services to the container.
builder.Services.AddDbContext<DBContex>(Options => Options.UseNpgsql(connectionString));
builder.Services.AddScoped<IUsuarioservice, UserService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may to change this four production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

//app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    
app.Run();
