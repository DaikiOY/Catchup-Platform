# Catchup-Platform

## Description

**Catchup-Platform** is a C# application that allows users to save, update, delete, and query their favorite news sources. The project follows best development practices and uses **Clean Architecture** and the **CQRS** pattern to separate read and write operations.

## Functionality

The application provides the following features for users to interact with their favorite sources:

- **Create**: Save a new favorite source.
- **Read**: Query an existing favorite source.
- **Update**: Modify a saved favorite source.
- **Delete**: Remove a favorite source.

These operations are implemented following the **CQRS** (Command Query Responsibility Segregation) pattern, separating command (write) and query (read) operations.

## Technologies Used

- **Language**: C#
- **IDE**: Visual Studio
- **Architecture Pattern**: Clean Architecture
- **Design Pattern**: CQRS (Command Query Responsibility Segregation)
- **Version Control**: Git (GitHub repository)

## Libraries Used

- **Entity Framework Core**: For data management and persistence.
- **MediatR**: For implementing CQRS (separating commands and queries).
- **xUnit**: For unit testing.
- **FluentValidation**: For input data validation.

## Team Members

- Daiki Oscar Oshiro Yamashita
- Gabriel Alejandro Rivera Ayala
- Karito Dianeth Medina Chocce
- Yair Christofer Aru Acevedo

<table align="center" border="1" width="100%" style="text-align:center;">
  <tr align="left">
    <th>User Story</th>
    <th>Work-Item / Task</th>
    <th>Id</th>
    <th>Title</th>
    <th>Description</th>
    <th>Estimation (Hours)</th>
    <th>Assigned To</th>
    <th>Student Code</th>
    <th>Status</th>
  </tr>

  <tr align="left">
    <td rowspan="1">US03</td>
    <td>Buscar profesionales disponibles</td>
    <td>T01</td>
    <td>Búsqueda de servicios</td>
    <td>Implementar búsqueda y filtros de disponibilidad para encontrar profesionales.</td>
    <td>5</td>
    <td>Sergio Aguirre Castillo</td>
    <td>U202310425</td>
    <td>Done</td>
  </tr>

  <tr align="left">
    <td rowspan="1">US01</td>
    <td>Registrar un profesional</td>
    <td>T01</td>
    <td>Registro de profesional</td>
    <td>Formulario y lógica de backend para registro de consultores.</td>
    <td>4</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>

  <tr align="left">
    <td rowspan="3">US02</td>
    <td>Registrar un cliente</td>
    <td>T01</td>
    <td>Registro de cliente</td>
    <td>Registro de nuevos clientes con validaciones de email duplicado y datos requeridos.</td>
    <td>4</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>
  <tr align="left">
    <td></td>
    <td>T02</td>
    <td>Correcciones del sprint anterior</td>
    <td>Refactor de errores previos y ajustes de bugs reportados.</td>
    <td>3</td>
    <td>Equipo</td>
    <td>-</td>
    <td>Done</td>
  </tr>
  <tr align="left">
    <td></td>
    <td>T03</td>
    <td>Desarrollo del Backend</td>
    <td>Integración de funcionalidades clave (servicios, sesiones, perfiles).</td>
    <td>6</td>
    <td>Russell Romero Qwistgaard</td>
    <td>U202211043</td>
    <td>Done</td>
  </tr>

  <tr align="left">
    <td rowspan="1">US04</td>
    <td>Recibir notificaciones de disponibilidad</td>
    <td>T01</td>
    <td>Notificaciones de disponibilidad</td>
    <td>Envío de alertas a usuarios cuando los profesionales actualizan su disponibilidad.</td>
    <td>4</td>
    <td>Russell Romero Qwistgaard</td>
    <td>U202211043</td>
    <td>Done</td>
  </tr>

  <tr align="left">
    <td rowspan="3">US08</td>
    <td>Actualizar perfil de usuario</td>
    <td>T01</td>
    <td>Actualizar perfil</td>
    <td>Permitir a usuarios editar sus datos personales y preferencias.</td>
    <td>4</td>
    <td>Sergio Aguirre Castillo</td>
    <td>U202310425</td>
    <td>Done</td>
  </tr>
  <tr align="left">
    <td></td>
    <td>T02</td>
    <td>Hacer el Landing Page responsiva</td>
    <td>Ajustes de estilo y diseño adaptable para la página principal.</td>
    <td>3</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>
  <tr align="left">
    <td></td>
    <td>T03</td>
    <td>Agregar las secciones faltantes al Landing Page</td>
    <td>Completar contenido y estructura de la landing page con base en requerimientos iniciales.</td>
    <td>3</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>

  <tr align="left">
    <td rowspan="1">US07</td>
    <td>Calificar a un profesional</td>
    <td>T01</td>
    <td>Calificar un profesional</td>
    <td>Implementar sistema de puntuación y comentarios post-sesión.</td>
    <td>3</td>
    <td>Russell Romero Qwistgaard</td>
    <td>U202211043</td>
    <td>Done</td>
  </tr>
</table>



