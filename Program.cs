using benchTime.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var Configuration = builder.Configuration;

// Use SQLite
builder.Services.AddDbContext<DataContext>(
  options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

// // Use MySQL
// builder.Services.AddDbContext<DataContext>(
//   options => options.UseMySql(Configuration.GetConnectionString("MySql"), new MySqlServerVersion(new Version(8,2,0))));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
