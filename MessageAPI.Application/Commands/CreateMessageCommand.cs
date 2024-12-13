// ===============================================
// MessageAPI.Application/Commands/CreateMessageCommand.cs
// Patrón: CQRS - Command
// Implementa el comando para la creación de mensajes
// ===============================================

using MediatR;

namespace MessageAPI.Application.Commands
{
    /// <summary>
    /// Comando para la creación de mensajes
    /// Implementa el patrón CQRS (Command Query Responsibility Segregation)
    /// Utiliza MediatR para implementar el Mediator Pattern
    /// </summary>
   public class CreateMessageCommand : IRequest<bool>
{
    public string Name { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}
}