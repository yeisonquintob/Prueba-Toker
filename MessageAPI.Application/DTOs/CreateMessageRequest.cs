// ===============================================
// MessageAPI.Application/DTOs/CreateMessageRequest.cs
// Patrón: Data Transfer Object (DTO)
// Implementa la validación de datos de entrada
// ===============================================

using System.ComponentModel.DataAnnotations;

namespace MessageAPI.Application.DTOs
{
    /// <summary>
    /// DTO para la creación de mensajes
    /// Implementa el patrón DTO para transferir datos entre capas
    /// Incluye validaciones mediante Data Annotations
    /// </summary>
    public class CreateMessageRequest
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "El nombre debe tener entre 1 y 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El número de teléfono es requerido")]
        [Phone(ErrorMessage = "El formato del número de teléfono no es válido")]
        public string PhoneNumber { get; set; }
    }
}