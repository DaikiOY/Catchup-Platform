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

<table align="center" border="1" width="95%" style="text-align:center">
  <tr>
    <td><b>Sprint #</b></td>
    <td colspan="8"><b>Sprint 2</b></td>
  </tr>
  <tr>
    <td colspan="2"><b>User Story</b></td>
    <td colspan="7"><b>Work-Item / Task</b></td>
  </tr>
  <tr>
    <td><b>Id</b></td>
    <td><b>Title</b></td>
    <td><b>Id</b></td>
    <td><b>Title</b></td>
    <td><b>Description</b></td>
    <td><b>Estimation (Hours)</b></td>
    <td><b>Assigned To</b></td>
    <td><b>Student Code</b></td>
    <td><b>Status</b></td>
  </tr>

  <!-- US01: Registrar un profesional -->
  <tr>
    <td rowspan="1">US01</td>
    <td rowspan="1">Registrar un profesional</td>
    <td>T01</td>
    <td>Registro de profesionales</td>
    <td>Formulario y lógica para registro de consultores.</td>
    <td>4</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>

  <!-- US02: Registrar un cliente -->
  <tr>
    <td rowspan="1">US02</td>
    <td rowspan="1">Registrar un cliente</td>
    <td>T01</td>
    <td>Registro de clientes</td>
    <td>Formulario y validaciones para registrar usuarios cliente.</td>
    <td>4</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>

  <!-- US03: Buscar profesionales -->
  <tr>
    <td rowspan="1">US03</td>
    <td rowspan="1">Buscar profesionales disponibles</td>
    <td>T01</td>
    <td>Filtros de búsqueda</td>
    <td>Filtrar consultores por disponibilidad, especialidad y calificación.</td>
    <td>5</td>
    <td>Sergio Aguirre Castillo</td>
    <td>U202310425</td>
    <td>Done</td>
  </tr>

  <!-- US04: Notificaciones -->
  <tr>
    <td rowspan="1">US04</td>
    <td rowspan="1">Recibir notificaciones de disponibilidad</td>
    <td>T01</td>
    <td>Notificaciones de disponibilidad</td>
    <td>Enviar notificaciones cuando un profesional actualiza su agenda.</td>
    <td>4</td>
    <td>Russell Romero Qwistgaard</td>
    <td>U202211043</td>
    <td>Done</td>
  </tr>

  <!-- US10: Crear y gestionar servicios -->
  <tr>
    <td rowspan="3">US10</td>
    <td rowspan="3">Crear y gestionar servicios</td>
    <td>T01</td>
    <td>Agenda de disponibilidad</td>
    <td>Configurar y actualizar la disponibilidad de los consultores.</td>
    <td>6</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>T02</td>
    <td>Agendamiento de sesiones</td>
    <td>Permitir a los clientes reservar sesiones.</td>
    <td>5</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>T03</td>
    <td>Confirmación de sesiones</td>
    <td>Permitir a los consultores aceptar o rechazar sesiones.</td>
    <td>4</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>
</table>




