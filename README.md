# Drivers de negocio

| Driver de negocio | Descripción |
|-------------------|-------------|
| Facilitar la conexión entre usuarios y profesionales | Permitir que los usuarios encuentren, reserven y gestionen servicios profesionales desde una única plataforma de manera rápida y sencilla. |
| Garantizar pagos seguros | Asegurar que los pagos de sesiones y suscripciones se procesen correctamente, brindando confianza tanto a usuarios como a profesionales. |
| Mejorar la experiencia del usuario | Ofrecer una plataforma fácil de usar donde los usuarios puedan administrar su perfil, reservas, pagos y valoraciones sin dificultades. |
| Incrementar la confianza en los profesionales | Permitir que los usuarios califiquen y valoren a los profesionales para ayudar a otros usuarios a tomar mejores decisiones. |
| Automatizar la comunicación | Enviar notificaciones sobre reservas, pagos y sesiones para mantener informados a usuarios y profesionales en todo momento. |

---

# Atributos de calidad y tácticas

| Atributo | Escenario | Origen | Artefacto | Respuesta | Táctica |
|----------|-----------|---------|-----------|-----------|---------|
| Seguridad | Un usuario intenta iniciar sesión con una contraseña incorrecta. | Usuario | Servicio de Autenticación (Auth) | El sistema rechaza el acceso y muestra un mensaje indicando que las credenciales son incorrectas. | Validación de credenciales antes de permitir el acceso. |
| Rendimiento | Un usuario consulta el saldo de su monedero. | Usuario | Servicio de Pagos | El sistema muestra el saldo en menos de 2 segundos. | Optimización de consultas para reducir el tiempo de respuesta. |
| Usabilidad | Un usuario registra una nueva reserva. | Usuario | Servicio de Reservas | El sistema confirma la reserva mostrando un mensaje de éxito con la información de la sesión. | Mensajes claros de confirmación y error para facilitar el uso de la plataforma. |
| Modificabilidad | Se agrega un nuevo tipo de notificación al sistema. | Desarrollador | Servicio de Notificaciones | El nuevo tipo de notificación puede incorporarse sin afectar el funcionamiento de los demás servicios. | Separación de funcionalidades en microservicios independientes. |
| Escalabilidad | Aumenta la cantidad de usuarios realizando reservas al mismo tiempo. | Incremento de usuarios | Servicio de Reservas | El sistema continúa atendiendo las solicitudes sin afectar significativamente el tiempo de respuesta. | Escalado independiente del microservicio de reservas según la demanda. |
