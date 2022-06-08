using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao : MonoBehaviour
{

    public float sens = 1.9f;
    public float mx = 0.0f;
    public float my = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        mx += Input.GetAxis("Mouse X") * sens;
        transform.eulerAngles = new Vector3(0,mx,0);
        
    }
}
