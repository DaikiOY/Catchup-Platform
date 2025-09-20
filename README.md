### Convenciones y Buenas Prácticas en InventaTrack

#### HTML5
En **InventaTrack**, el uso de HTML5 constituye la base para estructurar el contenido de la Landing Page y las vistas del sistema de inventario. Para mantener un código ordenado y accesible se aplican las siguientes prácticas:

- Usar etiquetas en **minúsculas** para mantener uniformidad y facilitar la lectura.  
- Cerrar correctamente todas las etiquetas, garantizando compatibilidad entre navegadores.  
- Documentar con **comentarios breves y claros** cada sección del código.  
- Mantener un formato limpio evitando líneas demasiado extensas o espacios innecesarios.  
- Incluir elementos esenciales como `<title>`, `<html>`, `<head>` y `<body>`.  
- Definir el idioma del contenido con el atributo `lang` en la etiqueta `<html>`.  
- Añadir atributos como `alt`, `width` y `height` en imágenes para mejorar la accesibilidad y la experiencia de usuario.  
- Usar la metaetiqueta `<meta name="viewport">` para asegurar la correcta visualización en dispositivos móviles.  

#### CSS (Cascading Style Sheets)
CSS en **InventaTrack** se utiliza para dar un diseño moderno y profesional, priorizando la usabilidad y la experiencia del usuario. Las convenciones aplicadas incluyen:  

- Nomenclatura clara y coherente para clases e identificadores, lo que facilita la colaboración.  
- Indentación uniforme y uso de espacios adecuados para mantener un código legible.  
- Comentarios que expliquen la lógica de bloques de estilos o secciones clave.  
- Agrupar propiedades relacionadas para mantener orden en las hojas de estilo.  
- Evitar selectores demasiado específicos que dificulten la escalabilidad del proyecto.  
- Probar los estilos en distintos navegadores y dispositivos para asegurar consistencia visual.  
- Optimizar el código reduciendo duplicidades y validarlo con herramientas como el validador de **W3C**.  

#### JavaScript
JavaScript en **InventaTrack** permite implementar las funcionalidades dinámicas del sistema, como alertas de vencimiento o validaciones en formularios. Las buenas prácticas adoptadas son:  

- Usar una nomenclatura consistente para variables, funciones y objetos.  
- Aplicar una indentación clara y usar espacios adecuados después de palabras clave (`if`, `for`, `function`).  
- Incluir comentarios que describan la lógica de cada sección del código.  
- Minimizar el uso de variables globales, favoreciendo el uso de contextos locales.  
- Implementar mecanismos de manejo de errores (`try-catch`) para garantizar robustez.  
- Optimizar el rendimiento con técnicas como caché y minimización de scripts.  
- Realizar pruebas cruzadas en diferentes navegadores y dispositivos.  

#### Gherkin
Para las pruebas de comportamiento de **InventaTrack**, se utiliza el lenguaje **Gherkin**, asegurando que los escenarios sean claros y entendibles por todo el equipo:  

- Redactar escenarios simples y legibles, alineados con los requisitos del negocio.  
- Mantener la estructura estandarizada con palabras clave como `Feature`, `Scenario`, `Given`, `When`, `Then` y `And`.  
- Especificar claramente el **estado inicial**, las acciones y los resultados esperados.  
- Reutilizar pasos comunes con `And` para evitar redundancias.  
- Mantener escenarios enfocados en una funcionalidad concreta.  
- Usar comentarios solo cuando sea necesario para añadir contexto adicional.  
- Revisar escenarios en equipo para validar su alineación con los objetivos de InventaTrack.  
