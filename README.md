# Historias de Usuario - InventaTech

| Epic / Story ID | Título | Descripción | Criterios de Aceptación | Relacionado con (Epic ID) |
|-----------------|--------|-------------|-------------------------|----------------------------|
| **EP01** | Registro y Autenticación | Permitir a los usuarios operativos y gerenciales acceder de forma segura a la plataforma. | - Registro sencillo. <br> - Inicio de sesión validado. <br> - Recuperación de credenciales. | - |
| US01 | Registro de usuarios operativos | **Como administrador de almacén**, **Quiero** registrarme en la plataforma, **Para** poder gestionar insumos y stock. | Registro exitoso al completar campos obligatorios. Error si datos inválidos. | EP01 |
| US02 | Registro de usuarios gerenciales | **Como gerente**, **Quiero** registrar mi cuenta, **Para** acceder a reportes y dashboards. | Validación de datos, confirmación de cuenta creada. | EP01 |
| US03 | Inicio de sesión seguro | **Como usuario**, **Quiero** iniciar sesión con mi correo y contraseña, **Para** acceder a mis funciones según mi rol. | Acceso exitoso con credenciales correctas, mensaje de error con datos inválidos. | EP01 |
| US04 | Recuperación de contraseña | **Como usuario**, **Quiero** recuperar mi contraseña olvidada, **Para** ingresar de nuevo a la plataforma. | Envío de enlace de recuperación al correo registrado. | EP01 |
| **EP02** | Control de Stock | Permitir a los usuarios operativos registrar y monitorear insumos. | - Registro y edición de insumos. <br> - Alertas de caducidad. <br> - Visualización de inventario actualizado. | - |
| US05 | Registrar insumos | **Como encargado de cocina**, **Quiero** registrar nuevos insumos, **Para** llevar un control de lo que entra al inventario. | Campos de nombre, cantidad y fecha obligatorios. | EP02 |
| US06 | Editar insumos | **Como administrador de almacén**, **Quiero** editar información de un insumo, **Para** mantener actualizados los datos. | Cambios guardados correctamente, error si campos vacíos. | EP02 |
| US07 | Visualizar stock | **Como usuario operativo**, **Quiero** ver el listado actualizado de insumos, **Para** conocer el estado actual del inventario. | Lista visible con cantidades, fechas y estado. | EP02 |
| US08 | Alertas de caducidad | **Como encargado de cocina**, **Quiero** recibir alertas de insumos próximos a caducar, **Para** evitar desperdicios. | Notificación cuando la fecha esté próxima. | EP02 |
| **EP03** | Movimientos de Inventario | Gestionar entradas, salidas y devoluciones de insumos. | - Registro de movimientos. <br> - Actualización automática de stock. | - |
| US09 | Registrar entradas de insumos | **Como administrador de almacén**, **Quiero** registrar la entrada de insumos, **Para** mantener actualizado el inventario. | Movimiento reflejado en el stock total. | EP03 |
| US10 | Registrar salidas de insumos | **Como encargado de cocina**, **Quiero** registrar el consumo de insumos, **Para** reflejar el uso en la operación diaria. | Disminución automática en el stock. | EP03 |
| US11 | Registrar devoluciones | **Como usuario operativo**, **Quiero** registrar devoluciones de insumos al almacén, **Para** mantener consistencia en el inventario. | Stock se actualiza correctamente. | EP03 |
| US12 | Historial de movimientos | **Como administrador de almacén**, **Quiero** consultar el historial de entradas y salidas, **Para** auditar y rastrear cambios. | Lista de movimientos con fecha, usuario y cantidad. | EP03 |
| **EP04** | Reportes y Dashboard Gerencial | Brindar información a los dueños y gerentes para la toma de decisiones. | - Reportes claros. <br> - Dashboard actualizado. | - |
| US13 | Visualizar reportes de consumo | **Como gerente**, **Quiero** ver reportes de consumo de insumos, **Para** controlar costos y detectar excesos. | Reporte descargable y filtrado por fechas. | EP04 |
| US14 | Dashboard de stock crítico | **Como gerente**, **Quiero** ver un dashboard con insumos críticos, **Para** tomar decisiones de compra. | Visualización gráfica con alertas en rojo para insumos bajos. | EP04 |
| US15 | Exportar reportes | **Como administrador**, **Quiero** exportar reportes en PDF o Excel, **Para** analizarlos fuera de la plataforma. | Botón de exportar genera archivo válido. | EP04 |
| US16 | Comparar periodos de consumo | **Como gerente**, **Quiero** comparar consumo de diferentes periodos, **Para** identificar tendencias. | Gráficas comparativas entre periodos seleccionados. | EP04 |
| **EP05** | Comunicación y Notificaciones | Mantener informados a los usuarios sobre eventos importantes. | - Notificaciones claras y oportunas. <br> - Canales internos de comunicación. | - |
| US17 | Notificaciones de stock bajo | **Como usuario operativo**, **Quiero** recibir notificaciones de stock bajo, **Para** reabastecer a tiempo. | Mensaje visible cuando un insumo alcanza mínimo. | EP05 |
| US18 | Notificación de caducidad | **Como gerente**, **Quiero** recibir alertas de insumos próximos a vencer, **Para** supervisar acciones correctivas. | Alerta enviada a panel y correo. | EP05 |
| US19 | Mensajes internos | **Como usuario operativo**, **Quiero** enviar mensajes a otro usuario del almacén, **Para** coordinar tareas. | Mensaje enviado y recibido con confirmación. | EP05 |
| US20 | Resumen diario automático | **Como gerente**, **Quiero** recibir un resumen diario de stock y movimientos, **Para** mantenerme informado sin ingresar siempre a la app. | Notificación automática cada día con información clave. | EP05 |
