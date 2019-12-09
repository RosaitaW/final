using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public enum Movement_Type{
        Straight, Sin, Circle, Random,Noise
    }
    public Movement_Type movement;
    public float timer = 0;
    public float freq = 1.0f;
    public float amp = 1;
    public GameObject movingthing;
    //public float modY = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        switch (movement) {
            case Movement_Type.Straight:
                transform.Translate(new Vector3(Time.deltaTime, 0, 0));
                break;
            case Movement_Type.Sin:
                transform.Translate(new Vector3(transform.position.x + Time.deltaTime, Mathf.Sin(transform.position.x * freq) * amp, 0));
                break;
            case Movement_Type.Circle:
                transform.position = new Vector3(Mathf.Sin(transform.position.x * freq) * amp, Mathf.Cos(transform.position.x * freq) * amp, 0);
                break;
            case Movement_Type.Random:
                transform.position = new Vector3(transform.position.x + Time.deltaTime, Random.Range(-0.01f, 0.01f), 0);
                break;
            case Movement_Type.Noise:
                transform.position = new Vector3(transform.position.x + Time.deltaTime,Mathf.PerlinNoise(transform.position.x,0)*amp, 0);
                break;
            default:
                Debug.Log("Sth's wrong with Movement_Type");
                break;
        }
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-9, transform.position.x, 0);
        }
        /*
        if (movement == Movement_Type.Straight)
        {
            transform.Translate(new Vector3(Time.deltaTime, 0, 0));
        }
        else if (movement == Movement_Type.Sin)
        {
            transform.Translate(new Vector3(transform.position.x + Time.deltaTime, Mathf.Sin(transform.position.x * freq) * amp, 0));
        }
        else if (movement == Movement_Type.Circle)
        {
            transform.position = new Vector3(Mathf.Sin(transform.position.x * freq) * amp, Mathf.Cos(transform.position.x * freq) * amp, 0);
        }*/
        //transform.Translate(new Vector3(Time.deltaTime,Time.deltaTime*5,0));

    }
}
