# Físicas en Unity
*Tomás González Martín*  
alu0100913033@ull.edu.es

## Funcionamiento del script
Se disponen de 3 Scripts:
* [CollisionTest](https://github.com/alu0100913033/InterfacesInteligentes/blob/master/F%C3%ADsicas%20en%20Unity/src/CollisionTest.cs): Detecta cada una de las colisiones, y por cada una incrementa un contador.
* [ColorCylinderIndicator](https://github.com/alu0100913033/InterfacesInteligentes/blob/master/F%C3%ADsicas%20en%20Unity/src/ColorCylinderIndicator.cs): Implementa las funciones *OnCollisionX*, para modificar el color del Component en función del estado de la colisión. Los colores usados son Rojo, amarillo y blanco en las distintas faces de colisión.
* [SpecialCharacterController](https://github.com/alu0100913033/InterfacesInteligentes/blob/master/F%C3%ADsicas%20en%20Unity/src/SpecialCharacterController.cs): Define los movimientos de un objeto, cuya estructura es similar al script visto en la tarea de [Introducción a los scripts de Unity](https://github.com/alu0100913033/InterfacesInteligentes/blob/master/Introducci%C3%B3n%20a%20los%20scripts%20en%20Unity/src/CharacterController.cs), pero modificando las teclas de interactuación. Además de ello, no se desplaza modificando su posición, sino utilizando el *Rigidbody* para aplicarle una fuerza con un determinado empuje.

## Demostración de funcionamiento
![gif](img/gif.gif)