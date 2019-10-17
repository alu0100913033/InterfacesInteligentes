# Mundos virtuales. Introducción a la programación de gráficos 3D.
## Responde a las siguiente cuestiones:
**1. Qué funciones se pueden usar en los scripts de Unity para llevar a cabo traslaciones, rotaciones y escalados.**  
Translate, Rotate y localScale  
**2. ¿Cómo duplicarías el tamaño de un objeto en en un script?.**
Con el uso de localScale de transform
```
transform.localScale += new Vector3(2, 2, 2);
```
**3. Cómo situarías un objeto en la posición (3,5,1.)**  
Redefiniendo la posición:
```
transform.position = new Vector3(3, 5, 1);
```

**4. Como trasladarías 3 metros en cada uno de los ejes y luego lo rotas 30º alrededor del eje Y?**
