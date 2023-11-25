using Microsoft.EntityFrameworkCore;
using Bold.Data;
using Bold.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<BoldContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BoldContext") ?? throw new InvalidOperationException("Connection string 'BoldContext' not found.")));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();