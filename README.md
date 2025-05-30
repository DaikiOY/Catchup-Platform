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

  <!-- HU01: Registrar un profesional -->
  <tr>
    <td rowspan="2">US01</td>
    <td rowspan="2">Registrar un profesional</td>
    <td>TS101</td>
    <td>Formulario de registro</td>
    <td>Implementar formulario y lógica POST para crear consultores.</td>
    <td>3</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS104</td>
    <td>Validación de datos</td>
    <td>Verificar campos requeridos y mensajes de error en tiempo real.</td>
    <td>2</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>

  <!-- HU02: Registrar un cliente -->
  <tr>
    <td rowspan="2">US02</td>
    <td rowspan="2">Registrar un cliente</td>
    <td>TS102</td>
    <td>Formulario cliente</td>
    <td>Diseñar e implementar formulario para nuevos clientes.</td>
    <td>3</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS105</td>
    <td>Confirmación de registro</td>
    <td>Mostrar mensaje al finalizar registro y redirigir a inicio.</td>
    <td>1</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>

  <!-- HU03: Buscar profesionales -->
  <tr>
    <td rowspan="2">US03</td>
    <td rowspan="2">Buscar profesionales disponibles</td>
    <td>TS201</td>
    <td>Filtros de búsqueda</td>
    <td>Permitir filtrado por especialidad, horario y tarifa.</td>
    <td>5</td>
    <td>Sergio Aguirre Castillo</td>
    <td>U202310425</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS204</td>
    <td>Resultados dinámicos</td>
    <td>Actualizar listado de resultados en tiempo real según filtros.</td>
    <td>3</td>
    <td>Sergio Aguirre Castillo</td>
    <td>U202310425</td>
    <td>Done</td>
  </tr>

  <!-- HU04: Notificaciones -->
  <tr>
    <td rowspan="2">US04</td>
    <td rowspan="2">Recibir notificaciones</td>
    <td>TS202</td>
    <td>Enviar notificaciones</td>
    <td>Enviar correo o push cuando hay disponibilidad nueva.</td>
    <td>4</td>
    <td>Russell Romero Qwistgaard</td>
    <td>U202211043</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS205</td>
    <td>Configuración de notificaciones</td>
    <td>Permitir activar/desactivar notificaciones en el perfil.</td>
    <td>2</td>
    <td>Russell Romero Qwistgaard</td>
    <td>U202211043</td>
    <td>Done</td>
  </tr>

  <!-- HU10: Gestión de servicios -->
  <tr>
    <td rowspan="3">US10</td>
    <td rowspan="3">Crear y gestionar servicios</td>
    <td>TS401</td>
    <td>Agenda de disponibilidad</td>
    <td>Implementar calendario para horarios del profesional.</td>
    <td>6</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS402</td>
    <td>Agendamiento de sesiones</td>
    <td>Permitir a clientes seleccionar fecha y hora disponible.</td>
    <td>5</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS403</td>
    <td>Confirmación de sesiones</td>
    <td>Profesional acepta o rechaza sesión agendada.</td>
    <td>4</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>
</table>



