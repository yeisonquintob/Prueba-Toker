// ===============================================
// MessageAPI.Domain/Interfaces/IMessageRepository.cs
// Patrón: Repository Pattern
// Este archivo define el contrato para el acceso a datos
// ===============================================

using MessageAPI.Domain.Entities;
using System.Threading.Tasks;

namespace MessageAPI.Domain.Interfaces
{
    /// <summary>
    /// Interfaz que define el contrato para el repositorio de mensajes
    /// Implementa el patrón Repository para abstraer el acceso a datos
    /// </summary>
    public interface IMessageRepository
    {
        Task SaveMessageAsync(UserMessage message);
    }
}