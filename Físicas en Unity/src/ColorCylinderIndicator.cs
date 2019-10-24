using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCylinderIndicator : MonoBehaviour
{
    
    private float dist; 

    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision collision){

        GetComponent<Renderer>().material.color = Color.yellow;

        //renderer.material.Color = Color.
    }

    void OnCollisionStay(Collision collision){

        GetComponent<Renderer>().material.color = Color.red;

    }

    
    void OnCollisionExit(Collision collision){

        GetComponent<Renderer>().material.color = Color.white;
    }

}
