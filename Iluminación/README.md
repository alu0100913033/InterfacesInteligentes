# Iluminación
*Tomás González Martín*  
alu0100913033@ull.edu.es
## Descripción de la tarea
Busca información sobre los siguiente términos, explica brevemente en qué consisten. Determina para cada uno de ellos, alguna vía de incorporarlo en tu proyecto.

* Light mapping: Es el proceso de precalcular el brillo en una escena y guardar el resultado en un *light map* para usarlo luego.  
* Bump mapping: Se trata de un tipo de textura especial que permite añadir detalles a la superficie como golpes, surcos y rasguños a un modelo que toma la luz como se representa en la geometría real.
* Normal mapping: Es otra forma de referirse a *bump mapping*. Sin embargo, realmente se refiere a que el ángulo de la superficie se puede representar como una línea saliente en una dirección perpendicular de dicha superficie.
* Sky box: Se tratan de una envoltura que emerge alrededor de la escena entera, cuyo objetivo es mostrar cómo se vería el mundo más allá de su geometría. Típicamente es utilizado, como su nombre indica, para la representación de *cielos* o entornos.
* Environment mapping: colección de seis texturas cuadradas que representan las reflexiones sobre un entorno. Los seis cuadrados forman las caras de un cubo imaginario que rodea a un un objeto; cada cara representa la vista hacia las direcciones de los ejes del mundo (arriba, abajo, izquierda, derecha, adelante y atrás).
* Iluminación global: es un sistema que modela cómo la luz rebota de superficies a otras superficies (luz indirecta) en vez de estar limitada a la luz que golpea una superficie directamente desde una fuente de luz (luz directa). Modela la luz indirecta permite efectos que hacen que el mundo virtual se vea más real y conectado, ya que los objetos afectan la apariencia de cada uno.

## Vías de adición al proyecto
* Light mapping: Dado que se trata de un mapa estático, se puede utilizar previo al inicio para simplificar la renderización.
* Bump mapping: Dada la entrada de luz del exterior a través de las ventanas, aumentará el realismo el escenario del juego.
* Normal mapping: Aquellas zonas poco visibles ahorrarán en gasto de renderizado.
* Sky box: Crear el entorno que se vea de fuera de las ventanas de la clase.
* Environment mapping: 
* Iluminación global: Añadirá las luces necesarias al entorno para que sea visible "a primeras horas de la mañana" sin necesidad de púramente la luz del sol.