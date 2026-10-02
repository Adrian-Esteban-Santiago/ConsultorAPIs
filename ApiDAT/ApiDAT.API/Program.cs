using ApiDAT.Application.Interfaces;
using ApiDAT.Application.Services;
using ApiDAT.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Agregar Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Cadena de conexión
var connectionString = builder.Configuration
    .GetConnectionString("SqlConnection")
    ?? throw new InvalidOperationException(
        "No se encontró la cadena de conexión SqlConnection."
    );

// Inyección de dependencias
builder.Services.AddScoped<IDatosDATRepository>(
    provider => new DatosDATRepository(connectionString)
);

builder.Services.AddScoped<DatosDATService>();

// CORS para Angular
builder.Services.AddCors(options =>
{
    options.AddPolicy("AngularPolicy", policy =>
    {
        policy
            .WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
builder.Services.AddScoped<IDatosDATRepository>(
    provider => new DatosDATRepository(connectionString)
);

builder.Services.AddScoped<DatosDATService>();

builder.Services.AddScoped<IPedidoSearsRepository>(
    provider => new PedidoSearsRepository(connectionString)
);

builder.Services.AddScoped<PedidoSearsService>();

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AngularPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();