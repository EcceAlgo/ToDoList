using Microsoft.EntityFrameworkCore;
using ToDoList.Data.Context;
using ToDoList.Data.Context.Contract;
using ToDoList.Data.Repository;
using ToDoList.Data.Repository.Contract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("BddConnection");

builder.Services.AddDbContext<IToDoListDbContext, ToDoListDbContext>
    (options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
    mySqlOptions =>
    {
        mySqlOptions.MigrationsAssembly("ToDoList.Api");
    })
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());

// Injection des dépendences
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();

builder.Services.AddControllers();

builder.Services.AddAutoMapper(AssemblyLoadEventArgs.Load("User.Business.Mapper"));
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
