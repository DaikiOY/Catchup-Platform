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

| **Criterio específico** | **Acciones realizadas** | **Conclusiones** |
|-------------------------|--------------------------|------------------|
| **Comunica oralmente con efectividad a diferentes rangos de audiencia** | **Daiki Oscar Oshiro Yamashita**<br>**TB1**: Participé activamente en reuniones remotas que realizamos en varias ocasiones para coordinar avances e informar el progreso del trabajo.<br>**TP1**: Comunico con claridad el análisis del bounded context del sistema de asesorías, distinguiendo los dominios funcionales del cliente y del asesor. Esta comunicación permitió al equipo alinear criterios y establecer límites precisos para el desarrollo desde las primeras fases del proyecto.<br>**TB2**: Coordiné con el equipo para la integración de los endpoints del subdominio sesiones. En reuniones técnicas, expuse el funcionamiento de la lógica de reserva, disponibilidad y validaciones necesarias para evitar solapamientos, logrando una implementación efectiva del backend.<br>**Mathias Javier Murillo**<br>**TB1**: Durante esta primera entrega, nos comunicamos eficazmente mediante llamadas grupales y mensajes de texto, lo que permitió una buena coordinación.<br>**TP1**: Durante esta primera entrega, logramos una comunicación eficaz a través de llamadas grupales y mensajes de texto, lo que facilitó una excelente coordinación entre los miembros del equipo.<br>**TB2**: Participé en las reuniones para establecer el diseño general de la API REST y en la organización de rutas y controladores para mantener la coherencia entre los diferentes módulos del backend.<br><br>**Sergio Aguirre Castillo**<br>**TB1**: La comunicación dentro del equipo fue eficaz durante esta etapa inicial. Utilizamos videoconferencias y mensajería para resolver problemas y mantenernos alineados.<br>**TP1**: La comunicación dentro del equipo fue eficaz durante esta etapa de la TP1. Utilizamos videoconferencias y mensajería para resolver problemas y mantenernos alineados.<br>**TB2**: Durante las sesiones grupales, expuse el comportamiento de los endpoints relacionados con calificaciones y búsqueda, y coordiné con otros compañeros para evitar conflictos en los esquemas de datos y pruebas.<br><br>**Russell Stephen Romero Qwistgaard**<br>**TB1**: En la primera entrega destaqué por comunicarme abiertamente con mis compañeros al momento de repartirnos las tareas y, más importante, buscar ayuda cuando se complicaba partes del trabajo para poder evitar retrasos.<br>**TP1**: En la primera entrega, me destaqué por mantener una comunicación abierta con mis compañeros al repartir las tareas y, lo más importante, por buscar ayuda cuando algunas partes del trabajo se complicaban. Esto me permitió evitar retrasos y asegurar que el proyecto avanzara sin contratiempos.<br>**TB2**: Coordiné con mis compañeros para definir el comportamiento de las notificaciones automáticas. Expliqué cómo debía estructurarse la lógica de envío y lectura en base a los eventos clave del sistema.<br><br>**Luis Angel Montañez Moreno**<br>**TB1**: En esta primera entrega, me aseguré de mantener una comunicación constante con el equipo a través de llamadas y mensajes, lo cual nos permitió coordinar tareas de forma eficiente y resolver dudas en el momento adecuado.<br>|
| **Comunica por escrito con efectividad a diferentes rangos de audiencia** | **Daiki Oscar Oshiro Yamashita**<br>**TB1**: Contribuí con el desarrollo de los capítulos 2 y 3 del informe.<br>**TP1**: Contribuí con la redacción y mejora del informe, incluyendo la elaboración del bounded context del subdominio session, lo cual permitió delimitar claramente sus responsabilidades dentro del sistema.<br>**TB2**: Documenté el comportamiento esperado de los endpoints relacionados con la gestión de sesiones en el Swagger y apoyé con la redacción del apartado técnico sobre validaciones y manejo de errores.<br>**Mathias Javier Murillo**<br>**TB1**: Desarrollé el capítulo 1 y parte del capítulo 4, aportando contenido clave para la presentación de la startup.<br>**TP1**: Desarrollé el Bounded Context del Login.<br>**TB2**: Redacté el resumen técnico del diseño REST del backend, explicando las rutas comunes y su estructura general, y apoyé en el registro de los commits técnicos realizados en GitHub.<br><br>**Sergio Aguirre Castillo**<br>**TB1**: Redacté la totalidad del capítulo 2 y gran parte del capítulo 4, en colaboración con otro miembro del grupo.<br>**TP1**: Redacté el Bounded Context Buscador de profesionales, corregí el informe del primer entregable (TB1), ayudé a avanzar con los demás Bounded Context en colaboración con otro miembro del grupo.<br>**TB2**: Documenté los endpoints de calificación y búsqueda, incluyendo ejemplos de uso en Swagger, y redacté la justificación técnica de cómo estos módulos contribuyen a mejorar la experiencia del usuario.<br><br>**Russell Stephen Romero Qwistgaard**<br>**TB1**: Redacté el registro y análisis de entrevista, además de los User Stories, el Product Backlog y el Landing Page, asegurándome de obtener y clasificar toda la información requerida para poder realizar la aplicación final.<br>**TP1**: Pude realizar con éxito la resolución del Bounded Context de Profesionales y notificaciones.<br>**TB2**: Redacté el diseño y comportamiento esperado del subdominio de notificaciones, detallando los campos, estructuras de respuesta y flujos de eventos desde el backend en la documentación técnica.<br><br>**Luis Angel Montañez Moreno**<br>**TB1**: Contribuí con el desarrollo del capítulo 3 y 4 del informe.<br>|

