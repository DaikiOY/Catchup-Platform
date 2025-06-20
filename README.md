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
| **Comunica oralmente con efectividad a diferentes rangos de audiencia** | **Daiki Oscar Oshiro Yamashita**  
**TB1**: Participé activamente en reuniones remotas que realizamos en varias ocasiones para coordinar avances e informar el progreso del trabajo.  
**TP1**: Comunico con claridad el análisis del bounded context del sistema de asesorías, distinguiendo los dominios funcionales del cliente y del asesor. Esta comunicación permitió al equipo alinear criterios y establecer límites precisos para el desarrollo desde las primeras fases del proyecto.  
**TB2**: Participé activamente en sesiones remotas donde discutimos el diseño técnico del backend, enfoques de implementación y distribución de endpoints relacionados con sesiones y agendas.  
**Mathias Javier Murillo**  
**TB1**: Durante esta primera entrega, nos comunicamos eficazmente mediante llamadas grupales y mensajes de texto, lo que permitió una buena coordinación.  
**TP1**: Durante esta primera entrega, logramos una comunicación eficaz a través de llamadas grupales y mensajes de texto, lo que facilitó una excelente coordinación entre los miembros del equipo.  
**TB2**: Coordiné junto al equipo backend los objetivos técnicos durante reuniones grupales, explicando la lógica de integración entre frontend y backend.  
**Sergio Aguirre Castillo**  
**TB1**: La comunicación dentro del equipo fue eficaz durante esta etapa inicial. Utilizamos videoconferencias y mensajería para resolver problemas y mantenernos alineados.  
**TP1**: La comunicación dentro del equipo fue eficaz durante esta etapa de la TP1. Utilizamos videoconferencias y mensajería para resolver problemas y mantenernos alineados.  
**TB2**: Durante las reuniones técnicas propuse y discutí la implementación de endpoints del buscador y valoraciones, garantizando su alineación con los requerimientos del sistema.  
**Russell Stephen Romero Qwistgaard**  
**TB1**: En la primera entrega destaqué por comunicarme abiertamente con mis compañeros al momento de repartirnos las tareas y más importante, buscar ayuda cuando se complicaba partes del trabajo para poder evitar retrasos.  
**TP1**: En la primera entrega, me destaqué por mantener una comunicación abierta con mis compañeros al repartir las tareas y, lo más importante, por buscar ayuda cuando algunas partes del trabajo se complicaban. Esto me permitió evitar retrasos y asegurar que el proyecto avanzara sin contratiempos.  
**TB2**: Intercambié ideas con mis compañeros para estructurar los controladores y servicios del backend, en especial para el módulo de notificaciones y perfiles. | **Daiki Oscar Oshiro Yamashita**  
**TB1**: La comunicación fluida permitió el cumplimiento de los objetivos establecidos en esta primera etapa.  
**TP1**: La capacidad de comunicar con claridad el análisis del bounded context fue clave para asegurar una comprensión compartida dentro del equipo, lo que permitió una planificación más eficiente, la asignación adecuada de responsabilidades y una base sólida para el desarrollo coherente del sistema.  
**TB2**: La comunicación oral fue clave para consensuar estructuras, dividir tareas equitativamente y resolver dudas técnicas en tiempo real.  
**Mathias Javier Murillo**  
**TB1**: Gracias a las reuniones constantes y el seguimiento por mensajería, logramos completar la entrega de manera efectiva.  
**TP1**: Gracias a las reuniones constantes y al seguimiento a través de mensajería, logramos completar la entrega de manera efectiva y dentro de los plazos establecidos.  
**TB2**: Contribuí a mantener una comunicación clara y efectiva que permitió sincronizar avances y evitar retrabajos.  
**Sergio Aguirre Castillo**  
**TB1**: Las reuniones continuas facilitaron un buen trabajo en equipo y el logro de los objetivos planteados.  
**TP1**: Las reuniones continuas facilitaron un buen trabajo en equipo y el logro de los objetivos planteados durante la TP1.  
**TB2**: Las interacciones verbales facilitaron la toma de decisiones acertadas sobre los desarrollos asignados y mantuvieron la cohesión del equipo.  
**Russell Stephen Romero Qwistgaard**  
**TB1**: Las reuniones frecuentes y el seguimiento directo de las actividades realizadas dentro y fuera del horario de clase ayudó a que podamos completar este entregable eficientemente.  
**TP1**: Las reuniones frecuentes y el seguimiento directo de las actividades, tanto dentro como fuera del horario de clase, nos permitieron completar este entregable de manera eficiente y a tiempo.  
**TB2**: El diálogo continuo fortaleció el trabajo colaborativo y redujo los errores al momento de implementar funcionalidades. |

| **Criterio específico** | **Acciones realizadas** | **Conclusiones** |
|-------------------------|--------------------------|------------------|
| **Comunica por escrito con efectividad a diferentes rangos de audiencia** | **Daiki Oscar Oshiro Yamashita**  
**TB1**: Contribuí con el desarrollo de los capítulos 2 y 3 del informe.  
**TP1**: Contribuí con la redacción y mejora del informe, incluyendo la elaboración del bounded context del subdominio session, lo cual permitió delimitar claramente sus responsabilidades dentro del sistema.  
**TB2**: Documenté los endpoints desarrollados (sesiones, agendas) usando OpenAPI y apoyé la actualización de la documentación del sistema en el repositorio.  
**Mathias Javier Murillo**  
**TB1**: Desarrollé el capítulo 1 y parte del capítulo 4, aportando contenido clave para la presentación de la startup.  
**TP1**: Desarrollé el Bounded Context del Login.  
**TB2**: Revisé y validé parte de los endpoints escritos por el equipo y redacté observaciones en las pull requests para asegurar su coherencia con el modelo del sistema.  
**Sergio Aguirre Castillo**  
**TB1**: Redacté la totalidad del capítulo 2 y gran parte del capítulo 4, en colaboración con otro miembro del grupo.  
**TP1**: Redacté el Bounded Context del Buscador de Profesionales, corregí el informe del primer entregable (TB1), y ayudé a avanzar con los demás Bounded Contexts en colaboración con otro miembro del grupo.  
**TB2**: Redacté documentación técnica para los endpoints de búsqueda y valoraciones, detallando parámetros y estructura de respuesta.  
**Russell Stephen Romero Qwistgaard**  
**TB1**: Redacté el registro y análisis de entrevista, además de los User Stories, el Product Backlog y el Landing Page, asegurándome de obtener y clasificar toda la información requerida para poder realizar la aplicación final.  
**TP1**: Pude realizar con éxito la resolución del Bounded Context de Profesionales y notificaciones.  
**TB2**: Documenté los controladores y servicios correspondientes a notificaciones y perfiles, así como sus respectivos endpoints REST. | **Daiki Oscar Oshiro Yamashita**  
**TB1**: La participación en la redacción permitió un avance significativo en los capítulos asignados.  
**TP1**: Mi participación en la redacción contribuyó de manera significativa al progreso de los capítulos asignados, adaptando el contenido según los requisitos del proyecto, lo que incluyó el análisis del bounded context de session y la mejora en la estructura y redacción del informe.  
**TB2**: Mi capacidad de redacción técnica fue clave para dejar trazabilidad clara y comprensible del trabajo implementado.  
**Mathias Javier Murillo**  
**TB1**: Pude describir con claridad la propuesta de la startup, además de diseñar la interfaz inicial mediante wireframes y mockups.  
**TP1**: Pude describir con claridad la propuesta del Bounded Context con éxito.  
**TB2**: Las intervenciones escritas ayudaron a mantener la calidad del código y la organización del repositorio de backend.  
**Sergio Aguirre Castillo**  
**TB1**: Logré cerrar satisfactoriamente los capítulos asignados, demostrando capacidad de redacción técnica y estructurada.  
**TP1**: Logré cerrar satisfactoriamente los capítulos asignados durante la TP1, demostrando capacidad de redacción técnica y estructurada.  
**TB2**: La claridad en la escritura permitió que otros miembros entendieran fácilmente las funcionalidades desarrolladas.  
**Russell Stephen Romero Qwistgaard**  
**TB1**: Cerré cada parte trabajada con detalle y orden, permitiendo su fácil comprensión y mejorando su uso futuro para la aplicación.  
**TP1**: Cerré cada parte trabajada con detalle y orden, permitiéndome su fácil comprensión y mejorando su uso futuro para la aplicación.  
**TB2**: Contribuí con documentación precisa, facilitando la revisión del código y futuras implementaciones. |




