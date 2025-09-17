# Catchup-Platform

## Description

**Catchup-Platform** is a C# application that allows users to save, update, delete, and query their favorite news sources. The project follows best development practices and uses **Clean Architecture** and the **CQRS** pattern to separate read and write operations.

## Functionality

The application provides the following features for users to interact with their favorite sources:

- **Create**: Save a new favorite source.
- **Read**: Query an existing favorite source.
- **Update**: Modify a saved favorite source.
- **Delete**: Remove a favorite source.

These operations are implemented following the **CQRS** (Command Query Responsibility Segregation) pattern, separating command (write) and query (read) operations.

## Technologies Used

- **Language**: C#
- **IDE**: Visual Studio
- **Architecture Pattern**: Clean Architecture
- **Design Pattern**: CQRS (Command Query Responsibility Segregation)
- **Version Control**: Git (GitHub repository)

## Libraries Used

- **Entity Framework Core**: For data management and persistence.
- **MediatR**: For implementing CQRS (separating commands and queries).
- **xUnit**: For unit testing.
- **FluentValidation**: For input data validation.

## Team Members

- Daiki Oscar Oshiro Yamashita
- Gabriel Alejandro Rivera Ayala
- Karito Dianeth Medina Chocce
- Yair Christofer Aru Acevedo

| Aspectos                | **InventaTrack**                                                                                                   | **Competidor 1: FreshTrack**                                                      | **Competidor 2: FoodManage Pro**                                                 | **Competidor 3: StockSmart**                                                    |
|-------------------------|-------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------|----------------------------------------------------------------------------------|----------------------------------------------------------------------------------|
| **Perfil**              | Startup enfocada en PYMEs de alimentos perecederos, con solución digital simple y accesible.                      | Empresa establecida con enfoque en grandes restaurantes y cadenas.               | Software SaaS para gestión integral de inventarios en sectores alimentarios.     | Plataforma para control de inventarios con foco en supermercados y hoteles.      |
| **Overview**            | Plataforma web para registrar productos, alertas de caducidad, reportes de merma y control de stock.              | Sistema avanzado con integración IoT y sensores para monitoreo en tiempo real.   | Solución robusta con reportes detallados y módulos de compra y ventas.           | Aplicación móvil y web con seguimiento de stock y alertas personalizables.       |
| **Ventaja competitiva** | Fácil uso, bajo costo, no requiere hardware adicional, adaptado a pequeñas y medianas empresas.                    | Integración de hardware para control automático, pero mayor costo.                | Funcionalidades completas para grandes operaciones, pero complejo para PYMEs.    | Flexibilidad en alertas y reportes, pero menos intuitivo y con curva de aprendizaje. |
| **¿Qué valor ofrece a los clientes?** | Reducción de pérdidas, control eficiente y accesible del inventario sin complicaciones técnicas.     | Precisión y automatización avanzada, monitoreo en tiempo real.                    | Control integral y toma de decisiones basada en datos complejos.                 | Personalización de alertas y reportes para diferentes tipos de negocios.         |
| **Perfil de Marketing** |                                                                                                                   |                                                                                  |                                                                                  |                                                                                  |
| Mercado objetivo        | PYMEs: restaurantes, cocinas ocultas, hoteles pequeños y supermercados medianos.                                  | Grandes cadenas de restaurantes y hoteles con recursos para tecnología avanzada. | Empresas medianas y grandes del sector alimentario con equipo dedicado.          | Negocios medianos con necesidad de flexibilidad en gestión de stock.             |
| Estrategias de marketing | Marketing digital, demostraciones gratuitas, enfoque en costo-beneficio y facilidad de uso.                      | Venta directa, ferias tecnológicas y alianzas con fabricantes de hardware.       | Publicidad en sectores especializados, seminarios y consultoría.                 | Marketing online, webinars y soporte técnico personalizado.                      |
| **Perfil de Producto**  |                                                                                                                   |                                                                                  |                                                                                  |                                                                                  |
| Productos & Servicios   | Plataforma web, registro digital, alertas, reportes, soporte básico.                                              | Software + hardware (sensores), monitoreo en tiempo real, soporte premium.       | Software integral, módulos para compras, ventas, reportes avanzados.             | Plataforma web y app móvil, alertas personalizadas, soporte medio.               |
| Precios & Costos        | Bajo costo inicial, suscripción mensual accesible.                                                                | Costos altos por hardware e implementación.                                     | Precios elevados, contratos anuales.                                            | Costo medio, suscripción mensual.                                               |
| Canales de distribución (Web y/o Móvil) | Web responsiva, accesible desde cualquier dispositivo.                                                     | Web, app móvil y hardware integrado.                                             | Web y app móvil.                                                                 | Web y app móvil.                                                                 |
| **Análisis SWOT**       |                                                                                                                   |                                                                                  |                                                                                  |                                                                                  |
| Fortalezas              | Bajo costo, fácil implementación, sin necesidad de hardware, enfoque en PYMEs.                                    | Tecnología avanzada, monitoreo en tiempo real.                                  | Funcionalidad completa, solución integral.                                     | Flexibilidad y personalización.                                                 |
| Debilidades             | Menos automatización, depende de ingreso manual.                                                                   | Alto costo, no accesible para PYMEs.                                            | Complejidad, requiere personal capacitado.                                     | Interfaz menos intuitiva, curva de aprendizaje alta.                            |
| Oportunidades           | Creciente demanda de digitalización en PYMEs, mercado poco explotado.                                             | Expansión en mercados grandes y corporativos.                                  | Mercado de empresas grandes con necesidades complejas.                         | Mejoras en UX podrían captar más usuarios.                                    |
| Amenazas                | Competidores con mayor inversión tecnológica, adopción lenta de PYMEs.                                             | Competencia de soluciones sin hardware, resistencia al costo elevado.           | Competencia con soluciones más accesibles para PYMEs.                          | Nuevas apps con mejor UX y precio competitivo.                                |


