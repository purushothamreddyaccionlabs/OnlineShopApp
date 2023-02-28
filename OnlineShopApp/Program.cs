using Microsoft.EntityFrameworkCore;
using OnlineShopApp.Interfaces;
using OnlineShopApp.Models;
using OnlineShopApp.ServieceLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IStores, StoresServices>();
builder.Services.AddScoped<ICategory, CategoryServices>();
builder.Services.AddScoped<IProducts, ProductServices>();

builder.Services.AddControllers();
builder.Services.AddDbContext<CommerceContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("dbconn")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
