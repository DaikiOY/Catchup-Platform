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


#### Container

workspace "FinTeka" "Diagrama de Contenedores - Nivel 2" {

    model {
        # --- ACTORES ---
        cliente = person "Cliente" "Usuario que busca asesoría, reserva sesiones y realiza pagos." "User"
        consultor = person "Consultor" "Profesional que ofrece servicios y gestiona su agenda." "User"
        admin = person "Administrador" "Gestiona usuarios, categorías y operación general." "User"

        # --- SISTEMAS EXTERNOS ---
        notificaciones = softwareSystem "Sistema de Notificaciones" "Servicio externo para envío de correos y alertas push." "External"

        finteka = softwareSystem "FinTeka" {
            
            webApp = container "Aplicación Web Cliente" "Interfaz principal para clientes, consultores y administración." "React (SPA) + TypeScript" "Web Browser"
            
            authService = container "Servicio de Autenticación" "Gestiona login, registro y validación de seguridad." "Spring Security + JWT"
            
            apiPrincipal = container "API Principal" "Lógica de negocio: perfiles, reservas y gestión de profesionales." "Java + Spring Boot"
            
            db = container "Base de Datos" "Almacena información de usuarios, citas y configuraciones." "MySQL" "Database"
        }

        # --- RELACIONES ---
        # Los 3 actores usan la misma interfaz Web
        cliente -> webApp "Usa"
        consultor -> webApp "Usa"
        admin -> webApp "Usa"

        # Flujo de la aplicación
        webApp -> authService "Envía credenciales y solicita tokens" "HTTPS/JSON"
        webApp -> apiPrincipal "Solicita búsqueda, reservas y gestión" "HTTPS/JSON"
        
        # Comunicación entre servicios y persistencia
        apiPrincipal -> authService "Valida permisos de usuario" "gRPC/Internal"
        authService -> db "Lee/Escribe credenciales" "JDBC"
        apiPrincipal -> db "Consulta y persiste datos de negocio" "JDBC"
        
        # Integración externa
        apiPrincipal -> notificaciones "Dispara alertas de reservas y recordatorios" "SMTP/API"
    }

    views {
        container finteka "Contenedores" {
            include *
            autolayout lr
            description "Diagrama de Contenedores de la plataforma FinTeka."
        }

        styles {
            element "User" {
                shape Person
                background #08427b
                color #ffffff
            }
            element "Container" {
                background #1168bd
                color #ffffff
            }
            element "Web Browser" {
                shape WebBrowser
            }
            element "Database" {
                shape Cylinder
                background #225c94
            }
            element "External" {
                background #999999
                color #ffffff
            }
        }
    }
}

#### Components

workspace {

    model {

        /************* PERSONAS *************/
        cliente = person "Cliente" "Usuario que busca asesoría profesional, reserva sesiones y realiza pagos."
        consultor = person "Consultor" "Profesional que ofrece asesorías y administra su agenda."
        administrador = person "Administrador" "Gestiona usuarios, categorías, reportes y operación general."

        /************* SISTEMAS EXTERNOS *************/
        pagos = softwareSystem "Pasarela de Pagos" "Servicio externo para cobros y validación de transacciones."
        video = softwareSystem "Servicio de Videollamadas" "Plataforma externa para sesiones virtuales."
        authExterno = softwareSystem "Autenticación Externa" "Proveedor OAuth2 como Google."

        /************* SISTEMA PRINCIPAL *************/
        finteka = softwareSystem "FinTeka" "Plataforma digital que conecta clientes con consultores profesionales." {

            web = container "Aplicación Web" "Interfaz web para clientes, consultores y administradores." "React / Next.js"

            api = container "API Backend" "Expone servicios REST y lógica de negocio principal." "Spring Boot" {

                /************* CONTROLLERS *************/
                authController = component "Auth Controller" "Registro, login, JWT y sesiones." "Spring MVC"
                usuarioController = component "Usuario Controller" "Gestión de usuarios." "Spring MVC"
                perfilController = component "Perfil Controller" "Perfiles profesionales." "Spring MVC"
                busquedaController = component "Busqueda Controller" "Búsqueda y filtros." "Spring MVC"
                reservaController = component "Reserva Controller" "Reservas y agenda." "Spring MVC"
                pagoController = component "Pago Controller" "Cobros y confirmaciones." "Spring MVC"
                resenaController = component "Reseña Controller" "Valoraciones y reputación." "Spring MVC"
                adminController = component "Admin Controller" "Moderación y reportes." "Spring MVC"

                /************* SERVICES *************/
                authService = component "Auth Service" "Seguridad y tokens." "Spring Service"
                usuarioService = component "Usuario Service" "Lógica de usuarios." "Spring Service"
                perfilService = component "Perfil Service" "Gestión profesional." "Spring Service"
                busquedaService = component "Busqueda Service" "Ranking y filtros." "Spring Service"
                reservaService = component "Reserva Service" "Disponibilidad y reservas." "Spring Service"
                pagoService = component "Pago Service" "Procesamiento de pagos." "Spring Service"
                resenaService = component "Reseña Service" "Calificaciones." "Spring Service"
                adminService = component "Admin Service" "Gestión interna." "Spring Service"

                /************* REPOSITORIES *************/
                usuarioRepo = component "Usuario Repository" "Persistencia de usuarios." "Spring Data JPA"
                perfilRepo = component "Perfil Repository" "Persistencia de perfiles." "Spring Data JPA"
                reservaRepo = component "Reserva Repository" "Persistencia de reservas." "Spring Data JPA"
                pagoRepo = component "Pago Repository" "Persistencia de pagos." "Spring Data JPA"
                resenaRepo = component "Reseña Repository" "Persistencia de reseñas." "Spring Data JPA"
                categoriaRepo = component "Categoria Repository" "Persistencia de categorías." "Spring Data JPA"
            }

            db = container "PostgreSQL" "Base de datos relacional principal." "PostgreSQL"
        }

        /************* RELACIONES EXTERNAS *************/
        cliente -> web "Usa desde navegador"
        consultor -> web "Administra servicios"
        administrador -> web "Supervisa plataforma"

        web -> api "HTTPS / JSON"

        api -> pagos "Procesa cobros"
        api -> video "Genera enlaces de reunión"
        api -> authExterno "Login social"

        /************* CONTROLLERS -> SERVICES *************/
        authController -> authService
        usuarioController -> usuarioService
        perfilController -> perfilService
        busquedaController -> busquedaService
        reservaController -> reservaService
        pagoController -> pagoService
        resenaController -> resenaService
        adminController -> adminService

        /************* SERVICES -> REPOSITORIES *************/
        authService -> usuarioRepo
        usuarioService -> usuarioRepo
        perfilService -> perfilRepo
        busquedaService -> perfilRepo
        busquedaService -> categoriaRepo
        reservaService -> reservaRepo
        reservaService -> perfilRepo
        pagoService -> pagoRepo
        resenaService -> resenaRepo
        adminService -> usuarioRepo
        adminService -> categoriaRepo

        /************* REPOSITORIES -> DB *************/
        usuarioRepo -> db
        perfilRepo -> db
        reservaRepo -> db
        pagoRepo -> db
        resenaRepo -> db
        categoriaRepo -> db
    }

    views {

        component api "DiagramaComponentesFinTeka" {
            include cliente
            include consultor
            include administrador

            include authController
            include usuarioController
            include perfilController
            include busquedaController
            include reservaController
            include pagoController
            include resenaController
            include adminController

            include authService
            include usuarioService
            include perfilService
            include busquedaService
            include reservaService
            include pagoService
            include resenaService
            include adminService

            include usuarioRepo
            include perfilRepo
            include reservaRepo
            include pagoRepo
            include resenaRepo
            include categoriaRepo

            include db
            include pagos
            include video
            include authExterno

            autolayout tb 400 250
        }

        theme default
    }
}

#### Diagramas de Actividad UML

Diagrama 1: Proceso de reserva de un servicio

https://raw.githubusercontent.com/diegoroip/TukunTech/refs/heads/main/media/Miro/TukunTech%20-%20Architecture%20ViewPoints.jpg

Diagrama 2: Proceso de contacto con profesionales

https://raw.githubusercontent.com/diegoroip/TukunTech/refs/heads/main/media/Miro/TukunTech%20-%20Architecture%20ViewPoints%20(1).jpg
