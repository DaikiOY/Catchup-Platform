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


<table border="1" width="100%" style="border-collapse: collapse; text-align: center;">
  <tr style="background-color: #f0f0f0;">
    <th colspan="13">Sprint Backlog - Sprint 4</th>
  </tr>
  <tr style="background-color: #e0e0e0;">
    <th colspan="3">User Story</th>
    <th colspan="10">Work-Item / Task</th>
  </tr>
  <tr style="background-color: #e8e8e8;">
    <th>Id</th>
    <th colspan="2">Título</th>
    <th>Id</th>
    <th colspan="2">Título del Task</th>
    <th colspan="3">Descripción</th>
    <th>Estimación (hrs)</th>
    <th colspan="2">Asignado a</th>
    <th>Estado</th>
  </tr>

  <tr>
    <td>US08</td>
    <td colspan="2">Actualizar perfil de usuario</td>
    <td>T01</td>
    <td colspan="2">Ver, editar y eliminar perfil</td>
    <td colspan="3">Como usuario, quiero actualizar mi perfil para mantener mi información personal al día.</td>
    <td>3</td>
    <td colspan="2">Gonzalo Carhuancote</td>
    <td>Done</td>
  </tr>

  <tr>
    <td>US26</td>
    <td colspan="2">Integrar Frontend con Backend</td>
    <td>T01</td>
    <td colspan="2">Desplegar backend en Azure</td>
    <td colspan="3">Como desarrollador, quiero desplegar el backend en Azure para que sea accesible en producción.</td>
    <td>3</td>
    <td colspan="2">Salvador Chamorro</td>
    <td>Done</td>
  </tr>

  <tr>
    <td></td>
    <td colspan="2"></td>
    <td>T02</td>
    <td colspan="2">Actualizar endpoints del backend</td>
    <td colspan="3">Como desarrollador, quiero actualizar y corregir los endpoints para mejorar la integridad y funcionalidad.</td>
    <td>4</td>
    <td colspan="2">Russell Romero</td>
    <td>Done</td>
  </tr>

  <tr>
    <td></td>
    <td colspan="2"></td>
    <td>T03</td>
    <td colspan="2">Probar conexión Frontend - Backend</td>
    <td colspan="3">Validar desde el frontend que los endpoints desplegados funcionen correctamente.</td>
    <td>2</td>
    <td colspan="2">Daiki Oshiro</td>
    <td>Done</td>
  </tr>

  <tr>
    <td></td>
    <td colspan="2"></td>
    <td>T04</td>
    <td colspan="2">Actualizar Frontend</td>
    <td colspan="3">Modificar vistas del frontend para que consuman los datos del backend desplegado.</td>
    <td>3</td>
    <td colspan="2">Sergio Aguirre</td>
    <td>Done</td>
  </tr>

  <tr>
    <td></td>
    <td colspan="2"></td>
    <td>T05</td>
    <td colspan="2">Desplegar frontend</td>
    <td colspan="3">Publicar el frontend en Vercel para que sea accesible a los usuarios finales.</td>
    <td>2</td>
    <td colspan="2">Gonzalo Carhuancote</td>
    <td>Done</td>
  </tr>

  <tr>
    <td>US32</td>
    <td colspan="2">Actualizar landing page</td>
    <td>T06</td>
    <td colspan="2">Editar información del equipo y proyecto</td>
    <td colspan="3">Actualizar la sección del equipo y enlaces del sistema en la landing page.</td>
    <td>2</td>
    <td colspan="2">Javier Kenyi Mendoza</td>
    <td>Done</td>
  </tr>

  <tr>
    <td>US40</td>
    <td colspan="2">Mejorar experiencia visual</td>
    <td>T07</td>
    <td colspan="2">Ajustes de diseño y navegación</td>
    <td colspan="3">Aplicar mejoras de diseño para una experiencia más intuitiva y fluida.</td>
    <td>3</td>
    <td colspan="2">Salvador Chamorro</td>
    <td>Done</td>
  </tr>

</table>



