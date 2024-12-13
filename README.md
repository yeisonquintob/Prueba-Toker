# Message API - Prueba Técnica

**Desarrollador:** Yeison D. Quinto B.  
**Cargo:** Desarrollador de Software  
**Fecha:** Diciembre 2024

## Propósito de la Prueba

Esta API fue desarrollada como parte de una prueba técnica con los siguientes objetivos:

1. Evaluar habilidades en C# y creación de APIs con .NET
2. Demostrar capacidad para:
   - Recibir datos desde solicitudes web
   - Procesar datos
   - Simular envío de mensajes

## Requerimientos Implementados

✅ Recepción de datos de usuario vía HTTP POST (nombre y número de teléfono)  
✅ Almacenamiento de datos en memoria  
✅ Simulación de envío de mensajes con logs en consola  
✅ Implementación en ASP.NET Core 8.0  
✅ Manejo de datos en formato JSON  
✅ Confirmación de recepción de datos  

## Estructura del Proyecto

```
MessageAPI/
├── MessageAPI.Domain/           # Capa de dominio
│   ├── Entities/               # Entidades de dominio
│   └── Interfaces/             # Contratos de repositorios y servicios
├── MessageAPI.Application/      # Capa de aplicación
│   ├── Commands/               # Comandos CQRS
│   └── DTOs/                   # Objetos de transferencia de datos
├── MessageAPI.Infrastructure/   # Capa de infraestructura
│   ├── Persistence/            # Implementación de repositorios
│   └── Services/               # Implementación de servicios
└── MessageAPI.API/             # Capa de presentación
    └── Controllers/            # Controladores API
```

## Requisitos Previos

- .NET SDK 8.0 o superior
- Un editor de código (Visual Studio Code, Visual Studio, etc.)

## Configuración y Ejecución

1. Clonar el repositorio:
```bash
git clone <url-repositorio>
cd MessageAPI
```

2. Restaurar dependencias:
```bash
dotnet restore
```

3. Compilar el proyecto:
```bash
dotnet build
```

4. Ejecutar la API:
```bash
cd MessageAPI.API
dotnet run
```

La API estará disponible en:
- HTTP: http://localhost:5202
- Swagger UI: http://localhost:5202/swagger

## Pruebas de la API

### Usando curl
```bash
curl -X POST http://localhost:5202/api/messages \
-H "Content-Type: application/json" \
-d '{"name":"John Doe","phoneNumber":"+1234567890"}'
```

### Usando Swagger UI
1. Navegar a http://localhost:5202/swagger
2. Seleccionar el endpoint POST /api/messages
3. Hacer clic en "Try it out"
4. Introducir los datos:
```json
{
  "name": "John Doe",
  "phoneNumber": "+1234567890"
}
```
5. Ejecutar la petición

### Ejemplos de Respuestas

Respuesta exitosa:
```json
{
  "success": true,
  "message": "Mensaje procesado correctamente"
}
```

## Arquitectura y Patrones Implementados

- Clean Architecture
- CQRS (Command Query Responsibility Segregation)
- Repository Pattern
- Mediator Pattern (usando MediatR)
- DDD (Domain-Driven Design)

## Tecnologías Utilizadas

- ASP.NET Core 8.0
- MediatR para CQRS
- Swagger para documentación
- System.ComponentModel.DataAnnotations para validaciones

## Notas de Implementación

- Se utiliza almacenamiento en memoria para simplificar la prueba
- Los mensajes de confirmación se muestran en la consola
- Se implementó una arquitectura limpia para mantener el código organizado y mantenible
- Se incluyeron validaciones básicas de datos

# Prueba-Toker
