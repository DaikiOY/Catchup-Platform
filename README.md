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

| Historia de Usuario | Título del Desarrollo Frontend         | Relación con Product Backlog    | Tarea Técnica | Descripción técnica del desarrollo frontend                                                                 | Estimación (Horas) | Asignado a                   | Estado |
|---------------------|----------------------------------------|----------------------------------|---------------|-----------------------------------------------------------------------------------------------------------------------------------------------------|--------------------|------------------------------|--------|
| US01                | Registro de usuario                    | US01 – Registro de Usuario       | T101          | Crear formulario de registro con validaciones de campos, implementación visual y conexión básica.                                                  | 5                  | Gustavo Pardo                | Done   |
| US02                | Pantalla de inicio                     | US02 – Pantalla de inicio        | T108          | Diseño e implementación de pantalla de bienvenida con navegación hacia login o registro.                                                           | 3                  | Gustavo Pardo                | Done   |
| US03                | Formulario de pago                     | US03 – Gestión de suscripciones  | T109          | Crear pantalla de ingreso de datos de tarjeta, con campos validados y diseño responsive.                                                           | 5                  | Gustavo Pardo                | Done   |
| US04                | Creación de perfil                     | US04 – Crear perfil              | T103          | Formulario de datos personales y nutricionales con guardado local o simulado.                                                                      | 6                  | Jessica Comettant            | Done   |
| US05                | Selección de plan de pago              | US05 – Planes de suscripción     | T110          | Pantalla para elegir entre planes mensuales/anuales con lógica condicional y navegación.                                                           | 4                  | Daiki Oshiro                 | Done   |
| US06                | Visualización del plan nutricional     | US06 – Plan nutricional semanal  | T111          | Diseño de interfaz que muestre recomendaciones semanales en tarjetas o lista.                                                                      | 6                  | Daiki Oshiro                 | Done   |
| US07                | Pantalla de progreso                   | US07 – Seguimiento de progreso   | T112          | Implementar vista gráfica o textual que muestre avances nutricionales del usuario.                                                                 | 5                  | Daiki Oshiro                 | Done   |
| US08                | Visualización del plan diario          | US08 – Consultar plan diario     | T107          | Crear pantalla con menú del día dividido por tiempos de comida.                                                                                    | 5                  | Gustavo Pardo                | Done   |
| US09                | Visualización de recetas               | US09 – Recetario                 | T113          | Diseñar vista de recetas saludables según el plan alimenticio, con tarjetas y scroll vertical.                                                     | 6                  | Gustavo Pardo                | Done   |
| US10                | Configuración de restricciones         | US10 – Restricciones             | T106          | Desarrollar sección para seleccionar alergias o preferencias alimenticias (checkboxes o toggles).                                                  | 6                  | Gustavo Pardo                | To Do  |
| US11                | Confirmación de pago                   | US11 – Confirmar suscripción     | T114          | Crear pantalla de confirmación visual (icono, mensaje, botón) posterior al pago.                                                                   | 3                  | Leonardo Dueñas              | Done   |
