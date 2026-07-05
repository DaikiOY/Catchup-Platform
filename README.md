# Drivers de negocio

| Driver de negocio | Descripción |
|-------------------|-------------|
| Facilitar la conexión entre usuarios y profesionales | Permitir que los usuarios encuentren, reserven y gestionen servicios profesionales desde una única plataforma de manera rápida y sencilla. |
| Optimizar la gestión de reservas | Permitir que los usuarios y profesionales administren horarios y sesiones de forma organizada, evitando conflictos en las reservas. |
| Mejorar la experiencia del usuario | Ofrecer una plataforma fácil de usar donde los usuarios puedan administrar su perfil, reservas, pagos y valoraciones sin dificultades. |
| Incrementar la confianza en los profesionales | Permitir que los usuarios califiquen y valoren a los profesionales para ayudar a otros usuarios a tomar mejores decisiones. |
| Fidelizar a los usuarios | Incentivar el uso continuo de la plataforma mediante suscripciones y una experiencia de servicio confiable y eficiente. |

---

# Atributos de calidad y tácticas

| Atributo | Escenario | Origen | Artefacto | Respuesta | Táctica |
|----------|-----------|---------|-----------|-----------|---------|
| Seguridad | Un usuario intenta iniciar sesión con una contraseña incorrecta. | Usuario | Servicio de Autenticación (Auth) | El sistema rechaza el acceso y muestra un mensaje indicando que las credenciales son incorrectas. | Validación de credenciales antes de permitir el acceso. |
| Rendimiento | Un usuario consulta el saldo de su monedero. | Usuario | Servicio de Pagos | El sistema muestra el saldo en menos de 2 segundos. | Optimización de consultas para reducir el tiempo de respuesta. |
| Usabilidad | Un usuario registra una nueva reserva. | Usuario | Servicio de Reservas | El sistema confirma la reserva mostrando un mensaje de éxito con la información de la sesión. | Mensajes claros de confirmación y error para facilitar el uso de la plataforma. |
| Escalabilidad | Aumenta la cantidad de usuarios realizando reservas al mismo tiempo. | Incremento de usuarios | Servicio de Reservas | El sistema continúa atendiendo las solicitudes sin afectar significativamente el tiempo de respuesta. | Escalado independiente del microservicio de reservas según la demanda. |
| Modificabilidad | Se necesita agregar un nuevo campo al perfil de usuario. | Desarrollador | Servicio de Perfiles | El nuevo campo puede incorporarse sin afectar el funcionamiento de los demás servicios. | Separación de responsabilidades mediante clases independientes. |


## Drivers de Negocio - FinTeka

| N° | Driver de Negocio | Descripción |
|:---:|:---|:---|
| 1 | Centralización del mercado de asesoría | Unificar en una sola plataforma la oferta de profesionales especializados, eliminando la fragmentación actual donde los usuarios deben buscar en múltiples canales (redes sociales, recomendaciones informales, directorios dispersos). |
| 2 | Transparencia en precios y experiencia | Proporcionar información clara y verificable sobre costos, trayectoria y calificaciones de los profesionales, reduciendo la incertidumbre del usuario al momento de seleccionar un asesor. |
| 3 | Formalización de profesionales independientes | Brindar herramientas digitales a los consultores para gestionar su disponibilidad, administrar reservas, fortalecer su reputación mediante calificaciones y ampliar su alcance comercial. |
| 4 | Seguridad en transacciones | Implementar un sistema de pagos integrado con monedero digital que garantice la protección de los fondos y la confianza en las transacciones entre usuarios y profesionales. |
| 5 | Eficiencia operativa | Optimizar el flujo completo desde la búsqueda del profesional hasta la postulación y seguimiento de la sesión, reduciendo los tiempos de espera y mejorando la experiencia del usuario. |

---

## Atributos de Calidad y Tácticas - FinTeka

| Atributo | Escenario | Origen | Artefacto | Respuesta |
|:---|:---|:---|:---|:---|
| Seguridad | Un usuario intenta pagar una sesión con saldo insuficiente en su monedero. | Monedero con saldo insuficiente | Payments Service | El sistema valida el saldo antes de procesar el pago y rechaza la transacción en menos de 100 ms, mostrando un mensaje de "Saldo insuficiente". |
| Rendimiento | 500 usuarios consultan simultáneamente la lista de profesionales disponibles. | Múltiples peticiones concurrentes | Professionals Service | El sistema responde con la lista de profesionales en menos de 200 ms utilizando caché en memoria. |
| Interoperabilidad | El sistema necesita notificar a los usuarios sobre el estado de sus pagos y reservas. | Comunicación entre microservicios | Payments Service / Notifications Service | El Payments Service publica un evento al completar una transacción, y el Notifications Service lo consume para enviar la alerta correspondiente en menos de 2 segundos. |
| Usabilidad | Un usuario nuevo quiere registrarse en la plataforma. | Usuario sin cuenta | Auth Service | El sistema muestra un formulario de registro claro con validación en tiempo real y envía un correo de confirmación en menos de 2 segundos. |
| Mantenibilidad | Se necesita agregar un nuevo tipo de notificación para promociones. | Requerimiento del negocio | Notifications Service | El sistema permite agregar un nuevo tipo de notificación modificando solo el enum NotificationType, sin afectar el código existente, en menos de 30 minutos de desarrollo. |
