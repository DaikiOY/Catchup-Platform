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

## Installation and Usage

## Segmento 1: Usuarios Generales

| **Tarea**                                | **Frecuencia**    | **Importancia**   |
|------------------------------------------|-------------------|-------------------|
| Ingresar alimentos y hacer seguimiento de calorías | Diaria            | Alta              |
| Seguir plan nutricional personalizado     | Diaria            | Alta              |
| Consultar recetas rápidas y fáciles      | Semanal           | Media             |
| Realizar ajustes a la dieta (como cambiar recetas o ingredientes) | Semanal           | Media             |
| Consultar el progreso del peso o salud   | Semanal           | Alta              |
| Recibir recordatorios de comidas o ejercicios | Diario            | Alta              |
| Acceder a recomendaciones sobre hábitos saludables | Semanal           | Baja              |

---

## Segmento 2: Nutricionistas

| **Tarea**                                | **Frecuencia**    | **Importancia**   |
|------------------------------------------|-------------------|-------------------|
| Crear y personalizar planes nutricionales para pacientes | Diario            | Alta              |
| Realizar seguimiento del progreso de los pacientes | Semanal           | Alta              |
| Proveer consultas y asesoramiento a pacientes | Semanal           | Alta              |
| Ajustar planes nutricionales basados en el progreso del paciente | Semanal           | Alta              |
| Gestionar el historial de pacientes       | Semanal           | Alta              |
| Acceder a recursos educativos sobre nutrición | Mensual           | Media             |
| Mantener comunicación con los pacientes (a través de la app o reuniones) | Semanal           | Alta              |





