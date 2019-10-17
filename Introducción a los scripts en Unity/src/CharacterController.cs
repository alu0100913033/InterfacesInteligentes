using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float moveSpeed;
    public float rotationSpeed;
    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 20;
        rotationSpeed = 20;
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Por algún motivo falla con el pad

        // Desplazamiento del cubo utilizando asdw
        if (Input.GetKey(KeyCode.W))
            tr.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.S))
            tr.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.A))
            tr.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            
        if(Input.GetKey(KeyCode.D))
            tr.Translate(Vector3.right * moveSpeed * Time.deltaTime);


        // Rotación del objeto utilizando qe
        if (Input.GetKey(KeyCode.Q))
            tr.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.E))
            tr.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
    }
}
