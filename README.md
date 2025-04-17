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

<table>
  <tr>
    <th colspan="6"><b>Competitive Analysis Landscape</b></th>
  </tr>
  <tr>
    <td>¿Por qué llevar a cabo este análisis?</td>
    <td colspan="5">
      Este análisis fue realizado con el propósito de estudiar el valor ofrecido por las empresas que compiten con nuestra solución NutriPlan. La información obtenida nos proporcionará la perspectiva necesaria para la realización de un servicio innovador y diferenciador.
    </td>
  </tr>
  <tr>
    <td colspan="2"></td>
    <td><b>NutriPlan</b></td>
    <td><b>Yazio</b></td>
    <td><b>Noom</b></td>
    <td><b>Lifesum</b></td>
  </tr>
  <tr>
    <td rowspan="2"><b>Perfil</b></td>
    <td><b>Overview</b></td>
    <td>
      Plataforma de planificación de comidas y recetas saludables, con enfoque personalizado y educación nutricional accesible.
    </td>
    <td>
      App de planificación nutricional que ofrece seguimiento de comidas y macronutrientes con recetas saludables.
    </td>
    <td>
      App de salud que combina coaching nutricional y psicológico para mejorar hábitos alimenticios.
    </td>
    <td>
      Plataforma de nutrición personalizada basada en metas de salud y estilo de vida con interfaz atractiva.
    </td>
  </tr>
  <tr>
    <td><b>Ventaja competitiva ¿Qué valor ofrece a los clientes?</b></td>
    <td>
      Planificación de menús adaptada a gustos y objetivos, interfaz amigable, enfoque educativo y accesible para todos.
    </td>
    <td>
      Recetas visuales, fácil seguimiento de objetivos, buena interfaz y enfoque saludable europeo.
    </td>
    <td>
      Enfoque psicológico y conductual, coaching personalizado, más allá de contar calorías.
    </td>
    <td>
      Recomendaciones visuales y personalizadas según metas, buena experiencia de usuario.
    </td>
  </tr>
  <tr>
    <td rowspan="2"><b>Perfil de Marketing</b></td>
    <td><b>Mercado objetivo</b></td>
    <td>
      Familias, jóvenes y adultos que buscan comer mejor sin complicaciones, interesados en salud preventiva y recetas prácticas.
    </td>
    <td>
      Usuarios que desean una alimentación balanceada, basada en recetas y control de macronutrientes.
    </td>
    <td>
      Personas que buscan cambiar hábitos a largo plazo con apoyo conductual y motivacional.
    </td>
    <td>
      Usuarios modernos interesados en bienestar integral y nutrición con diseño atractivo.
    </td>
  </tr>
  <tr>
    <td><b>Estrategias de marketing</b></td>
    <td>
      Contenido educativo en redes sociales, colaboraciones con nutricionistas, modelo freemium con opción premium accesible.
    </td>
    <td>
      Promociones freemium, marketing de influencers, campañas en Instagram y TikTok.
    </td>
    <td>
      Publicidad en plataformas de salud, storytelling en redes, testimonios de usuarios.
    </td>
    <td>
      Estrategias visuales, campañas pagadas en redes, segmentación según metas de salud.
    </td>
  </tr>
  <tr>
    <td rowspan="3"><b>Perfil de Producto</b></td>
    <td><b>Productos y Servicios</b></td>
    <td>
      Recetas interactivas, planes semanales de comida, escáner de ingredientes, historial nutricional y consejos saludables.
    </td>
    <td>
      Seguimiento de comidas, planes de dieta, recetas saludables, estadísticas de macronutrientes.
    </td>
    <td>
      Coaching conductual, planes de alimentación y ejercicios, comunidad de apoyo.
    </td>
    <td>
      Dietas personalizadas, seguimiento visual del progreso, recomendaciones saludables.
    </td>
  </tr>
  <tr>
    <td><b>Precios y Costos</b></td>
    <td>
      Freemium con funciones básicas gratis y planes mensuales o anuales económicos.
    </td>
    <td>
      Modelo freemium con suscripción premium para acceso completo.
    </td>
    <td>
      Prueba gratuita, suscripción mensual con acceso a coach y planes personalizados.
    </td>
    <td>
      Modelo por suscripción, con precios según funciones y metas elegidas.
    </td>
  </tr>
  <tr>
    <td><b>Canales de distribución (Web y/o móvil)</b></td>
    <td>
      Web y app móvil (iOS/Android), versión web responsive y posibilidad de integración futura con dispositivos.
    </td>
    <td>
      App móvil con presencia fuerte en redes sociales y comunidad de usuarios.
    </td>
    <td>
      App móvil, acompañamiento vía notificaciones y correo electrónico.
    </td>
    <td>
      Web y app móvil con interfaz visual atractiva y recomendaciones personalizadas.
    </td>
  </tr>
  <tr>
    <td rowspan="5"><b>Análisis SWOT</b></td>
    <td colspan="5">
      Realice esto para su startup y sus competidores. Sus fortalezas deberían apoyar sus oportunidades y contribuir a lo que ustedes definen como su posible ventaja competitiva.
    </td>
  </tr>
  <tr>
    <td><b>Fortalezas</b></td>
    <td>
      Enfoque inclusivo, recetas regionales adaptadas, facilidad de uso, personalización inteligente.
    </td>
    <td>
      Diseño intuitivo, enfoque en recetas, análisis nutricional completo.
    </td>
    <td>
      Acompañamiento emocional, diferencial psicológico y enfoque en el hábito.
    </td>
    <td>
      Personalización visual, buena experiencia de usuario, adaptación a estilo de vida.
    </td>
  </tr>
  <tr>
    <td><b>Debilidades</b></td>
    <td>
      Escasa notoriedad de marca al inicio, sin integración aún con wearables.
    </td>
    <td>
      Limitado para usuarios que buscan coaching más avanzado o control conductual.
    </td>
    <td>
      Costo elevado frente a apps más simples, requiere mayor compromiso del usuario.
    </td>
    <td>
      Menor base de datos comparado con gigantes del mercado.
    </td>
  </tr>
  <tr>
    <td><b>Oportunidades</b></td>
    <td>
      Alianzas con supermercados, integración con nutricionistas, entrada a programas educativos y corporativos.
    </td>
    <td>
      Expansión a planes familiares y mercado corporativo wellness.
    </td>
    <td>
      Aumento de interés por la salud mental y nutrición consciente.
    </td>
    <td>
      Creciente mercado joven que valora estética y bienestar integral.
    </td>
  </tr>
  <tr>
    <td><b>Amenazas</b></td>
    <td>
      Alta competencia de apps posicionadas, dependencia del marketing digital para crecer.
    </td>
    <td>
      Saturación del mercado de apps nutricionales, dificultad para destacar sin diferenciación clara.
    </td>
    <td>
      Pérdida de usuarios por falta de resultados rápidos o motivación.
    </td>
    <td>
      Alta competencia, especialmente en diseño visual y experiencia de usuario.
    </td>
  </tr>
</table>






