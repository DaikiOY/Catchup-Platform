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



## 2.4. Ubiquitous Language

A continuación, se presentan los términos clave utilizados en el dominio de negocio de **NutriPlan**, con el objetivo de unificar el lenguaje entre el equipo de desarrollo, los usuarios y los profesionales involucrados.

- **User (usuario general):** Persona que utiliza la aplicación con el objetivo de mejorar su alimentación mediante planes personalizados y seguimiento de hábitos.

- **Nutritionist (nutricionista):** Profesional de la salud que diseña, adapta y supervisa los planes alimenticios de los usuarios a través de la plataforma.

- **Meal plan (plan nutricional):** Conjunto de recomendaciones alimenticias diarias personalizadas según las metas, preferencias y estado de salud del usuario.

- **Progress tracking (seguimiento de progreso):** Funcionalidad que permite al usuario y al nutricionista visualizar avances relacionados al peso, hábitos y cumplimiento del plan.

- **Reminder (recordatorio):** Notificaciones automáticas que motivan al usuario a mantener la constancia en sus comidas, hidratación o consultas.

- **Healthy recipes (recetas saludables):** Preparaciones sugeridas por la app, sencillas y alineadas con el objetivo nutricional del usuario.

- **Food log (historial alimenticio):** Registro diario de alimentos consumidos por el usuario, utilizado para evaluación y ajustes del plan.

- **Professional dashboard (panel del profesional):** Interfaz exclusiva para nutricionistas, donde gestionan usuarios, visualizan métricas y dan seguimiento a planes.

- **Initial assessment (evaluación inicial):** Formulario al inicio del uso de la app donde el usuario detalla su estilo de vida, hábitos y metas.

- **Nutritional goal (objetivo nutricional):** Meta definida por el usuario, como perder peso, ganar masa muscular o mantener una dieta equilibrada.

- **Feedback (comentario):** Opiniones o sugerencias que el usuario deja en la plataforma sobre su experiencia, planes o funcionalidades.

- **Onboarding (proceso de incorporación):** Etapas iniciales para guiar al nuevo usuario en el uso de NutriPlan, como crear su perfil y recibir su primer plan.

- **Metrics (métricas):** Datos cuantificables como peso, IMC, calorías diarias y nivel de adherencia al plan, que se usan para evaluar el progreso del usuario.

- **Customization (personalización):** Adaptación del contenido de la app a las necesidades individuales de cada usuario.


