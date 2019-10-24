using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{

    public int counterCollision = 0;
    // Start is called before the first frame update

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Cube")
        {
            counterCollision++;
        }
    }
}
