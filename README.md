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
| **Fuente de estímulo** | Equipo de Nova Asesors. |
| **Estímulo** | Se necesita agregar un nuevo tipo de servicio de pago a la plataforma. |
| **Artefacto** | Microservicio de pagos, servicio externo de pagos. |
| **Respuesta** | El sistema permite agregar un nuevo proveedor de pago sin modificar el código central del negocio, sin modificar la lógica de negocio existente ni afectar el funcionamiento de los demás microservicios. |
| **Medida de respuesta** | El nuevo método de pago se integra en menos de 1 día. El tiempo de despliegue es menor a 30 minutos y no requiere reiniciar el resto de los microservicios. |

---

## 5. Escalabilidad

| Elemento | Descripción |
|----------|-------------|
| **Fuente de estímulo** | Usuarios finales, clientes y profesionales. |
| **Estímulo** | Aumenta la cantidad de usuarios realizando reservas al mismo tiempo. |
| **Artefacto** | Microservicio de reservas, base de datos. |
| **Respuesta** | El sistema distribuye la carga y continúa procesando las reservas sin afectar el rendimiento ni la disponibilidad del servicio. |
| **Medida de respuesta** | El sistema soporta un incremento del 200% en el tráfico de reservas. El tiempo de respuesta promedio se mantiene <500 ms para el 95% de las peticiones. |

---

## 6. Modificabilidad

| Elemento | Descripción |
|----------|-------------|
| **Fuente de estímulo** | Equipo de Nova Asesors. |
| **Estímulo** | Se necesita agregar un nuevo campo al perfil de usuario. |
| **Artefacto** | Microservicio de perfil, formulario actualizado de perfil. |
| **Respuesta** | El sistema permite agregar el nuevo campo modificando únicamente la entidad de usuario, el DTO y la validación correspondiente. El frontend agrega el nuevo campo en el formulario. |
| **Medida de respuesta** | El cambio se implementa en menos de 4 horas. La modificación no afecta a otros módulos ni requiere cambios, con una tasa de exito del 99%. |


------


| ID | Descripción |
|-----|-------------|
| **IRF-001** | El sistema debe permitir el registro de nuevos usuarios mediante un formulario digital accesible desde la plataforma web, solicitando como datos mínimos correo electrónico, nombre de usuario y contraseña. Durante el proceso, el sistema deberá validar que la información ingresada cumpla con las reglas establecidas de formato. Una vez completada la validación, la cuenta deberá almacenarse de forma segura en la base de datos y quedar habilitada para el acceso al sistema. |
| **IRF-008** | El sistema debe implementar roles diferenciados de usuario y consultor, asignando permisos específicos según las funciones de cada tipo de cuenta. |
| **NRF-001** | El sistema debe enviar una notificación automática de confirmación al usuario una vez completado satisfactoriamente el proceso de registro en la plataforma. |
