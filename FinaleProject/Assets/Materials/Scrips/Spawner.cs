using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   public GameObject items;
    public float spawnTime = 5f;
    public float spawnTimeMin = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawn", spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

 
    void spawn()
    {
        Instantiate(items, transform.position, transform.rotation);
        spawnTime = spawnTime - 0.3f;

        if (spawnTime < spawnTimeMin)
        {
            spawnTime = spawnTimeMin;
        }

        Invoke("spawn", spawnTime);
    }
}
