using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pillarSinkScript : MonoBehaviour
{
    public GameObject ball;
    public float sinkingspeed=0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.95)
        {
            print("You ruined the game!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - sinkingspeed, transform.position.z);
    }
}
