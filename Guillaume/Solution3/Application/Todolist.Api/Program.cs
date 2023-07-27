using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Todolist.Data.Context;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
string connectionString = configuration.GetConnectionString("BddConnection");
builder.Services.AddDbContext<TodolistDbContext>(
    options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
    mySqlOptions =>
    {
        mySqlOptions.MigrationsAssembly("Todolist.Api");
    })
    .LogTo(Console.WriteLine, LogLevel.Information)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors());


builder.Services.AddControllers();
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
