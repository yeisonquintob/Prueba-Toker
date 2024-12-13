// ===============================================
// MessageAPI.API/Program.cs
// Configuración de la aplicación y Dependency Injection
// ===============================================

using MessageAPI.Application.Commands;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MessageAPI.Infrastructure.Persistence;
using MessageAPI.Infrastructure.Services;
using MessageAPI.Domain.Interfaces;
using System.Reflection;

/// <summary>
/// Configuración principal de la aplicación
/// Implementa el patrón Dependency Injection y Composition Root
/// </summary>
var builder = WebApplication.CreateBuilder(args);

// Registrar servicios en el contenedor DI
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrar MediatR para CQRS y Mediator Pattern
builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    cfg.RegisterServicesFromAssembly(typeof(CreateMessageCommand).Assembly);
});

// Registrar implementaciones (Dependency Injection)
builder.Services.AddSingleton<IMessageRepository, InMemoryMessageRepository>();
builder.Services.AddSingleton<IMessageService, ConsoleMessageService>();

var app = builder.Build();

// Configurar el pipeline de middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();