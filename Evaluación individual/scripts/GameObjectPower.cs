using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectPower : MonoBehaviour
{

    public int power;

    public delegate void Disparo();
    public event Disparo realizaDisparo;

    public delegate void ActualizaRecolecta(int valor);
    public event ActualizaRecolecta onRecolecta;

    public delegate void ActualizaObjectB();
    public event ActualizaObjectB onObjectB;

    // Start is called before the first frame update
    void Start()
    {
        power = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ObjectA")
        {
            if (onRecolecta != null)
            {
                onRecolecta(1);
            }
        }

        if (collision.gameObject.tag == "ObjectB")
        {
            if (onRecolecta != null)
            {
                onRecolecta(-1);
                
            }
            if (onRecolecta != null) {
                onObjectB();
            }


            
        }


        if (collision.gameObject.tag == "EnergyPoint")
        {
            if (onRecolecta != null)
            {
                onRecolecta(20);
            }
        }
    }






}
