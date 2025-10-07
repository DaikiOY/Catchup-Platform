<table align="center" border="1" width="95%" style="text-align:center">
  <tr>
    <td><b>Endpoint</b></td>
    <td><b>Acción / Descripción</b></td>
    <td><b>Método HTTP</b></td>
    <td><b>Sintaxis de llamada</b></td>
    <td><b>Parámetros Principales</b></td>
    <td><b>URL Swagger</b></td>
  </tr>
  <tr>
    <td>/login</td>
    <td>Iniciar sesión de usuario operativo o gerencial. Valida credenciales y devuelve token de sesión.</td>
    <td>POST</td>
    <td>POST /login</td>
    <td>email, password</td>
    <td>/swagger/login</td>
  </tr>
  <tr>
    <td>/users/{id}</td>
    <td>Obtener información de perfil de un usuario específico. Permite mostrar datos del perfil en la interfaz.</td>
    <td>GET</td>
    <td>GET /users/{id}</td>
    <td>idUsuario</td>
    <td>/swagger/users</td>
  </tr>
  <tr>
    <td>/inventory</td>
    <td>Listar inventarios. Permite filtrar productos por nombre, fecha de registro o fecha de caducidad.</td>
    <td>GET</td>
    <td>GET /inventory?nombre=&fechaDesde=&fechaHasta=</td>
    <td>nombreProducto (opcional), fechaDesde, fechaHasta</td>
    <td>/swagger/inventory</td>
  </tr>
  <tr>
    <td>/inventory</td>
    <td>Registrar un nuevo producto en el inventario. Se valida que los campos obligatorios estén completos.</td>
    <td>POST</td>
    <td>POST /inventory</td>
    <td>nombreProducto, cantidad, fechaCaducidad, proveedor</td>
    <td>/swagger/inventory</td>
  </tr>
  <tr>
    <td>/inventory/{id}</td>
    <td>Actualizar información de un producto existente. Incluye modificación de cantidad, nombre o fecha de caducidad.</td>
    <td>PUT</td>
    <td>PUT /inventory/{id}</td>
    <td>idProducto, nombreProducto, cantidad, fechaCaducidad, proveedor</td>
    <td>/swagger/inventory</td>
  </tr>
  <tr>
    <td>/reports/stock</td>
    <td>Generar reportes de stock crítico, indicando productos con baja cantidad para priorizar compras.</td>
    <td>GET</td>
    <td>GET /reports/stock?fechaDesde=&fechaHasta=</td>
    <td>fechaDesde, fechaHasta</td>
    <td>/swagger/reports/stock</td>
  </tr>
  <tr>
    <td>/reports/expiration</td>
    <td>Generar reportes de productos próximos a vencer, permitiendo acciones preventivas para evitar pérdidas.</td>
    <td>GET</td>
    <td>GET /reports/expiration?diasPrevios=5</td>
    <td>diasPrevios (cantidad de días antes de la caducidad para generar alerta)</td>
    <td>/swagger/reports/expiration</td>
  </tr>
  <tr>
    <td>/inventory/search</td>
    <td>Búsqueda avanzada de productos por nombre, fechas de ingreso o caducidad, y proveedor.</td>
    <td>GET</td>
    <td>GET /inventory/search?nombre=&fechaDesde=&fechaHasta=&proveedor=</td>
    <td>nombreProducto, fechaDesde, fechaHasta, proveedor (opcional)</td>
    <td>/swagger/inventory/search</td>
  </tr>
</table>
