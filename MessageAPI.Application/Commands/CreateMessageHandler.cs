// ===============================================
// MessageAPI.Application/Commands/CreateMessageHandler.cs
// Patrón: CQRS - Command Handler + Mediator
// Maneja la lógica de negocio para la creación de mensajes
// ===============================================

using MediatR;
using MessageAPI.Domain.Entities;
using MessageAPI.Domain.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace MessageAPI.Application.Commands
{
    /// <summary>
    /// Manejador del comando de creación de mensajes
    /// Implementa el patrón CQRS para separar la escritura de la lectura
    /// Utiliza el Mediator Pattern a través de MediatR
    /// </summary>
    public class CreateMessageHandler : IRequestHandler<CreateMessageCommand, bool>
    {
        private readonly IMessageRepository _repository;
        private readonly IMessageService _messageService;

        public CreateMessageHandler(IMessageRepository repository, IMessageService messageService)
        {
            _repository = repository;
            _messageService = messageService;
        }

        public async Task<bool> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            // Crear entidad de dominio
            var message = new UserMessage(request.Name, request.PhoneNumber);
            
            // Persistir el mensaje
            await _repository.SaveMessageAsync(message);
            
            // Enviar mensaje de bienvenida
            await _messageService.SendWelcomeMessageAsync(message.Name, message.PhoneNumber);
            
            return true;
        }
    }
}