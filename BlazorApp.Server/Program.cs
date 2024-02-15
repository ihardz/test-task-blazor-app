using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorApp.BusinessLogic.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using BlazorApp.Server.Services.Abstraction;
using BlazorApp.Server.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

#region Add app-specific Service

var connectionStringName = "BlazorSales";
var connectionString = builder.Configuration.GetConnectionString("BlazorSales");
if (string.IsNullOrWhiteSpace(connectionString)) 
{
    throw new InvalidOperationException($"Connection string \"{connectionStringName}\" not found.");
}

builder.Services
    .AddBusinessLogic(connectionString)
    .AddSingleton<IUriResolver, UriResolver>();

#endregion

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
