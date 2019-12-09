using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Controller : MonoBehaviour
{
	public float speed = 0.2f;
	public KeyCode upButton;
	public KeyCode downButton;
	public KeyCode leftButton;
	public KeyCode rightButton;
	
   
    void Update()
    {
        if(Input.GetKey(upButton)){
			transform.position = new Vector3(transform.position.x,transform.position.y+speed,transform.position.z);
		}
		if(Input.GetKey(downButton)){
			transform.position = new Vector3(transform.position.x,transform.position.y-speed,transform.position.z);
		}
		if(Input.GetKey(leftButton)){
			transform.position = new Vector3(transform.position.x-speed,transform.position.y,transform.position.z);
		}
		if(Input.GetKey(rightButton)){
			transform.position = new Vector3(transform.position.x+speed,transform.position.y,transform.position.z);
		}
    }
}