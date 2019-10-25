using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCharacterController : ColorCylinderIndicator
{

    public float thrust;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        thrust = 20;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void FixedUpdate(){
        // Por algún motivo falla con el pad

        // Desplazamiento del cubo utilizando iljm
        if (Input.GetKey(KeyCode.I))
            rb.AddForce(transform.forward * thrust);
        
        if(Input.GetKey(KeyCode.M))
            rb.AddForce(-transform.forward * thrust);
        
        if(Input.GetKey(KeyCode.J))
            rb.AddForce(-transform.right * thrust);
            
        if(Input.GetKey(KeyCode.L))
            rb.AddForce(transform.right * thrust);

    }
}
