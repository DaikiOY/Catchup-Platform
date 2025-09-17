# 📌 Backlog InventaTrack

| Epic / Story ID | Título | Descripción | Criterios de Aceptación | Relacionado con (Epic ID) |
| :---- | :---- | :---- | :---- | :---- |
| EP01 | Control de Stock | Gestionar los productos dentro del inventario. | CRUD de productos, registrar entradas/salidas, mostrar alertas de stock bajo. | - |
| US01 | Registrar producto | Como usuario quiero registrar un producto para controlarlo en el inventario. | Escenario 1: Registro exitoso con nombre, código y cantidad. Escenario 2: Error si faltan campos o son inválidos. | EP01 |
| US02 | Editar producto | Como usuario quiero editar datos de un producto existente. | Escenario 1: Actualización exitosa. Escenario 2: Error si producto no existe. | EP01 |
| US03 | Eliminar producto | Como usuario quiero eliminar un producto del inventario. | Escenario 1: Confirmación previa a la eliminación. Escenario 2: Producto eliminado no debe aparecer en la lista. | EP01 |
| US04 | Ver listado de productos | Como usuario quiero consultar todos los productos registrados. | Escenario: El sistema muestra tabla con nombre, código y stock. | EP01 |
| US05 | Alertas de bajo stock | Como usuario quiero ver alertas de productos en stock mínimo. | Escenario: Si cantidad ≤ 5, aparece alerta visual en el listado. | EP01 |
| US06 | Registrar entrada de stock | Como usuario quiero registrar entrada de productos. | Escenario: Cantidad se suma al stock actual. | EP01 |
| US07 | Registrar salida de stock | Como usuario quiero registrar salida por consumo o venta. | Escenario: Cantidad se descuenta del stock actual. | EP01 |
| US08 | Buscar productos | Como usuario quiero buscar productos por nombre o código. | Escenario: El sistema filtra resultados en tiempo real. | EP01 |
| EP02 | Gestión de Proveedores | Administrar proveedores y relacionarlos con productos. | CRUD de proveedores y asociación con productos. | - |
| US09 | Registrar proveedor | Como usuario quiero registrar un proveedor. | Escenario: Guardar nombre, contacto y teléfono. Error si faltan campos. | EP02 |
| US10 | Editar proveedor | Como usuario quiero actualizar datos de un proveedor. | Escenario: Actualización exitosa o error si proveedor no existe. | EP02 |
| US11 | Eliminar proveedor | Como usuario quiero eliminar un proveedor. | Escenario: Confirmación antes de eliminar. Escenario 2: Ya no aparece en la lista. | EP02 |
| US12 | Ver listado de proveedores | Como usuario quiero consultar todos los proveedores registrados. | Escenario: Mostrar tabla con datos de contacto. | EP02 |
| US13 | Asociar producto a proveedor | Como usuario quiero asociar productos a un proveedor. | Escenario: Asociación guardada y visible en ficha del proveedor. | EP02 |
| US14 | Consultar histórico de compras | Como usuario quiero ver compras realizadas a un proveedor. | Escenario: Mostrar lista de compras con fechas y cantidades. | EP02 |
| EP03 | Reportes y Gestión Gerencial | Generar reportes para análisis y toma de decisiones. | Reportes de stock, ventas, exportables en PDF/Excel. | - |
| US15 | Generar reporte de stock actual | Como usuario quiero generar un reporte con el stock actual. | Escenario: Reporte incluye todos los productos y alertas de stock bajo. | EP03 |
| US16 | Ver productos más vendidos | Como usuario quiero ver cuáles son los productos más vendidos. | Escenario: Listado ordenado de mayor a menor ventas. | EP03 |
| US17 | Reporte de bajo stock | Como usuario quiero generar reporte de productos en bajo stock. | Escenario: Listado automático de productos con cantidad ≤ 5. | EP03 |
| US18 | Descargar reporte en PDF o Excel | Como usuario quiero descargar los reportes en PDF o Excel. | Escenario: Exportación exitosa en ambos formatos. | EP03 |
| US19 | Enviar reporte por correo | Como usuario quiero enviar reportes a mi correo electrónico. | Escenario: Reporte adjunto enviado y confirmación de envío. | EP03 |
| US20 | Dashboard con gráficos | Como usuario quiero ver un dashboard con gráficos de inventario y ventas. | Escenario: Mostrar gráficos de barras y pastel con stock y ventas. | EP03 |

---

# 📌 Tablas Técnicas (TS - Technical Stories)

| ID    | Título | Descripción | Criterios de Aceptación |
|-------|--------|-------------|--------------------------|
| TS101 | API CRUD productos | Endpoints para registrar, editar, eliminar y consultar productos. | POST/PUT/DELETE/GET responden con 200 en éxito, errores por datos inválidos. |
| TS102 | API CRUD proveedores | Endpoints para registrar, editar, eliminar y consultar proveedores. | Operaciones responden con confirmación o error. |
| TS201 | API búsqueda productos | Implementar búsqueda por nombre o código. | GET /productos?query= retorna resultados filtrados. |
| TS202 | API alertas stock | Generar alertas automáticas de bajo stock. | GET /alertas retorna lista de productos con stock ≤ 5. |
| TS301 | Reporte de stock | Generar reporte de stock actual. | GET /reportes/stock retorna lista con cantidades actuales. |
| TS302 | Reporte de ventas | Generar reporte de productos más vendidos. | GET /reportes/ventas retorna lista ordenada. |
| TS303 | Exportación de reportes | Exportar reportes en PDF o Excel. | Endpoint descarga archivos correctos. |
| TS304 | Notificación por correo | Enviar reportes al correo del usuario. | POST /reportes/send confirma envío exitoso. |
| TS401 | Dashboard API | Proveer datos para gráficos en dashboard. | GET /dashboard retorna datasets para gráficos. |
| TS402 | Asociación producto-proveedor | Relacionar productos con proveedores. | POST /proveedor/:id/producto guarda la relación. |

