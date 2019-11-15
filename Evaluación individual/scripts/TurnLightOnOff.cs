using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOnOff : MonoBehaviour
{

    public delegate void turnLight();
    public event turnLight switchLight;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "AreaLightTrigger")
        {
            
            if (Input.GetKeyDown(KeyCode.Q))
            {
                
                if (switchLight != null)
                {
                    switchLight();
                }
            }
        }
    }
}
