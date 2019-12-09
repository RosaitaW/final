using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDWithPhysic : MonoBehaviour
{
    public float force = 0.1f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool hasInput = false; 

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 0, force);
            hasInput = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, -force);
            hasInput = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector3(-force, 0, 0);
            hasInput = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector3(force, 0, 0);
            hasInput = true;
        }

        if(!hasInput){
            //rb.velocity = new Vector3(0, 0, 0);
            rb.velocity = rb.velocity * 0.98f;
        }
    }
}
