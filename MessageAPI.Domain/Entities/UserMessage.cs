// ===============================================
// MessageAPI.Domain/Entities/UserMessage.cs
// Patrón: Domain-Driven Design - Entidad
// Este archivo implementa el patrón DDD para la entidad principal
// ===============================================

using System;

namespace MessageAPI.Domain.Entities
{
    /// <summary>
    /// Entidad de dominio que representa un mensaje de usuario
    /// Implementa el patrón de Entidad Rica (Rich Domain Entity) de DDD
    /// Encapsula toda la lógica de negocio relacionada con el mensaje
    /// </summary>
    public class UserMessage
    {
        // Propiedades privadas para garantizar la encapsulación
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Constructor que valida y establece el estado inicial de la entidad
        /// </summary>
        public UserMessage(string name, string phoneNumber)
        {
            // Validaciones de dominio
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre no puede estar vacío", nameof(name));
            
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("El número de teléfono no puede estar vacío", nameof(phoneNumber));

            Id = Guid.NewGuid();
            Name = name;
            PhoneNumber = phoneNumber;
            CreatedAt = DateTime.UtcNow;
        }
    }
}