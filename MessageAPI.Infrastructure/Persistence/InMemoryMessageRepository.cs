// ===============================================
// MessageAPI.Infrastructure/Persistence/InMemoryMessageRepository.cs
// Patrón: Repository Implementation
// Implementa el almacenamiento en memoria
// ===============================================

using MessageAPI.Domain.Entities;
using MessageAPI.Domain.Interfaces;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace MessageAPI.Infrastructure.Persistence
{
    /// <summary>
    /// Implementación en memoria del repositorio de mensajes
    /// Implementa el patrón Repository
    /// Utiliza ConcurrentBag para thread-safety
    /// </summary>
    public class InMemoryMessageRepository : IMessageRepository
    {
        private readonly ConcurrentBag<UserMessage> _messages = new();

        public Task SaveMessageAsync(UserMessage message)
        {
            _messages.Add(message);
            return Task.CompletedTask;
        }
    }
}