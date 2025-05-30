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

  <tr>
    <td rowspan="2">HU01</td>
    <td rowspan="2">Registrar un profesional</td>
    <td>TS101</td>
    <td>Formulario de registro</td>
    <td>Diseñar e implementar el formulario de registro para consultores.</td>
    <td>3</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS104</td>
    <td>Validación de datos</td>
    <td>Agregar validaciones de campos (correo, contraseña, etc.).</td>
    <td>2</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>

  <tr>
    <td rowspan="2">HU02</td>
    <td rowspan="2">Registrar un cliente</td>
    <td>TS102</td>
    <td>Formulario de cliente</td>
    <td>Diseñar el formulario para registrar nuevos clientes.</td>
    <td>3</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS105</td>
    <td>Confirmación de registro</td>
    <td>Mostrar mensaje de confirmación tras registro exitoso.</td>
    <td>1</td>
    <td>Javier Murillo Mathias</td>
    <td>U202022211</td>
    <td>Done</td>
  </tr>

  <tr>
    <td rowspan="2">HU03</td>
    <td rowspan="2">Buscar profesionales disponibles</td>
    <td>TS201</td>
    <td>Filtros de búsqueda</td>
    <td>Filtrar consultores por disponibilidad, especialidad y calificación.</td>
    <td>5</td>
    <td>Aguirre Castillo Sergio Cesar</td>
    <td>U202310425</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS204</td>
    <td>Resultados dinámicos</td>
    <td>Actualizar la lista de resultados en tiempo real.</td>
    <td>3</td>
    <td>Aguirre Castillo Sergio Cesar</td>
    <td>U202310425</td>
    <td>Done</td>
  </tr>

  <tr>
    <td rowspan="2">HU04</td>
    <td rowspan="2">Recibir notificaciones</td>
    <td>TS202</td>
    <td>Enviar notificaciones</td>
    <td>Notificar a clientes sobre disponibilidad de consultores.</td>
    <td>4</td>
    <td>Romero Qwistgaard Russel Stephen</td>
    <td>U202211043</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS205</td>
    <td>Configuración de notificaciones</td>
    <td>Permitir al usuario activar/desactivar notificaciones.</td>
    <td>2</td>
    <td>Romero Qwistgaard Russel Stephen</td>
    <td>U202211043</td>
    <td>Done</td>
  </tr>

  <tr>
    <td rowspan="3">HU10</td>
    <td rowspan="3">Crear y gestionar servicios</td>
    <td>TS401</td>
    <td>Agenda de disponibilidad</td>
    <td>Configurar y actualizar la disponibilidad del consultor.</td>
    <td>6</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS402</td>
    <td>Agendamiento de sesiones</td>
    <td>Permitir a los clientes reservar sesiones con consultores.</td>
    <td>5</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>TS403</td>
    <td>Confirmación de sesiones</td>
    <td>Habilitar que el consultor acepte o rechace sesiones programadas.</td>
    <td>4</td>
    <td>Oshiro Yamashita Daiki Oscar</td>
    <td>U20201F846</td>
    <td>Done</td>
  </tr>
</table>



