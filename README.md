## 4.1.3 Context Diagram

El System Context Diagram corresponde al primer nivel del modelo C4 y permite visualizar el sistema desde una perspectiva general. Su propósito es mostrar cómo FinTeka se relaciona con los principales actores externos y con los sistemas complementarios necesarios para su funcionamiento.

En este contexto, FinTeka se presenta como una plataforma digital orientada a conectar clientes con consultores profesionales, facilitando procesos como búsqueda de especialistas, reservas de sesiones, pagos seguros, videollamadas y autenticación externa.

En este Context Diagram se muestra a FinTeka como el sistema central que interactúa con los principales usuarios y servicios externos necesarios para su operación.

### Actores principales:

- **Clientes / Usuarios:** personas o empresas que buscan asesoría profesional, comparan especialistas, reservan sesiones y realizan pagos.  
- **Consultores / Especialistas:** profesionales independientes que ofrecen servicios de asesoría, gestionan su agenda y atienden sesiones programadas.  
- **Administradores:** responsables de supervisar la plataforma, gestionar usuarios, categorías, reportes y asegurar el correcto funcionamiento del sistema.

### Sistemas externos críticos:

- **Pasarela de pagos:** servicio externo encargado de procesar pagos seguros y validar transacciones realizadas dentro de la plataforma.  
- **Servicio de videollamadas:** sistema externo utilizado para ejecutar sesiones virtuales entre clientes y consultores.  
- **Servicios de autenticación externa:** integración opcional con proveedores como Google u otros servicios para facilitar el inicio de sesión seguro.

Codigo:
workspace {

    model {

        cliente = person "Cliente" "Usuario que busca asesoría profesional, reserva sesiones y realiza pagos."

        consultor = person "Consultor" "Profesional que ofrece servicios de asesoría y administra su agenda."

        admin = person "Administrador" "Gestiona usuarios, reportes, categorías y operación general."

        finteka = softwareSystem "FinTeka" "Plataforma digital que conecta clientes con consultores profesionales."

        pagos = softwareSystem "Pasarela de Pagos" "Sistema externo encargado de procesar pagos seguros y confirmar transacciones."

        videollamada = softwareSystem "Servicio de Videollamadas" "Sistema externo utilizado para sesiones virtuales entre clientes y consultores."

        auth = softwareSystem "Autenticación Externa" "Proveedor externo para inicio de sesión con Google u otros servicios."

        cliente -> finteka "Busca especialistas, reserva sesiones y realiza pagos"

        consultor -> finteka "Gestiona perfil, agenda y atiende asesorías"

        admin -> finteka "Administra usuarios, categorías y reportes"

        finteka -> pagos "Procesa pagos y valida transacciones"

        finteka -> videollamada "Coordina sesiones virtuales"

        finteka -> auth "Valida autenticación externa"

    }

    views {

        systemContext finteka "SystemContext" {
            include *
            autolayout lr
        }

        theme default
    }

}

## 4.1.4 Approaches Statements Architectural Styles & Patterns

