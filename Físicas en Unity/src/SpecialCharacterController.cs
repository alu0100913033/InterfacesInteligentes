using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCharacterController : ColorCylinderIndicator
{

    public float moveSpeed;
    public float rotationSpeed;
    private Transform tr;
    

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 20;
        rotationSpeed = 100;
        tr = GetComponent<Transform>();

        tr.Translate(Vector3.one * 3 * Time.deltaTime);
        tr.Rotate(0, 30, 0, Space.Self);

    }

    // Update is called once per frame
    void Update()
    {
        // Por algún motivo falla con el pad

        // Desplazamiento del cubo utilizando iljm
        if (Input.GetKey(KeyCode.I))
            tr.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.M))
            tr.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.J))
            tr.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            
        if(Input.GetKey(KeyCode.L))
            tr.Translate(Vector3.right * moveSpeed * Time.deltaTime);


    }
}
