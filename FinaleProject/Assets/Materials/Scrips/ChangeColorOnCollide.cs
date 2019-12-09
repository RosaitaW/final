using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCollide : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //when colliding with another gameObject
    private void OnCollisionEnter(Collision collision)
    {
        print("touched");
        GameObject other = collision.gameObject; //get the other gameObject

        //ColorChanger changer = other.GetComponent<ColorChanger>(); //get the ColorChange component from that object

        ColorChanger changer = GetComponent<ColorChanger>();

        Rigidbody rb = other.GetComponent<Rigidbody>(); //get the rigidBody from the other gameObject

        rb.AddForce(new Vector3(0, 300, 0)); //add some force to the other gameObject's rigidBody

        if (changer != null) //if the other object has a ColorChanger component
        {
            changer.ChangeColor(); //call the colorChanger's ChangeColor function
        }
    }
}
