using Microsoft.EntityFrameworkCore;
using Nutrition;
using Nutrition.Components;
using Nutrition.Models;
using Nutrition.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("NutritionContext") ??
    throw new InvalidOperationException("Connection string NutritionContext not found")));

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<UserDetailsService>();
builder.Services.AddScoped<UserProgressDataService>();

builder.Services.AddSingleton<LoggedInUserModel>();

builder.Services.AddBlazorBootstrap();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
