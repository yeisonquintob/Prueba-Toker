// ===============================================
// MessageAPI.API/Controllers/MessagesController.cs
// Patrón: MVC Controller + Mediator
// Implementa el endpoint REST
// ===============================================

using MediatR;
using MessageAPI.Application.Commands;
using MessageAPI.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MessageAPI.API.Controllers
{
    /// <summary>
    /// Controlador REST para el manejo de mensajes
    /// Implementa el patrón MVC Controller y utiliza el Mediator Pattern
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MessagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Endpoint para crear nuevos mensajes
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateMessageRequest request)
        {
            var command = new CreateMessageCommand
            {
                Name = request.Name,
                PhoneNumber = request.PhoneNumber
            };

            var result = await _mediator.Send(command);
            return Ok(new { success = result, message = "Mensaje procesado correctamente" });
        }
    }
}