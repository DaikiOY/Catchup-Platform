## Configuraciones de Despliegue del Proyecto

Para la publicación en línea de **InventaTrack**, se implementó un proceso de despliegue moderno y automatizado utilizando **Netlify** como plataforma principal de hosting y **GitHub** como gestor central del código fuente. Esta configuración permite mantener un flujo de integración y entrega continua (CI/CD) que asegura la disponibilidad y actualización constante de los productos digitales del proyecto.

### Proceso de Despliegue

1. **Integración con Repositorios Git**  
   Los repositorios de **InventaTrack** están alojados en GitHub. Netlify se enlaza directamente con estos repositorios, lo que permite que, cada vez que se registra un nuevo commit o se actualiza una rama, se inicie automáticamente el proceso de construcción del sitio.

2. **Compilación Automatizada**  
   Durante el proceso de build, Netlify transforma el código fuente (HTML, CSS, JavaScript, TypeScript) en una versión optimizada y lista para producción. Este proceso incluye:  
   - Minificación de archivos.  
   - Optimización de recursos estáticos (imágenes, fuentes).  
   - Generación de un sitio seguro y compatible con múltiples navegadores.  

3. **Despliegue en Red CDN**  
   Una vez completada la compilación, el contenido de **InventaTrack** se despliega en una **red global de entrega de contenido (CDN)**, lo que garantiza tiempos de carga rápidos y disponibilidad del sistema en cualquier parte del mundo.

4. **Vistas Previas por Rama**  
   Netlify genera automáticamente una **versión previa del sitio para cada rama o Pull Request**, lo que facilita al equipo revisar los cambios antes de su integración. Esto mejora el trabajo colaborativo y permite detectar errores en etapas tempranas.

5. **Despliegue Continuo**  
   Cuando una rama es fusionada con la rama principal (`main`), Netlify actualiza el entorno productivo de forma automática. De esta manera, los usuarios siempre interactúan con la versión más reciente y estable del sistema.

### Productos Desplegados

- **Landing Page de InventaTrack**: publicada directamente en Netlify con integración desde GitHub.  
- **Frontend Web Application**: desplegada en Netlify para garantizar rapidez y escalabilidad.  
- **Servicios Backend**: configurados para desplegarse en una plataforma complementaria (ej. Render/Heroku/AWS), asegurando la integración con el frontend y la correcta gestión de datos.

---

Este esquema de despliegue ha permitido a **InventaTrack** contar con un proceso confiable, automatizado y escalable, asegurando que cada actualización del código fuente se refleje de manera inmediata en los entornos de prueba y producción.
