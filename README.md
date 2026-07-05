# Drivers de negocio

## 1. Facilitar la conexión entre usuarios y profesionales
**Descripción:** Permitir que los usuarios encuentren, reserven y gestionen servicios profesionales desde una única plataforma de manera rápida y sencilla.

## 2. Garantizar pagos seguros
**Descripción:** Asegurar que los pagos de sesiones y suscripciones se procesen correctamente, brindando confianza tanto a usuarios como a profesionales.

## 3. Mejorar la experiencia del usuario
**Descripción:** Ofrecer una plataforma fácil de usar donde los usuarios puedan administrar su perfil, reservas, pagos y valoraciones sin dificultades.

## 4. Incrementar la confianza en los profesionales
**Descripción:** Permitir que los usuarios califiquen y valoren a los profesionales para ayudar a otros usuarios a tomar mejores decisiones.

## 5. Automatizar la comunicación
**Descripción:** Enviar notificaciones sobre reservas, pagos y sesiones para mantener informados a usuarios y profesionales en todo momento.

---

# Atributos de calidad y tácticas

## 1. Seguridad

- **Atributo:** Seguridad
- **Escenario:** Un usuario intenta iniciar sesión con una contraseña incorrecta.
- **Origen:** Usuario.
- **Artefacto:** Servicio de Autenticación (Auth).
- **Respuesta:** El sistema rechaza el acceso y muestra un mensaje indicando que las credenciales son incorrectas.
- **Táctica:** Validación de credenciales antes de permitir el acceso.

---

## 2. Rendimiento

- **Atributo:** Rendimiento
- **Escenario:** Un usuario consulta el saldo de su monedero.
- **Origen:** Usuario.
- **Artefacto:** Servicio de Pagos.
- **Respuesta:** El sistema muestra el saldo en menos de 2 segundos.
- **Táctica:** Optimización de consultas para reducir el tiempo de respuesta.

---

## 3. Usabilidad

- **Atributo:** Usabilidad
- **Escenario:** Un usuario registra una nueva reserva.
- **Origen:** Usuario.
- **Artefacto:** Servicio de Reservas.
- **Respuesta:** El sistema confirma la reserva mostrando un mensaje de éxito con la información de la sesión.
- **Táctica:** Mensajes claros de confirmación y error para facilitar el uso de la plataforma.

---

## 4. Modificabilidad

- **Atributo:** Modificabilidad
- **Escenario:** Se agrega un nuevo tipo de notificación al sistema.
- **Origen:** Desarrollador.
- **Artefacto:** Servicio de Notificaciones.
- **Respuesta:** El nuevo tipo de notificación puede incorporarse sin afectar el funcionamiento de los demás servicios.
- **Táctica:** Separación de funcionalidades en microservicios independientes.

---

## 5. Escalabilidad

- **Atributo:** Escalabilidad
- **Escenario:** Aumenta la cantidad de usuarios realizando reservas al mismo tiempo.
- **Origen:** Incremento de usuarios.
- **Artefacto:** Servicio de Reservas.
- **Respuesta:** El sistema continúa atendiendo las solicitudes sin afectar significativamente el tiempo de respuesta.
- **Táctica:** Escalado independiente del microservicio de reservas según la demanda.
