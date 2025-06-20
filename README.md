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
| **Comunica oralmente con efectividad a diferentes rangos de audiencia** | **Daiki Oscar Oshiro Yamashita**<br>**TB1**: Participé activamente en reuniones remotas que realizamos en varias ocasiones para coordinar avances e informar el progreso del trabajo.<br>**TP1**: Comunico con claridad el análisis del bounded context del sistema de asesorías, distinguiendo los dominios funcionales del cliente y del asesor.<br>**TB2**: En el desarrollo del backend participé en reuniones constantes, reportando avances sobre los endpoints implementados, como el de manejo de sesiones. Esto facilitó que todos entendieran los cambios en la arquitectura. <br><br>**Mathias Javier Murillo**<br>**TB1**: Durante esta primera entrega, nos comunicamos eficazmente mediante llamadas grupales y mensajes de texto.<br>**TP1**: Logramos una comunicación eficaz a través de llamadas grupales y mensajes de texto.<br>**TB2**: En este sprint de backend, realicé coordinación activa sobre los ajustes al front, para mantener compatibilidad con la API en desarrollo.<br><br>**Sergio Aguirre Castillo**<br>**TB1**: La comunicación dentro del equipo fue eficaz durante esta etapa inicial.<br>**TP1**: Utilizamos videoconferencias y mensajería para resolver problemas.<br>**TB2**: Durante la implementación de endpoints como el buscador de profesionales y el sistema de calificaciones, comuniqué los requisitos y lógica implementada en reuniones técnicas.<br><br>**Russell Stephen Romero Qwistgaard**<br>**TB1**: Destaqué por comunicarme abiertamente con mis compañeros al repartir tareas.<br>**TP1**: Mantuve una comunicación abierta y busqué ayuda cuando se complicaba el trabajo.<br>**TB2**: Expliqué la lógica detrás de las notificaciones backend implementadas, incluyendo los eventos que las disparan. Esto mejoró la integración con el frontend.<br><br>**Luis Angel Montañez Moreno**<br>**TB1**: Me aseguré de mantener una comunicación constante con el equipo. | **Daiki Oscar Oshiro Yamashita**<br>**TB1**: La comunicación fluida permitió el cumplimiento de los objetivos establecidos.<br>**TP1**: Fue clave para asegurar una planificación más eficiente y asignación adecuada.<br>**TB2**: Gracias a una comunicación clara en las tareas técnicas, pude alinear los endpoints implementados con el resto del equipo.<br><br>**Mathias Javier Murillo**<br>**TB1**: Gracias a las reuniones constantes, logramos completar la entrega.<br>**TP1**: Logramos completar la entrega dentro de los plazos establecidos.<br>**TB2**: La sincronización con el equipo permitió mantener el frontend actualizado frente a los cambios de API.<br><br>**Sergio Aguirre Castillo**<br>**TB1**: Las reuniones continuas facilitaron un buen trabajo en equipo.<br>**TP1**: Se logró el cumplimiento de objetivos.<br>**TB2**: La documentación y discusión técnica sobre los endpoints permitieron una integración fluida.<br><br>**Russell Stephen Romero Qwistgaard**<br>**TB1**: Las reuniones frecuentes permitieron completar el entregable eficientemente.<br>**TP1**: Las actividades se completaron a tiempo gracias al seguimiento.<br>**TB2**: Las explicaciones técnicas sobre las notificaciones facilitaron su conexión con otros módulos. |
| **Comunica por escrito con efectividad a diferentes rangos de audiencia** | **Daiki Oscar Oshiro Yamashita**<br>**TB1**: Contribuí con el desarrollo de los capítulos 2 y 3 del informe.<br>**TP1**: Elaboré el bounded context del subdominio session.<br>**TB2**: Documenté los endpoints creados para la gestión de sesiones en el backend, usando estándares de OpenAPI.<br><br>**Mathias Javier Murillo**<br>**TB1**: Desarrollé el capítulo 1 y parte del capítulo 4.<br>**TP1**: Redacté el Bounded Context del Login.<br>**TB2**: Escribí parte del README con guías para probar el backend junto a mejoras en la documentación técnica de consumo.<br><br>**Sergio Aguirre Castillo**<br>**TB1**: Redacté el capítulo 2 y gran parte del capítulo 4.<br>**TP1**: Redacté el bounded context del buscador de profesionales.<br>**TB2**: Redacté los contratos REST para las funciones de búsqueda y calificación de profesionales, y documenté el flujo de reserva desde frontend.<br><br>**Russell Stephen Romero Qwistgaard**<br>**TB1**: Redacté entrevistas, user stories y el landing page.<br>**TP1**: Resolví los bounded context de profesionales y notificaciones.<br>**TB2**: Documenté el funcionamiento de las notificaciones en formato Markdown y OpenAPI, detallando los triggers y estructura JSON.<br><br>**Luis Angel Montañez Moreno**<br>**TB1**: Contribuí con el desarrollo del capítulo 3 y 4 del informe. | **Daiki Oscar Oshiro Yamashita**<br>**TB1**: Hubo un avance significativo en los capítulos asignados.<br>**TP1**: Se logró delimitar claramente los dominios funcionales.<br>**TB2**: La documentación técnica del backend aseguró una base clara para futuros desarrolladores.<br><br>**Mathias Javier Murillo**<br>**TB1**: Pude describir con claridad la propuesta de la startup.<br>**TP1**: El bounded context fue claro y funcional.<br>**TB2**: La documentación entregada ayuda a comprender fácilmente el consumo de la API desarrollada.<br><br>**Sergio Aguirre Castillo**<br>**TB1**: Se demostró capacidad de redacción técnica.<br>**TP1**: Se avanzó con calidad en el informe.<br>**TB2**: La redacción de contratos REST fue clara y estructurada.<br><br>**Russell Stephen Romero Qwistgaard**<br>**TB1**: Permitió fácil comprensión del contenido técnico.<br>**TP1**: Mejoró el uso futuro del material trabajado.<br>**TB2**: La documentación sobre notificaciones permitirá una fácil extensión del sistema.<br>
