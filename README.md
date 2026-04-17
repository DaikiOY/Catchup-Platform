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

        pagos = softwareSystem "PayPal" "Sistema externo de pagos seguros"

        videollamada = softwareSystem "Web Notifications" "Servicio externo push"

        auth = softwareSystem "Android/IOS" "Plataforma operativa móvil"

        cliente -> finteka "Busca especialistas, reserva sesiones y realiza pagos"

        consultor -> finteka "Gestiona perfil, agenda y atiende asesorías"

        admin -> finteka "Administra usuarios, categorías y reportes"

        finteka -> pagos "Procesa pagos y valida transacciones"

        finteka -> videollamada "Envia recordatorios al usuario"

        finteka -> auth "Coordina mensajes o sesiones virtuales"

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
    videollamada = softwareSystem "Android/IOS" "Plataforma operativa móvil" "External"
    pagos = softwareSystem "Paypal" "Servicio externo de pago seguro." "External"
    notificaciones = softwareSystem "Web Notifications" "Servicio externo Push." "External"

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

workspace "FinTeka" "Arquitectura Jerárquica Final - Estilo Visual Paradigm" {

    model {
        # --- NIVEL 1: PERSONAS (Cúspide) ---
        cliente = person "Cliente" "Busca asesoría y reserva sesiones." "Persona"
        consultor = person "Consultor" "Profesional que atiende." "Persona"
        admin = person "Administrador" "Gestiona la plataforma." "Persona"

        finteka = softwareSystem "FinTeka" {
            
            # --- NIVEL 2: FRONTENDS ---
            landingPage = container "Landing Page" "Portal informativo." "React" "Nivel2"
            webApp = container "Web Application" "Interfaz de usuario principal." "React + TS" "Nivel2"

            # --- NIVEL 3: API REST (Contenedor de Tecnología) ---
            apiRest = container "API REST" "Tecnología: Java / Spring Boot" "Technology" {
                
                # --- NIVEL 4: CONTEXTOS DE NEGOCIO ---
                auth = component "Auth" "Seguridad e Identidad." "Spring Security" "Context"
                payment = component "Payment" "Gestión de transacciones externas." "Stripe" "Context"
                booking = component "Booking & Scheduling" "Gestión de citas." "Spring Service" "Context"
                requestVal = component "Request & Validation" "Validación de procesos." "Spring Service" "Context"
                contact = component "Contact" "Gestión de comunicación." "Spring Service" "Context"
                
                # --- NIVEL 5: LÓGICA E INFRAESTRUCTURA ---
                notifications = component "Notifications" "Orquestador de mensajes." "Spring Service" "Logic"
                db = component "Database Layer" "Persistencia MySQL." "JPA" "Database"
            }
        }

        # --- NIVEL 6: SISTEMAS DE SALIDA (Independientes - Color Gris) ---
        androidIos = softwareSystem "Android / IOS" "Plataforma operativa móvil." "ExternalSystem"
        webNotifications = softwareSystem "Web Notifications" "Servicio externo push." "ExternalSystem"
        stores = softwareSystem "Paypal" "Servicio de pago externo seguro." "ExternalSystem"

        # --- RELACIONES JERÁRQUICAS ---

        # Nivel 1 -> Nivel 2 (Conexión simultánea para asegurar visibilidad)
        cliente -> landingPage "Consulta"
        cliente -> webApp "Usa"
        consultor -> landingPage "Consulta"
        consultor -> webApp "Usa"
        admin -> landingPage "Consulta"
        admin -> webApp "Usa"

        # Nivel 2 -> Nivel 4 (Acceso a los componentes internos)
        landingPage -> auth "Registro"
        webApp -> auth "Login"
        webApp -> payment "Inicia Pago"
        webApp -> booking "Reserva"
        webApp -> requestVal "Solicitud"
        webApp -> contact "Mensaje"

        # Nivel 4 -> Nivel 5 (Internos)
        auth -> db "Consulta"
        booking -> db "Persiste"
        requestVal -> db "Escribe"
        
        auth -> notifications "Informa"
        booking -> notifications "Informa"
        requestVal -> notifications "Informa"
        contact -> notifications "Informa"

        # Nivel 4/5 -> Nivel 6 (Salidas independientes hacia el fondo)
        payment -> stores "Procesa cobro externo"
        contact -> androidIos "Notifica al dispositivo"
        notifications -> webNotifications "Entrega alerta push"
    }

    views {
        component apiRest "Arquitectura_Final_Sin_Conexiones_Base" {
            include *
            include cliente consultor admin
            
            autolayout tb 200 200
            description "6 Niveles: Actores -> Frontend -> API -> Contextos -> Datos -> Salidas Independientes."
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
                shape RoundedBox
            }
            relationship "Relationship" {
                dashed true
            }
        }
    }
}

#### Diagramas de Actividad UML

Diagrama 1: Proceso de reserva de un servicio

https://raw.githubusercontent.com/diegoroip/TukunTech/refs/heads/main/media/Miro/TukunTech%20-%20Architecture%20ViewPoints.jpg

Diagrama 2: Proceso de contacto con profesionales

https://raw.githubusercontent.com/diegoroip/TukunTech/refs/heads/main/media/Miro/TukunTech%20-%20Architecture%20ViewPoints%20(1).jpg
