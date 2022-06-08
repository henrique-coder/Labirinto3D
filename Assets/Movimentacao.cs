using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public Vector3 rm;
    public float veloc = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        rm.x = 0.0f;
        rm.y = 0.0f;
        rm.z = 0.0f;


    }
    void mover(Vector3 rm)
    {

        transform.Translate(rm);

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W)) 
        {

            rm.x = veloc;
            mover(rm);
            rm.x = 0.0f;

        }

        if (Input.GetKey(KeyCode.S)) 
        {

            rm.x = -veloc;
            mover(rm);
            rm.x = 0.0f;

        }

        if (Input.GetKey(KeyCode.A)) 
        {

            rm.z = veloc;
            mover(rm);
            rm.z = 0.0f;

        }

        if (Input.GetKey(KeyCode.D)) 
        {

            rm.z = -veloc;
            mover(rm);
            rm.z = 0.0f;

        }

    }
}
