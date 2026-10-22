# FDV-Sprites
## Ejercicios
> Agregar el atlas de sprites del personaje a la escena. Configurar el sprite como múltiple y subdividirlo para tener acceso a los sprites para generar las animaciones. Agregar una de las imágenes a la escena.

![Importación](./media/importacion.png)
Al importarlo, automáticamente se ha detectado que es una hoja de múltiples sprites y los ha subdividido correctamente. Colocando un sprite en escena se ve de la siguiente manera:
![Colocación en escena](./media/colocacion_escena.png)

> Creamos un objeto 2D, arrastrando un conjunto de imágenes que selecciones al objeto añadiremos una animación. Agregar al personaje la animación “Walk Down” . Añadir otra imagen y generarle otra animación.  De esa forma Unity crea un objeto Animation, la primera vez que se crea, también añade un objeto Animator Controller.

Se ha creado la animación Walk Down y asignado al personaje de la izquierda. Después, se ha creado otra animación Back y se ha asignado al personaje de la derecha. Cada uno tiene un controller diferente porque se han creado las animaciones en objetos diferentes.
![Animaciones](./media/animation.gif)

> Creamos los scripts para controlar el movimiento para el personaje. Inicialmente vamos a hacer una versión sin salto. Añadir los scripts necesarios para moverlo por la pantalla. En este caso sólo tendremos que mover las coordenadas (X, Y).  El movimiento de derecha a izquierda lo logramos modificando transform.position(x, y), para ello podemos usar transform.Translate(avance, 0).

> Controlar el movimiento por teclado: el avance se produce si el jugador ha pulsado las teclas flecha izquierda o flecha derecha.

> Necesitarás las instrucciones:
float horizontalInput = Input.GetAxis("Horizontal");
Vector2 movement = new Vector2(horizontalInput, 0f); 
transform.Translate(movement * speed * Time.deltaTime);

En este caso, combino los apartados 3, 4 y 5 porque de costumbre suelo configurar el input system nuevo al realizar desplazamientos para que sea más cómodo y sencillo.

![Input Actions](./media/input_actions.png)

Tras configurar las acciones, utilizando el siguiente script desplazo al personaje:
```cs
void Update()
{
    movement = new Vector2(moveAction.action.ReadValue<float>(), 0f); 
    transform.Translate(movement * Time.deltaTime * speed);
}
```
![Movimiento](./media/move_sprite.gif)
