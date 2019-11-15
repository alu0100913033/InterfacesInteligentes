using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingForPlayerObjectCollisions : MonoBehaviour
{
    
    delegate void MyDelegate(int num);
    MyDelegate myDelegate;

    // public Transform player;

    public GameObject player;
    public GameObject[] objectsA;
    public GameObject[] objectsB;
    public GameObject[] objectsC;

    private System.Random randomScale;

    private void Awake()
    {
        player.GetComponent<GameObjectPower>().onRecolecta += actualizador;
        player.GetComponent<GameObjectPower>().onRecolecta += modificarA;
    }

    // Start is called before the first frame update
    void Start()
    {
        randomScale = new System.Random();

        objectsB = GameObject.FindGameObjectsWithTag("ObjectB");

    }

    void actualizador(int valor)
    {
        player.GetComponent<GameObjectPower>().power += valor;
    }




    void modificarA(int intensidad){
        objectsA.GetComponent<CapsuleCollider>()

    }


    void transformador()
    {
        
        bool xAxis = true;
        bool yAxis = true;
        bool zAxis = true;

        int scale = randomScale.Next(2);
        if (scale == 1)
        {
            xAxis = false;
        }
        scale = randomScale.Next(2);
        if (scale == 1)
        {
            yAxis = false;
        }
        scale = randomScale.Next(2);
        if (scale == 1)
        {
            zAxis = false;
        }

        scale = randomScale.Next(4);

        foreach (GameObject objectB in objectsB)
        {
            if (xAxis)
            {
                objectB.transform.localScale = new Vector3(objectB.transform.localScale.x / (scale - 0.5f), objectB.transform.localScale.y, objectB.transform.localScale.z);
                objectB.GetComponent<CapsuleCollider>().transform.localScale = new Vector3(objectB.transform.localScale.x / (scale - 0.5f), objectB.transform.localScale.y, objectB.transform.localScale.z);
            }
            if (yAxis)
            {
                objectB.transform.localScale = new Vector3(objectB.transform.localScale.x, objectB.transform.localScale.y / (scale - 0.5f), objectB.transform.localScale.z);
                objectB.GetComponent<CapsuleCollider>().transform.localScale = new Vector3(objectB.transform.localScale.x, objectB.transform.localScale.y / (scale - 0.5f), objectB.transform.localScale.z);
            }
            if (zAxis)
            {
                objectB.transform.localScale = new Vector3(objectB.transform.localScale.x, objectB.transform.localScale.y, objectB.transform.localScale.z / (scale - 0.5f));
                objectB.GetComponent<CapsuleCollider>().transform.localScale = new Vector3(objectB.transform.localScale.x, objectB.transform.localScale.y, objectB.transform.localScale.z / (scale - 0.5f));
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
