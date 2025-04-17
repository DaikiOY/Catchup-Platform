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

## Installation and Usage

1. Clone this repository to your local machine:
   ```bash
   git clone [https://github.com/your-username/Catchup-Platform.git](https://github.com/DaikiOY/Catchup-Platform.git)





   <table> <tr> <th colspan="6"><b>Competitive Analysis Landscape</b></th> </tr> <tr> <td>¿Por qué llevar a cabo este análisis?</td> <td colspan="5">Este análisis fue realizado con el propósito de estudiar el valor ofrecido por las empresas que compiten con NutriPlan. La información obtenida nos proporciona la perspectiva necesaria para diseñar un servicio innovador, centrado en la personalización nutricional, la facilidad de uso y el bienestar del usuario.</td> </tr> <tr> <td colspan="2"></td> <td><b>NutriPlan</b></td> <td><b>MyFitnessPal</b></td> <td><b>Yazio</b></td> <td><b>Lifesum</b></td> </tr> <tr> <td rowspan="2"><b>Perfil</b></td> <td><b>Overview</b></td> <td>App web y móvil que ofrece planificación de comidas, recomendaciones de recetas, seguimiento nutricional y orientación personalizada según objetivos del usuario.</td> <td>App de seguimiento de alimentos y actividad física con gran base de datos de alimentos. Ofrece funciones para contar calorías y macros.</td> <td>Aplicación centrada en planes de alimentación personalizados, registro de alimentos y objetivos de peso con enfoque saludable.</td> <td>Aplicación de estilo de vida saludable que combina nutrición, dieta y bienestar, con planes personalizados y rastreo diario.</td> </tr> <tr> <td><b>Ventaja competitiva ¿Qué valor ofrece a los clientes?</b></td> <td>Alta personalización de planes de alimentación. Integración con historiales médicos, preferencias y objetivos. Experiencia simple e intuitiva.</td> <td>Gran comunidad de usuarios, base de datos extensa y facilidad de seguimiento de calorías. Integración con wearables.</td> <td>Planes flexibles adaptados al objetivo (bajar de peso, ganar músculo, comer más saludable). Interfaz visualmente amigable.</td> <td>Enfoque holístico en salud, incluye bienestar emocional y físico, no solo nutrición. Buen diseño y motivación mediante retos.</td> </tr> <tr> <td rowspan="2"><b>Perfil de Marketing</b></td> <td><b>Mercado objetivo</b></td> <td>Personas que buscan mejorar su alimentación, especialmente aquellas con necesidades especiales (diabetes, intolerancias, etc.).</td> <td>Usuarios que desean registrar su ingesta diaria y mejorar su condición física a través del control calórico.</td> <td>Personas interesadas en bajar de peso o mantener hábitos saludables con planes estructurados.</td> <td>Adultos jóvenes y profesionales que buscan un enfoque balanceado entre alimentación, ejercicio y bienestar.</td> </tr> <tr> <td><b>Estrategias de marketing</b></td> <td>Publicidad digital, influencers en nutrición, alianzas con profesionales de salud y clínicas. Contenido educativo gratuito.</td> <td>Publicidad por posicionamiento SEO, comunidad activa, integración con redes sociales y dispositivos de fitness.</td> <td>Campañas en redes sociales, uso de testimonios y antes/después. Marketing visual atractivo.</td> <td>Promociones con acceso gratuito limitado, storytelling de usuarios, integración con Apple Health y Google Fit.</td> </tr> <tr> <td rowspan="3"><b>Perfil de Producto</b></td> <td><b>Productos y Servicios</b></td> <td>Planes de comidas semanales personalizados, recetas saludables, lista de compras, seguimiento nutricional y sugerencias inteligentes.</td> <td>Contador de calorías, escáner de códigos, comunidad de usuarios y seguimiento de macronutrientes.</td> <td>Planificador de comidas, recetas, diario alimenticio y asesoramiento nutricional.</td> <td>Planes de dieta adaptables, rastreador de comidas, agua y ejercicio, retos de salud y bienestar.</td> </tr> <tr> <td><b>Precios y Costos</b></td> <td>Modelo freemium. Suscripción mensual o anual para desbloquear funciones avanzadas. Costos bajos de operación.</td> <td>Versión gratuita completa, con opción premium para análisis avanzados. Escalable y con amplio soporte de comunidad.</td> <td>Versión gratuita básica. Premium incluye planes detallados y recetas personalizadas.</td> <td>Acceso limitado gratuito. Suscripción premium para planes y retos personalizados.</td> </tr> <tr> <td><b>Canales de distribución (Web y/o móvil)</b></td> <td>Disponible en web y aplicaciones móviles (iOS y Android). Presencia en redes sociales y blogs especializados.</td> <td>App móvil (iOS, Android) y web. Alta visibilidad en tiendas de aplicaciones y foros fitness.</td> <td>App móvil. Sitio web como canal de promoción. Marketing en YouTube y redes sociales.</td> <td>App móvil. Fuerte marketing visual en Instagram y TikTok. Web con recursos educativos.</td> </tr> <tr> <td rowspan="5"><b>Análisis SWOT</b></td> <td colspan="5">Este análisis permite identificar cómo se posiciona NutriPlan frente a sus competidores y qué áreas pueden ser clave para construir una ventaja sostenible.</td> </tr> <tr> <td><b>Fortalezas</b></td> <td>Alta personalización, enfoque en salud integral, interfaz amigable. Adaptación a necesidades médicas.</td> <td>Base de datos amplia, integración con dispositivos, comunidad activa.</td> <td>Planes estructurados, visual atractivo, enfoque directo en pérdida de peso.</td> <td>Diseño moderno, enfoque integral de salud, motivación por hábitos.</td> </tr> <tr> <td><b>Debilidades</b></td> <td>Poca visibilidad inicial en el mercado, dependencia de suscripciones.</td> <td>Experiencia menos personalizada, puede ser abrumadora para nuevos usuarios.</td> <td>Menor flexibilidad en planes personalizados. Algunas funciones solo en premium.</td> <td>Enfoque generalista puede diluir el valor para usuarios con objetivos específicos.</td> </tr> <tr> <td><b>Oportunidades</b></td> <td>Tendencia creciente hacia la salud preventiva, colaboración con profesionales de la salud, segmentación por condiciones médicas.</td> <td>Expansión hacia planes más personalizados y recomendaciones inteligentes.</td> <td>Mercado en crecimiento de aplicaciones nutricionales. Integración con dispositivos fitness.</td> <td>Demanda creciente de bienestar holístico. Posibilidad de asociarse con marcas saludables.</td> </tr> <tr> <td><b>Amenazas</b></td> <td>Competencia de apps consolidadas, cambios en regulaciones de datos personales.</td> <td>Saturación del mercado, baja diferenciación sin funciones premium.</td> <td>Competencia con apps gratuitas. Retención de usuarios a largo plazo.</td> <td>Desinterés del usuario tras la novedad. Alta competencia en bienestar digital.</td> </tr> </table>
