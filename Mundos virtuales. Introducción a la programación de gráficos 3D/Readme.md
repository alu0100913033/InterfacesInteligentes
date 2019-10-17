# Mundos virtuales. Introducción a la programación de gráficos 3D.
## Responde a las siguiente cuestiones:
### **1. Qué funciones se pueden usar en los scripts de Unity para llevar a cabo traslaciones, rotaciones y escalados.**  
Translate, Rotate y localScale  
### **2. ¿Cómo duplicarías el tamaño de un objeto en en un script?.**
Con el uso de localScale de transform
```
transform.localScale += new Vector3(2, 2, 2);
```
### **3. Cómo situarías un objeto en la posición (3,5,1.)**  
Redefiniendo la posición:
```
transform.position = new Vector3(3, 5, 1);
```

### **4. Como trasladarías 3 metros en cada uno de los ejes y luego lo rotas 30º alrededor del eje Y?**
En dos pasos: Primero realizamos un desplazamiento de esos 3 metros  
```
transform.Translate(Vector3.one * 3 * Time.deltaTime);
```
Luego, con respecto a la rotación sobre el eje Y:  
```
transform.Rotate(0, 30, 0, Space.Self);
```

### **5 Como rotarías un objeto sobre el eje (1,1,1)**
Primero nos situamos sobre el eje (1,1,1) redefiniendo la posición.  
```
transform.position = new Vector3(1, 1, 1);
```
Aplicamos una rotación sobre sí mismo.  

```
transform.Rotate(X, Y, Z, Space.Self);
```
siendo X, Y, Z, ángulos dados en grados.

### **6. Rota un objeto alrededor del eje Y 30º y desplázalo 3 metros en cada uno de los ejes. ¿Obtendrías el mismo resultado que en 4?**
No, ya que el desplazamiento de 3 metros depende de la orientación que presenta el eje de coordenadas. Al realizar primero la rotación, se cambia la orientación del objeto.

### **7. ¿Cómo puede obtener la distancia al plano cerca del volumen de vista?**



### **8. ¿Cómo puede realizar una proyección al espacio 2D?**
  

### **9. Investiga qué son los quaternion.**
Los Quaterniones son una extensión de los números reales, similar a los complejos. Son utilizados para representar rotaciones en Unity.

### **10.Analiza la documentación de la cámara en Unity e identifica los conceptos explicados respecto a la cámara.**
 * Perspectiva: distancia de los objetos representada como variación de tamaño.
 * Ortografía: cámara que no disminuye el tamaño de los objetos.  
  
Estos modos de "ver" en Unity son conocidos como *proyecciones*.  
  
  * Plano de delimitación lejano: Límite de qué tan lejos puede "ver" la cámara desde la posición actual.
  
Existen muchos más conceptos muy bien explicandos dentro de la documentación de Unity, y para evitar redundancias, es mejor que se consulte el mismo.
  
### **11. ¿Cómo puedes averiguar la matriz de proyección que se ha usado para proyectar la escena al último frame renderizado?**  
La matriz de proyección puede ser obtenida de la cámara de la siguiente forma:  
```
cam = GetComponent<Camera>();
MatrixDeProyeccion = cam.projectionMatrix;
```

### **12. ¿Cómo puede obtener la matriz de transformación entre el sistema de coordenadas local y el mundial?**
