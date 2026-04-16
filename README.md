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

workspace "FinTeka" "Diagrama de Contenedores - Compacto y Recto" {

    model {
        # --- COLUMNA 1: ACTORES ---
        cliente = person "Cliente" "Busca asesoría y reserva." "Actor"
        consultor = person "Consultor" "Gestiona agenda y atiende." "Actor"
        admin = person "Administrador" "Gestiona la plataforma." "Actor"

        # Amarre vertical (Invisibles)
        cliente -> consultor " " "Alineacion"
        consultor -> admin " " "Alineacion"

        # --- COLUMNA 5: SISTEMAS EXTERNOS ---
        videollamada = softwareSystem "Servicio Videollamadas" "Zoom/Meet." "External"
        pagos = softwareSystem "Pasarela de Pagos" "Stripe/PayU." "External"
        notificaciones = softwareSystem "Notificaciones" "Email/Push." "External"

        # Amarre vertical (Invisibles)
        videollamada -> pagos " " "Alineacion"
        pagos -> notificaciones " " "Alineacion"

        finteka = softwareSystem "FinTeka" {
            webApp = container "Web Application" "React + TypeScript" "React" "WebBrowser"
            apiGateway = container "API Gateway" "Ruteo y Seguridad" "Spring Cloud" "Service"
            
            authService = container "Auth Service" "Seguridad JWT" "Spring Security" "Service"
            apiPrincipal = container "API Principal" "Lógica de negocio" "Java / Spring Boot" "Service"
            
            db = container "Base de Datos" "MySQL" "MySQL" "Database"
            cache = container "Cache" "Redis" "Redis" "Database"
        }

        # --- CONEXIONES ---
        cliente -> webApp "Usa"
        consultor -> webApp "Usa"
        admin -> webApp "Usa"

        webApp -> apiGateway "HTTPS"
        apiGateway -> authService "Rutea"
        apiGateway -> apiPrincipal "Rutea"

        authService -> db " "
        apiPrincipal -> db " "
        apiPrincipal -> cache " "

        apiPrincipal -> videollamada "Sesiones"
        apiPrincipal -> pagos "Cobros"
        apiPrincipal -> notificaciones "Alertas"
    }

    views {
        container finteka "Contenedores_Compactos" {
            include *
            autolayout lr 150 150 
        }

        styles {
            element "Actor" {
                shape Person
                background #08427b
                color #ffffff
            }
            element "External" {
                background #777777
                color #ffffff
                shape RoundedBox
            }
            element "WebBrowser" {
                shape WebBrowser
                background #438dd5
            }
            element "Service" {
                shape RoundedBox
                background #1168bd
                color #ffffff
            }
            element "Database" {
                shape Cylinder
                background #225c94
            }
            relationship "Alineacion" {
                color #ffffff
                thickness 0
                routing Direct
            }
        }
    }
}

#### Components

workspace "FinTeka" "Arquitectura Jerárquica 6 Niveles Corregida" {

    model {
        # --- NIVEL 1: PERSONAS (Top) ---
        cliente = person "Cliente" "Usuario que busca asesoría." "Persona"
        consultor = person "Consultor" "Profesional que atiende." "Persona"
        admin = person "Administrador" "Gestiona la plataforma." "Persona"

        # Alineación horizontal Nivel 1
        cliente -> consultor " " "Alineacion"
        consultor -> admin " " "Alineacion"

        finteka = softwareSystem "FinTeka" {
            
            # --- NIVEL 2: FRONTENDS ---
            landingPage = container "Landing Page" "Portal informativo." "React" "Nivel2"
            webApp = container "Web Application" "Interfaz de usuario." "React + TS" "Nivel2"

            # --- NIVEL 3: API REST (Contenedor Padre) ---
            apiRest = container "API REST" "Tecnología: Java / Spring Boot" "Spring Boot" "Technology" {
                
                # --- NIVEL 4: CONTEXTOS (Componentes) ---
                auth = component "Auth" "Gestiona identidad y acceso." "Spring Security" "Context"
                booking = component "Booking & Scheduling" "Gestión de citas." "Spring Service" "Context"
                requestVal = component "Request & Validation" "Validación de procesos." "Spring Service" "Context"
                contact = component "Contact" "Gestión de comunicación." "Spring Service" "Context"
                
                # --- NIVEL 5 (A): MOTOR DE NOTIFICACIONES ---
                notifications = component "Notifications" "Orquestador de mensajes." "Spring Service" "Logic"
            }
            
            # --- NIVEL 5 (B): INFRAESTRUCTURA ---
            db = container "Database" "Persistencia: MySQL." "MySQL" "Database"
            androidIos = container "Android / IOS" "Sistema operativo móvil." "Mobile OS" "ExternalSystem"
        }

        # --- NIVEL 6: SALIDA FINAL ---
        webNotifications = softwareSystem "Web Notifications" "Servicio externo de alertas." "ExternalSystem"

        # --- RELACIONES JERÁRQUICAS (Flujo descendente) ---

        # N1 -> N2
        cliente -> landingPage "Visita"
        consultor -> webApp "Usa"
        admin -> webApp "Gestiona"

        # N2 -> N4 (Acceso directo a componentes internos eliminando la relación padre-hijo)
        landingPage -> auth "Registra/Valida"
        webApp -> auth "Autentica"
        webApp -> booking "Reserva"
        webApp -> requestVal "Envía peticiones"
        webApp -> contact "Inicia contacto"

        # N4 -> N5 (Persistencia y Notificación)
        requestVal -> db "Persiste"
        auth -> db "Consulta"
        booking -> db "Guarda"
        contact -> androidIos "Notifica"

        # N4 -> Notifications (N5)
        auth -> notifications "Informa"
        booking -> notifications "Informa"
        requestVal -> notifications "Informa"
        contact -> notifications "Informa"

        # N5 -> N6
        notifications -> webNotifications "Envía alerta"
    }

    views {
        component apiRest "Arquitectura_6_Niveles" {
            include *
            autolayout tb 150 150
            description "Diagrama de 6 niveles verticales: De Actores a Notificaciones Web."
        }

        styles {
            element "Persona" {
                shape Person
                background #08427b
                color #ffffff
            }
            element "Nivel2" {
                background #777777
                color #ffffff
            }
            element "Technology" {
                background #1168bd
                color #ffffff
            }
            element "Context" {
                background #85bbf0
                color #000000
                shape RoundedBox
            }
            element "Database" {
                shape Cylinder
                background #225c94
                color #ffffff
            }
            element "ExternalSystem" {
                background #444444
                color #ffffff
            }
            relationship "Alineacion" {
                color #ffffff00
                thickness 0
            }
        }
    }
}

#### Diagramas de Actividad UML

Diagrama 1: Proceso de reserva de un servicio

https://raw.githubusercontent.com/diegoroip/TukunTech/refs/heads/main/media/Miro/TukunTech%20-%20Architecture%20ViewPoints.jpg

Diagrama 2: Proceso de contacto con profesionales

https://raw.githubusercontent.com/diegoroip/TukunTech/refs/heads/main/media/Miro/TukunTech%20-%20Architecture%20ViewPoints%20(1).jpg
