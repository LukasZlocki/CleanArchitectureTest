using ArchitectureTestBlazor.WebUI.Server.Components;
using ArchitectureTestBlazor.Application;
using ArchitectureTestBlazor.Infrastructure;
using ArchitectureTestBlazor.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using ArchitectureTestBlazor.Infrastructure.Extensions;
using ArchitectureTestBlazor.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

var scope = app.Services.CreateScope();

var seeder = scope.ServiceProvider.GetRequiredService<ShopSeeder>();
await seeder.Seed();

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

app.MapRazorComponents<App>();

app.Run();
