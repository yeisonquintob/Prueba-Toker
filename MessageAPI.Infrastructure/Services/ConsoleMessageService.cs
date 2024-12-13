// ===============================================
// MessageAPI.Infrastructure/Services/ConsoleMessageService.cs
// Patrón: Service Implementation
// Implementa el servicio de mensajes
// ===============================================

using MessageAPI.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace MessageAPI.Infrastructure.Services
{
    /// <summary>
    /// Implementación del servicio de mensajes que utiliza la consola
    /// Implementa el patrón Service para operaciones de dominio
    /// </summary>
    public class ConsoleMessageService : IMessageService
    {
        public Task SendWelcomeMessageAsync(string name, string phoneNumber)
        {
            Console.WriteLine($"Mensaje de bienvenida enviado a {name} al número {phoneNumber}");
            return Task.CompletedTask;
        }
    }
}