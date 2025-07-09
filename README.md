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


<table border="1" width="100%" style="text-align:center; border-collapse: collapse;">
  <tr style="background-color: #f0f0f0;">
    <th colspan="13">Sprint Backlog - Sprint 4</th>
  </tr>
  <tr>
    <th colspan="3">User Story</th>
    <th colspan="10">Work-Item / Task</th>
  </tr>
  <tr style="background-color: #e8e8e8;">
    <td>Id</td>
    <td colspan="2">Title</td>
    <td>Id</td>
    <td colspan="2">Title</td>
    <td colspan="3">Description</td>
    <td>Estimation (hrs)</td>
    <td colspan="2">Assigned To</td>
    <td>Status</td>
  </tr>
  <tr>
    <td>US08</td>
    <td colspan="2">Actualizar perfil de usuario</td>
    <td>T01</td>
    <td colspan="2">Ver, editar y eliminar perfil</td>
    <td colspan="3">Yo como usuario quiero poder actualizar mi perfil, para mantener mi información actualizada</td>
    <td>3</td>
    <td colspan="2">Gonzalo Carhuancote Domínguez</td>
    <td>Done</td>
  </tr>
  <tr>
    <td>US26</td>
    <td colspan="2">Integrar Frontend con Backend</td>
    <td>T01</td>
    <td colspan="2">Desplegar Backend</td>
    <td colspan="3">Yo, como desarrollador, quiero desplegar el Backend para que la aplicación web pueda manipular datos</td>
    <td>3</td>
    <td colspan="2">Salvador Chamorro Acero</td>
    <td>Done</td>
  </tr>
  <tr>
    <td></td>
    <td colspan="2"></td>
    <td>T02</td>
    <td colspan="2">Actualizar Frontend</td>
    <td colspan="3">Yo, como desarrollador, quiero conectar el Frontend a los endpoints del Backend desplegado</td>
    <td>3</td>
    <td colspan="2">Sergio Aguirre Castillo</td>
    <td>Done</td>
  </tr>
  <tr>
    <td></td>
    <td colspan="2"></td>
    <td>T03</td>
    <td colspan="2">Desplegar Frontend</td>
    <td colspan="3">Yo, como desarrollador, quiero desplegar el Frontend para que la aplicación sea accesible</td>
    <td>3</td>
    <td colspan="2">Gonzalo Carhuancote Domínguez</td>
    <td>Done</td>
  </tr>
</table>


