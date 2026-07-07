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

----------------------

### 🛠️ Escenario 5: Mantenibilidad / Modificabilidad (Modifiability)

| Fuente de estímulo | Estímulo | Artefacto | Respuesta | Medida de respuesta | Táctica |
| :--- | :--- | :--- | :--- | :--- | :--- |
| El equipo de desarrollo de software o analista de negocio | Se requiere agregar un nuevo método de pago internacional adicional a la pasarela existente. | Módulo/Componente de integración de pagos en la arquitectura | Gracias al diseño desacoplado, el desarrollador integra el nuevo proveedor sin necesidad de modificar las reglas de negocio base ni el flujo core. | La adición, prueba unitaria y despliegue del nuevo componente se realiza en menos de 3 días de desarrollo, afectando a 0 componentes existentes. | **Inversión de dependencias** (Patrón Strategy / Adapter) y **Encapsulamiento / Bajo Acoplamiento**. |

### ⚡ Escenario 2: Rendimiento / Latencia (Performance)

| Fuente de estímulo | Estímulo | Artefacto | Respuesta | Medida de respuesta | Táctica |
| :--- | :--- | :--- | :--- | :--- | :--- |
| Un cliente y un consultor profesional en una sesión activa | Inician una videollamada programada e interactúan a través de voz, video y chat en tiempo real. | Servicio de videoconferencia y flujo de datos multimedia (WebRTC) | El sistema optimiza dinámicamente el ancho de banda, prioriza el tráfico de audio/video y renderiza la interacción con la menor demora posible. | La latencia de la videollamada es inferior a 150 ms en condiciones normales de red y el chat de texto entrega los mensajes en menos de 1 segundo. | **Asignación dinámica de recursos** (WebRTC SFU/MCU peer-to-peer) y **Priorización de tráfico** (Quality of Service). |

### 🔒 Escenario 6: Seguridad / Integridad Financiera (Security)

| Fuente de estímulo | Estímulo | Artefacto | Respuesta | Medida de respuesta | Táctica |
| :--- | :--- | :--- | :--- | :--- | :--- |
| Un usuario (Cliente) con fondos desactualizados o malintencionado | Intenta reservar y pagar una sesión utilizando un monedero digital interno que no cuenta con saldo suficiente, enviando peticiones concurrentes (Race Condition) o alterando la petición. | Componente de gestión de monedero (Wallet Service) y base de datos transaccional | El sistema bloquea la transacción en el backend, rechaza la reserva, registra un log de auditoría inmutable de la operación fallida y mantiene la integridad del monedero. | El 100% de los intentos de pago con saldo insuficiente son denegados en menos de 500 ms, impidiendo la creación de saldos negativos y garantizando un error 400/422 controlado. | **Validación estricta en el servidor**, **Transacciones Atómicas (ACID)** para mitigar Race Conditions, y **Registro de auditoría (Audit Trail)**. |

