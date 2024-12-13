// ===============================================
// MessageAPI.Domain/Interfaces/IMessageService.cs
// Patrón: Service Interface
// Define el contrato para servicios de dominio
// ===============================================

using System.Threading.Tasks;

namespace MessageAPI.Domain.Interfaces
{
    /// <summary>
    /// Interfaz que define el contrato para el servicio de mensajes
    /// Implementa el patrón Service Interface para operaciones de dominio
    /// </summary>
    public interface IMessageService
    {
        Task SendWelcomeMessageAsync(string name, string phoneNumber);
    }
}
