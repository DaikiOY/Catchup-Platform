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








# Análisis de Atributos de Calidad - Plataforma

---

## 1. Seguridad

| Elemento | Descripción |
|----------|-------------|
| **Fuente de estímulo** | Usuario final, cliente |
| **Estímulo** | Un usuario intenta pagar una sesión con saldo insuficiente en su monedero. |
| **Artefacto** | Microservicio de pagos y API Gateway. |
| **Respuesta** | El sistema valida el saldo disponible en el monedero al recibir la solicitud de pago. Si el saldo es insuficiente, la transacción es rechazada de forma inmediata y se notifica al usuario. Si el saldo es suficiente, se reserva el monto, se procesa el pago y se actualiza el saldo de forma atómica. |
| **Medida de respuesta** | El sistema deniega el 100% de los intentos de pago con saldo insuficiente, responde en menos de 1.5 segundos y garantiza que ningún cargo se realice sin la verificación previa del saldo. |

---

## 2. Rendimiento

| Elemento | Descripción |
|----------|-------------|
| **Fuente de estímulo** | Usuarios finales, clientes y profesionales |
| **Estímulo** | Inician una videollamada programada e interactúan a través de voz, video y chat en tiempo real. |
| **Artefacto** | Servicio externo de Google Meets. |
| **Respuesta** | El sistema genera automáticamente un enlace único de Google Meet al momento de agendar la sesión y lo proporciona a ambos participantes (cliente y profesional). Los usuarios hacen clic en el enlace y son redirigidos a la sala de Google Meet, donde la infraestructura de Google maneja toda la transmisión de audio, video y chat en tiempo real, garantizando la calidad de servicio. |
| **Medida de respuesta** | El enlace de Google Meet se genera y entrega en menos de 1 segundo desde la confirmación de la reserva. La latencia de la videollamada es gestionada enteramente por Google Meet (estándar <150 ms). |

---

## 3. Usabilidad

| Elemento | Descripción |
|----------|-------------|
| **Fuente de estímulo** | Usuario nuevo. |
| **Estímulo** | Un usuario nuevo quiere registrarse en la plataforma. |
| **Artefacto** | Microservicio de perfiles, formulario de registro de usuarios.|
| **Respuesta** | El sistema presenta un formulario de registro claro y sencillo (con validación en tiempo real), permite el registro mediante email/contraseña. Tras enviar los datos, los valida valida, crea la cuenta y redirige al usuario a la login inicial. |
| **Medida de respuesta** | El proceso de registro se completa en menos de 2 minutos para el 95% de los usuarios. La tasa de éxito del registro es >98% en el primer intento, y el sistema proporciona mensajes de error claros si no se concreta la acción. |

---

## 4. Mantenibilidad

| Elemento | Descripción |
|----------|-------------|
| **Fuente de estímulo** | Desarrollador / Equipo de producto. |
| **Estímulo** | Se necesita agregar un nuevo tipo de servicio de pago (ej. criptomonedas, pago contra entrega, etc.) a la plataforma. |
| **Artefacto** | Módulo de pagos (que usa patrón Strategy o Factory), API de integración con terceros y base de datos de transacciones. |
| **Respuesta** | El sistema permite agregar un nuevo proveedor de pago sin modificar el código central del negocio. Se implementa una nueva clase con la interfaz común definida, se registra en el contenedor de inyección de dependencias y la lógica de negocio existente (facturación, notificaciones, etc.) se reutiliza sin cambios. |
| **Medida de respuesta** | El nuevo método de pago se integra en menos de 2 días-hombre. El tiempo de despliegue es menor a 30 minutos y no requiere reiniciar el resto de los microservicios. La cobertura de pruebas unitarias se mantiene >85%. |

---

## 5. Escalabilidad

| Elemento | Descripción |
|----------|-------------|
| **Fuente de estímulo** | Usuarios finales concurrentes. |
| **Estímulo** | Aumenta la cantidad de usuarios realizando reservas al mismo tiempo (pico de demanda). |
| **Artefacto** | Balanceador de carga (Load Balancer), microservicio de reservas, base de datos (con replicación/partición) y sistema de colas (message broker). |
| **Respuesta** | El balanceador de carga distribuye las solicitudes entrantes entre múltiples instancias del microservicio de reservas. Las instancias adicionales se levantan automáticamente mediante autoescalado (horizontal) basado en métricas de CPU y memoria. Las reservas se procesan de forma asíncrona mediante colas para desacoplar la escritura en base de datos. |
| **Medida de respuesta** | El sistema soporta un incremento del 300% en el tráfico de reservas en menos de 5 minutos (escalado automático). El tiempo de respuesta promedio se mantiene <500 ms para el 95% de las peticiones, sin tiempo de inactividad ni pérdida de datos. La capacidad máxima es de 10,000 reservas simultáneas por minuto. |

---

## 6. Modificabilidad

| Elemento | Descripción |
|----------|-------------|
| **Fuente de estímulo** | Desarrollador / Product Owner. |
| **Estímulo** | Se necesita agregar un nuevo campo al perfil de usuario (ej. "preferencia de idioma" o "número de teléfono secundario"). |
| **Artefacto** | Microservicio de usuarios, base de datos de perfiles, API de actualización y frontend (formulario de perfil). |
| **Respuesta** | El sistema permite agregar el nuevo campo modificando únicamente la entidad de usuario, el DTO (Data Transfer Object) y la validación correspondiente. La capa de persistencia se actualiza mediante una migración de base de datos (sin afectar los datos existentes). La API existente (GET/PUT /users/{id}) se extiende para incluir el nuevo campo de forma opcional (backward compatible). El frontend agrega el nuevo campo en el formulario. |
| **Medida de respuesta** | El cambio se implementa en menos de 4 horas-hombre. La modificación no afecta a otros módulos ni requiere cambios en los consumidores de la API (gracias a la compatibilidad hacia atrás). La migración de base de datos se ejecuta en menos de 5 minutos sin downtime (usando estrategias como expand/contract o migraciones en caliente). |

