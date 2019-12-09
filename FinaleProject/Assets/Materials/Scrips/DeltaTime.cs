using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeltaTime : MonoBehaviour
{
    public Text deltaTimerText;
    public float deltaTimer = 180;
    // Start is called before the first frame update
    void Start()
    {
        deltaTimerText.text = "1";
    }

    // Update is called once per frame
    void Update()
    {
        deltaTimer -= Time.deltaTime;
        deltaTimerText.text = "Time:" + deltaTimer;
        print("DeltaTime: "+Time.deltaTime);

        /*if (deltaTimer < 300 && deltaTimer>60) {
            print("Time's running out");
        }*/

        if (deltaTimer <= 0)
        {
            print("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        
    }
}
