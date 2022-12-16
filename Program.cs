using BlazorStrap;
using eshop.Uses.SearchProductScreen;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using StatybaServer.Authentication;
using StatybaServer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddAuthenticationCore();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddSingleton<WorkerAccountService>();
builder.Services.AddDbContextFactory<PostgresContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddBlazorStrap();
builder.Services.AddTransient<eshop.Uses.PluginInterfaces.DataStore.IProductRepository, eShop.DataStore.ProductRepository>();
builder.Services.AddTransient<eshop.Uses.SearchProductScreen.ISearchProduct, SearchProduct>();
builder.Services.AddTransient<eshop.Uses.SearchProductScreen.IViewProduct, ViewProduct>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();