<table align="center" border="1" width="95%" style="text-align:center">
  <tr>
    <td><b>Endpoint</b></td>
    <td><b>Acción</b></td>
    <td><b>Método HTTP</b></td>
    <td><b>Sintaxis de llamada</b></td>
    <td><b>Parámetros Principales</b></td>
    <td><b>URL Swagger</b></td>
  </tr>
  <tr>
    <td>/login</td>
    <td>Iniciar sesión</td>
    <td>POST</td>
    <td>POST /login</td>
    <td>email, password</td>
    <td>/swagger/login</td>
  </tr>
  <tr>
    <td>/users</td>
    <td>Consultar perfil de usuario</td>
    <td>GET</td>
    <td>GET /users/{id}</td>
    <td>idUsuario</td>
    <td>/swagger/users</td>
  </tr>
  <tr>
    <td>/inventory</td>
    <td>Listar inventarios</td>
    <td>GET</td>
    <td>GET /inventory</td>
    <td>nombre, fechaDesde, fechaHasta</td>
    <td>/swagger/inventory</td>
  </tr>
  <tr>
    <td>/inventory</td>
    <td>Agregar nuevo producto</td>
    <td>POST</td>
    <td>POST /inventory</td>
    <td>nombreProducto, cantidad, fechaCaducidad, proveedor</td>
    <td>/swagger/inventory</td>
  </tr>
  <tr>
    <td>/inventory/{id}</td>
    <td>Actualizar producto</td>
    <td>PUT</td>
    <td>PUT /inventory/{id}</td>
    <td>idProducto, nombreProducto, cantidad, fechaCaducidad, proveedor</td>
    <td>/swagger/inventory</td>
  </tr>
  <tr>
    <td>/reports/stock</td>
    <td>Generar reportes de stock crítico</td>
    <td>GET</td>
    <td>GET /reports/stock</td>
    <td>fechaDesde, fechaHasta</td>
    <td>/swagger/reports/stock</td>
  </tr>
  <tr>
    <td>/reports/expiration</td>
    <td>Generar reportes de productos próximos a vencer</td>
    <td>GET</td>
    <td>GET /reports/expiration</td>
    <td>diasPrevios</td>
    <td>/swagger/reports/expiration</td>
  </tr>
</table>
