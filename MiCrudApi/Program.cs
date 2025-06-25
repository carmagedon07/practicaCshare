using Microsoft.EntityFrameworkCore;
using MiCrudApi.Data;
using MiCrudApi.Service;
using MiCrudApi.Service.Impl;

var builder = WebApplication.CreateBuilder(args);

// Agregar configuración de EF Core con PostgreSQL
builder.Services.AddDbContext<AppDbContext>(option =>
    option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agregar servicios propios
builder.Services.AddScoped<IPersonaService, PersonaServiceImpl>();

// Agregar controladores
builder.Services.AddControllers();

// Agregar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers(); // Esto requiere que AddControllers() esté registrado
app.Run();
