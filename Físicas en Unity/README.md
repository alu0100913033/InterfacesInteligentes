# Físicas en Unity
*Tomás González Martín*  
alu0100913033@ull.edu.es

## Funcionamiento del script
Se disponen de 3 Scripts:
* CollisionTest: Detecta cada una de las colisiones, y por cada una incrementa un contador.
* ColorCylinderIndicator: Implementa las funciones *OnCollisionX*, para modificar el color del Component en función del estado de la colisión. Los colores usados son Rojo, amarillo y blanco en las distintas faces de colisión.
* SpecialCharacterController: Define los movimientos de un objeto, cuya estructura es similar al script visto en la tarea de [Introducción a los scripts de Unity](https://github.com/alu0100913033/InterfacesInteligentes/blob/master/Introducci%C3%B3n%20a%20los%20scripts%20en%20Unity/src/CharacterController.cs), pero modificando las teclas de interactuación.

## Demostración de funcionamiento
![gif](img/gif.gif)