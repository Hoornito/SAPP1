using SistemaLogisticaAPI.Business;
using SistemaLogisticaAPI.Contracts.Repository;
using SistemaLogisticaAPI.Contracts.Services;
using SistemaLogisticaAPI.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Services Injection
builder.Services.AddScoped<ILogisticsService, LogisticsService>();
builder.Services.AddScoped<IEstablecimientoService, EstablecimientoService>();

//Repositories Injection
builder.Services.AddScoped<IOperacionRepository, OperacionRepository>();
builder.Services.AddScoped<IEstablecimientoRepository, EstablecimientoRepository>();
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();


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
