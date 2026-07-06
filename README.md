## Drivers de Negocio - FinTeka

| Driver de Negocio | Descripción |
|:---:|:---|
| Transparencia en precios y experiencia | Proporcionar información clara y verificable sobre costos, trayectoria y calificaciones de los profesionales, reduciendo la incertidumbre del usuario al momento de seleccionar un asesor. |
| Seguridad en transacciones | Implementar un sistema de pagos integrado con monedero digital que garantice la protección de los fondos y la confianza en las transacciones entre usuarios y profesionales. |
| Eficiencia operativa | Optimizar el flujo completo desde la búsqueda del profesional hasta la postulación y seguimiento de la sesión, reduciendo los tiempos de espera y mejorando la experiencia del usuario. |
| Crecimiento escalable | Permitir que la plataforma crezca en usuarios y funcionalidades sin perder rendimiento. |
| Fidelizar a los usuarios | Incentivar el uso continuo de la plataforma mediante suscripciones y una experiencia de servicio confiable y eficiente. |
| Optimizar la gestión de reservas | Permitir que los usuarios y profesionales administren horarios y sesiones de forma organizada, evitando conflictos en las reservas. |
| Facilitar la conexión entre usuarios y profesionales | Permitir que los usuarios encuentren, reserven y gestionen servicios profesionales desde una única plataforma de manera rápida y sencilla. |

---

## Atributos de Calidad y Tácticas - FinTeka

| Atributo | Escenario | Origen | Artefacto | Respuesta | Táctica |
|:---|:---|:---|:---|:---|:---|
| Seguridad | Un usuario intenta pagar una sesión con saldo insuficiente en su monedero. | Monedero con saldo insuficiente | Payments Service | El sistema valida el saldo antes de procesar el pago y rechaza la transacción en menos de 100 ms, mostrando un mensaje de "Saldo insuficiente". | Validación de entrada |
| Seguridad | Un usuario intenta iniciar sesión con una contraseña incorrecta. | Usuario | Servicio de Autenticación (Auth) | El sistema rechaza el acceso y muestra un mensaje indicando que las credenciales son incorrectas. | Autenticación y autorización |
| Rendimiento | Un usuario consulta el saldo de su monedero. | Usuario | Servicio de Pagos | El sistema muestra el saldo en menos de 2 segundos. | Optimización de consultas para reducir el tiempo de respuesta. |
| Usabilidad | Un usuario nuevo quiere registrarse en la plataforma. | Usuario sin cuenta | Auth Service | El sistema muestra un formulario de registro claro con validación en tiempo real y envía un correo de confirmación en menos de 2 segundos. | Feedback inmediato |
| Mantenibilidad | Se necesita agregar un nuevo tipo de notificación para promociones. | Requerimiento del negocio | Notifications Service | El sistema permite agregar un nuevo tipo de notificación modificando solo el enum NotificationType, sin afectar el código existente, en menos de 30 minutos de desarrollo. | Apertura/cierre (Open/Closed) |
| Escalabilidad | Aumenta la cantidad de usuarios realizando reservas al mismo tiempo. | Incremento de usuarios | Servicio de Reservas | El sistema continúa atendiendo las solicitudes sin afectar significativamente el tiempo de respuesta. | Escalado independiente del microservicio de reservas según la demanda. |
| Modificabilidad | Se necesita agregar un nuevo campo al perfil de usuario. | Desarrollador | Servicio de Perfiles | El nuevo campo puede incorporarse sin afectar el funcionamiento de los demás servicios. | Separación de responsabilidades mediante clases independientes. |

