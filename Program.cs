using benchTime.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// var Configuration = builder.Configuration;



builder.Services.AddDbContext<DataContext>(
  options => options.UseSqlite($"Data Source=Data/data.db"));
//   options => options.UseInMemoryDatabase("BenchTime"));
// builder.Services.AddIdentity<User, IdentityRole>()
// .AddEntityFrameworkStores<DataContext>()
// .AddDefaultTokenProviders();

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
