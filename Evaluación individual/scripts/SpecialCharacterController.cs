using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCharacterController : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(transform.forward * thrust);
        
        if(Input.GetKey(KeyCode.S))
            rb.AddForce(-transform.forward * thrust);
        
        if(Input.GetKey(KeyCode.A))
            rb.AddForce(-transform.right * thrust);
            
        if(Input.GetKey(KeyCode.D))
            rb.AddForce(transform.right * thrust);

    }
}
