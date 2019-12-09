using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    public Vector3[] points;//From one point to another
    public int point_number = 0;
    private Vector3 currentTarget;//Where to go

    public float tolerance;
    public float platformspeed;//Moving speed
    public float delay_time;//Just in case

    private float delay_start;
    public bool automatic;//Automatic

    // Start is called before the first frame update
    void Start()
    {
        if (points.Length > 0)
        {
            currentTarget = points[0];
        }
        tolerance = platformspeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != currentTarget)
        {
            MovePlatform();
        }
        else {
            UpdateTarget();
        }
    }

    void MovePlatform()
    {
        Vector3 heading = currentTarget - transform.position;
        transform.position += (heading / heading.magnitude) * platformspeed * Time.deltaTime;
        if(heading.magnitude<tolerance)
        {
            transform.position = currentTarget;
            delay_start = Time.time;
        }
    }
    void UpdateTarget()
    {
        if (automatic)
        {
            if (Time.time - delay_start > delay_time)
            {
                NextPlatform();
            }
        }
    }
    public void NextPlatform()
    {
        point_number++;
        if (point_number >= points.Length) {
            point_number = 0;
        }
        currentTarget = points[point_number];
    }
}
