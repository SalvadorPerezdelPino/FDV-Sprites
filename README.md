# FDV-Sprites
## Ejercicios
> Agregar el atlas de sprites del personaje a la escena. Configurar el sprite como múltiple y subdividirlo para tener acceso a los sprites para generar las animaciones. Agregar una de las imágenes a la escena.

![Importación](./media/importacion.png)
Al importarlo, automáticamente se ha detectado que es una hoja de múltiples sprites y los ha subdividido correctamente. Colocando un sprite en escena se ve de la siguiente manera:
![Colocación en escena](./media/colocacion_escena.png)

> Creamos un objeto 2D, arrastrando un conjunto de imágenes que selecciones al objeto añadiremos una animación. Agregar al personaje la animación “Walk Down” . Añadir otra imagen y generarle otra animación.  De esa forma Unity crea un objeto Animation, la primera vez que se crea, también añade un objeto Animator Controller.

Se ha creado la animación Walk Down y asignado al personaje de la izquierda. Después, se ha creado otra animación Back y se ha asignado al personaje de la derecha. Cada uno tiene un controller diferente porque se han creado las animaciones en objetos diferentes.
![Animaciones](./media/animation.gif)