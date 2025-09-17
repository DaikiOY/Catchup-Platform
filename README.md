

# 📌 Backlog InventaTrack

## Épicas e Historias de Usuario

| Epic / Story ID | Título | Descripción | Criterios de Aceptación | Relacionado con (Epic ID) |
| :---- | :---- | :---- | :---- | :---- |
| EP01 | Control de Stock | Gestionar los productos dentro del inventario. | CRUD de productos, registrar entradas/salidas, mostrar alertas de stock bajo. | - |
| US01 | Registrar producto | Como usuario quiero registrar un producto para controlarlo en el inventario. | Escenario 1: Registro exitoso con nombre, código y cantidad. Escenario 2: Error si faltan campos o son inválidos. Escenario 3: No se permiten códigos duplicados. | EP01 |
| US02 | Editar producto | Como usuario quiero editar datos de un producto existente. | Escenario 1: Edición exitosa con datos válidos. Escenario 2: Error si el producto no existe. Escenario 3: Validación de campos obligatorios. | EP01 |
| US03 | Eliminar producto | Como usuario quiero eliminar un producto del inventario. | Escenario 1: Confirmación antes de eliminar. Escenario 2: El producto eliminado no debe aparecer en la lista. Escenario 3: Error si el producto ya fue eliminado previamente. | EP01 |
| US04 | Ver listado de productos | Como usuario quiero consultar todos los productos registrados. | Escenario: Mostrar listado con nombre, código, cantidad y proveedor asociado. | EP01 |
| US05 | Alertas de bajo stock | Como usuario quiero ver alertas de productos en stock mínimo. | Escenario 1: Si cantidad ≤ 5, aparece alerta visual en el listado. Escenario 2: La alerta desaparece cuando se repone el stock. | EP01 |
| US06 | Registrar entrada de stock | Como usuario quiero registrar entrada de productos. | Escenario 1: Cantidad ingresada se suma al stock actual. Escenario 2: Validar que la cantidad sea positiva. | EP01 |
| US07 | Registrar salida de stock | Como usuario quiero registrar salida por consumo o venta. | Escenario 1: Cantidad ingresada se descuenta del stock actual. Escenario 2: Error si la salida supera el stock disponible. | EP01 |
| US08 | Buscar productos | Como usuario quiero buscar productos por nombre o código. | Escenario: Resultados filtrados en tiempo real al escribir en el buscador. | EP01 |
| EP02 | Gestión de Proveedores | Administrar proveedores y relacionarlos con productos. | CRUD de proveedores y asociación con productos. | - |
| US09 | Registrar proveedor | Como usuario quiero registrar un proveedor. | Escenario 1: Registro exitoso con nombre, contacto y teléfono. Escenario 2: Error si faltan campos. | EP02 |
| US10 | Editar proveedor | Como usuario quiero actualizar datos de un proveedor. | Escenario 1: Actualización exitosa. Escenario 2: Error si el proveedor no existe. Escenario 3: Validación de email y teléfono. | EP02 |
| US11 | Eliminar proveedor | Como usuario quiero eliminar un proveedor. | Escenario 1: Confirmación antes de eliminar. Escenario 2: El proveedor eliminado ya no aparece en el listado. | EP02 |
| US12 | Ver listado de proveedores | Como usuario quiero consultar todos los proveedores registrados. | Escenario: Mostrar tabla con nombre, contacto y productos asociados. | EP02 |
| US13 | Asociar producto a proveedor | Como usuario quiero asociar productos a un proveedor. | Escenario: Asociación guardada y visible en la ficha del proveedor. | EP02 |
| US14 | Consultar histórico de compras | Como usuario quiero ver compras realizadas a un proveedor. | Escenario: Mostrar lista de compras con fechas, cantidades y montos. | EP02 |
| EP03 | Reportes y Gestión Gerencial | Generar reportes para análisis y toma de decisiones. | Reportes de stock, ventas, exportables en PDF/Excel. | - |
| US15 | Generar reporte de stock actual | Como usuario quiero generar un reporte con el stock actual. | Escenario: Reporte incluye productos, cantidades y alertas de stock bajo. | EP03 |
| US16 | Ver productos más vendidos | Como usuario quiero ver cuáles son los productos más vendidos. | Escenario: Listado ordenado de mayor a menor ventas. | EP03 |
| US17 | Reporte de bajo stock | Como usuario quiero generar reporte de productos en bajo stock. | Escenario: Listado automático con productos ≤ 5 unidades. | EP03 |
| US18 | Descargar reporte en PDF o Excel | Como usuario quiero descargar los reportes en PDF o Excel. | Escenario 1: Exportación exitosa en ambos formatos. Escenario 2: Error si no hay datos para exportar. | EP03 |
| US19 | Enviar reporte por correo | Como usuario quiero enviar reportes a mi correo electrónico. | Escenario: Reporte enviado y confirmación de envío mostrada en pantalla. | EP03 |
| US20 | Dashboard con gráficos | Como usuario quiero ver un dashboard con gráficos de inventario y ventas. | Escenario: Mostrar gráficos de barras (stock) y pastel (ventas). | EP03 |

---

## 📌 Historias Técnicas y de Soporte

| ID    | Título | Descripción | Criterios de Aceptación |
|-------|--------|-------------|--------------------------|
| TS101 | Registro de productos | Permitir el registro de productos con validaciones. | Registro exitoso con datos válidos, error si faltan campos o hay duplicados. |
| TS102 | Gestión de proveedores | Permitir registrar, editar y eliminar proveedores. | Registro exitoso, edición guardada, error si proveedor no existe. |
| TS201 | Búsqueda de productos | Implementar filtros de búsqueda por nombre o código. | Resultados correctos y en tiempo real. |
| TS202 | Alertas de stock bajo | Mostrar alertas automáticas cuando un producto tenga stock ≤ 5. | Alertas visibles en pantalla y actualizadas tras reposición. |
| TS301 | Reporte de stock | Generar reportes con el inventario actual. | Reporte completo en pantalla, incluye alertas de stock bajo. |
| TS302 | Reporte de ventas | Generar reporte con los productos más vendidos. | Reporte ordenado correctamente y exportable. |
| TS303 | Exportación de reportes | Exportar reportes en PDF o Excel. | Archivos descargados contienen la misma información del reporte. |
| TS304 | Envío de reportes | Permitir enviar reportes al correo del usuario. | Confirmación en pantalla al enviar, error si correo inválido. |
| TS401 | Dashboard gráfico | Mostrar gráficos de inventario y ventas. | Gráficos visibles, dinámicos y actualizados con los datos reales. |
| TS402 | Asociación producto-proveedor | Relacionar productos con proveedores. | Asociación guardada y visible en ficha de proveedor y producto. |
