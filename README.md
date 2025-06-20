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
| **Comunica oralmente con efectividad a diferentes rangos de audiencia** | 
**Daiki Oscar Oshiro Yamashita**  
**TB1**: Participé activamente en reuniones remotas que realizamos en varias ocasiones para coordinar avances e informar el progreso del trabajo.  
**TP1**: Comunico con claridad el análisis del bounded context del sistema de asesorías, distinguiendo los dominios funcionales del cliente y del asesor. Esta comunicación permitió al equipo alinear criterios y establecer límites precisos para el desarrollo desde las primeras fases del proyecto.  
**TB2**: En el desarrollo del backend participé en reuniones constantes, reportando avances sobre los endpoints implementados, como el de manejo de sesiones. Esto facilitó que todos entendieran los cambios en la arquitectura.  

**Mathias Javier Murillo**  
**TB1**: Durante esta primera entrega, nos comunicamos eficazmente mediante llamadas grupales y mensajes de texto, lo que permitió una buena coordinación.  
**TP1**: Durante esta primera entrega, logramos una comunicación eficaz a través de llamadas grupales y mensajes de texto, lo que facilitó una excelente coordinación entre los miembros del equipo.  
**TB2**: En este sprint de backend, realicé coordinación activa sobre los ajustes al front, para mantener compatibilidad con la API en desarrollo.  

**Sergio Aguirre Castillo**  
**TB1**: La comunicación dentro del equipo fue eficaz durante esta etapa inicial. Utilizamos videoconferencias y mensajería para resolver problemas y mantenernos alineados.  
**TP1**: La comunicación dentro del equipo fue eficaz durante esta etapa de la TP1. Utilizamos videoconferencias y mensajería para resolver problemas y mantenernos alineados.  
**TB2**: Durante la implementación de endpoints como el buscador de profesionales y el sistema de calificaciones, comuniqué los requisitos y lógica implementada en reuniones técnicas.  

**Russell Stephen Romero Qwistgaard**  
**TB1**: En la primera entrega destaque por comunicarme abiertamente con mis compañeros al momento de repartirnos las tareas y más importante, buscar ayuda cuando se complicaba partes del trabajo para poder evitar retrasos.  
**TP1**: En la primera entrega, me destaqué por mantener una comunicación abierta con mis compañeros al repartir las tareas y, lo más importante, por buscar ayuda cuando algunas partes del trabajo se complicaban. Esto me permitió evitar retrasos y asegurar que el proyecto avanzara sin contratiempos.  
**TB2**: Expliqué la lógica detrás de las notificaciones backend implementadas, incluyendo los eventos que las disparan. Esto mejoró la integración con el frontend.  

**Luis Angel Montañez Moreno**  
**TB1**: En esta primera entrega, me aseguré de mantener una comunicación constante con el equipo a través de llamadas y mensajes, lo cual nos permitió coordinar tareas de forma eficiente y resolver dudas en el momento adecuado. | 
**Daiki Oscar Oshiro Yamashita**  
**TB1**: La comunicación fluida permitió el cumplimiento de los objetivos establecidos en esta primera etapa.  
**TP1**: La capacidad de comunicar con claridad el análisis del bounded context fue clave para asegurar una comprensión compartida dentro del equipo, lo que permitió una planificación más eficiente, la asignación adecuada de responsabilidades y una base sólida para el desarrollo coherente del sistema.  
**TB2**: Gracias a una comunicación clara en las tareas técnicas, pude alinear los endpoints implementados con el resto del equipo.  

**Mathias Javier Murillo**  
**TB1**: Gracias a las reuniones constantes y el seguimiento por mensajería, logramos completar la entrega de manera efectiva.  
**TP1**: Gracias a las reuniones constantes y al seguimiento a través de mensajería, logramos completar la entrega de manera efectiva y dentro de los plazos establecidos.  
**TB2**: La sincronización con el equipo permitió mantener el frontend actualizado frente a los cambios de API.  

**Sergio Aguirre Castillo**  
**TB1**: Las reuniones continuas facilitaron un buen trabajo en equipo y el logro de los objetivos planteados.  
**TP1**: Las reuniones continuas facilitaron un buen trabajo en equipo y el logro de los objetivos planteados durante la TP1.  
**TB2**: La documentación y discusión técnica sobre los endpoints permitieron una integración fluida.  

**Russell Stephen Romero Qwistgaard**  
**TB1**: Las reuniones frecuentes y el seguimiento directo de las actividades realizadas dentro y fuera del horario de clase ayudó a que podamos completar este entregable eficientemente.  
**TP1**: Las reuniones frecuentes y el seguimiento directo de las actividades, tanto dentro como fuera del horario de clase, nos permitieron completar este entregable de manera eficiente y a tiempo.  
**TB2**: Las explicaciones técnicas sobre las notificaciones facilitaron su conexión con otros módulos.  

**Luis Angel Montañez Moreno**  
**TB1**: Gracias a la comunicación constante que tuvimos, pudimos coordinarnos bien y entregar el trabajo. |

| **Comunica por escrito con efectividad a diferentes rangos de audiencia** | 
**Daiki Oscar Oshiro Yamashita**  
**TB1**: Contribuí con el desarrollo de los capítulos 2 y 3 del informe.  
**TP1**: Contribuí con la redacción y mejora del informe, incluyendo la elaboración del bounded context del subdominio session, lo cual permitió delimitar claramente sus responsabilidades dentro del sistema.  
**TB2**: Documenté los endpoints creados para la gestión de sesiones en el backend, usando estándares de OpenAPI.  

**Mathias Javier Murillo**  
**TB1**: Desarrollé el capítulo 1 y parte del capítulo 4, aportando contenido clave para la presentación de la startup.  
**TP1**: Desarrollé el Bounded Context del Login.  
**TB2**: Escribí parte del README con guías para probar el backend junto a mejoras en la documentación técnica de consumo.  

**Sergio Aguirre Castillo**  
**TB1**: Redacté la totalidad del capítulo 2 y gran parte del capítulo 4, en colaboración con otro miembro del grupo.  
**TP1**: Redacté la el Bounded Context Buscador de profesionales, corregí el informe del primer entregable (TB1), ayudé a avanzar con los demás Bounded context en colaboración con otro miembro del grupo.  
**TB2**: Redacté los contratos REST para las funciones de búsqueda y calificación de profesionales, y documenté el flujo de reserva desde frontend.  

**Russell Stephen Romero Qwistgaard**  
**TB1**: Redacté el registro y análisis de entrevista, además de los User Stories, el Product Backlog y el Landing Page, asegurándome de obtener y clasificar toda la información requerida para poder realizar la aplicación final.  
**TP1**: Pude realizar con éxito la resolución del Bounded Context de Profesionales y notificaciones.  
**TB2**: Documenté el funcionamiento de las notificaciones en formato Markdown y OpenAPI, detallando los triggers y estructura JSON.  

**Luis Angel Montañez Moreno**  
**TB1**: Contribuí con el desarrollo del capítulo 3 y 4 del informe. | 
**Daiki Oscar Oshiro Yamashita**  
**TB1**: La participación en la redacción permitió un avance significativo en los capítulos asignados.  
**TP1**: Mi participación en la redacción contribuyó de manera significativa al progreso de los capítulos asignados, adaptando el contenido según los requisitos del proyecto, lo que incluyó el análisis del bounded context de session y la mejora en la estructura y redacción del informe.  
**TB2**: La documentación técnica del backend aseguró una base clara para futuros desarrolladores.  

**Mathias Javier Murillo**  
**TB1**: Pude describir con claridad la propuesta de la startup, además de diseñar la interfaz inicial mediante wireframes y mockups.  
**TP1**: Pude describir con claridad la propuesta del Bounded Context con éxito.  
**TB2**: La documentación entregada ayuda a comprender fácilmente el consumo de la API desarrollada.  

**Sergio Aguirre Castillo**  
**TB1**: Logré cerrar satisfactoriamente los capítulos asignados, demostrando capacidad de redacción técnica y estructurada.  
**TP1**: Logré cerrar satisfactoriamente los capítulos asignados durante la TP1, demostrando capacidad de redacción técnica y estructurada.  
**TB2**: La redacción de contratos REST fue clara y estructurada.  

**Russell Stephen Romero Qwistgaard**  
**TB1**: Cerré cada parte trabajada con detalle y orden, permitiendo su fácil comprensión y mejorando su uso futuro para la aplicación.  
**TP1**: Cerré cada parte trabajada con detalle y orden, permitiéndome su fácil comprensión y mejorando su uso futuro para la aplicación.  
**TB2**: La documentación sobre notificaciones permitirá una fácil extensión del sistema.  

**Luis Angel Montañez Moreno**  
**TB1**: Pude cerrar las partes trabajadas de manera satisfactoria para su fácil comprensión. |
