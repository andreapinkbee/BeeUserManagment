using BeeUserManagement.Infraestructure.Data;
using BeeUserManagement.Infraestructure.Repositories;
using BeeUserManagement.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Conexi�n a la DB
builder.Services.AddDbContext<BeeUserManagementDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Inyecci�n de repositorios
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();
