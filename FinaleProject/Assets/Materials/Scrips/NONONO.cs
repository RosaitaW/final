using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NONONO : MonoBehaviour
{
    //public GameObject destroyThis;
    public GameObject startgame;
    public GameObject ExitGame;
    public Text Nogame;
    public Text StartButton;
    public string nonono;
    public string Start1;
    public string Start2;
    public string Startfinal;
    public bool start = false;
    public bool StarT = false;
    public bool START = false;
    public bool OpenGame = false;

    void Start()
    {
        //if (Nowspawn)
        //{//
            //InvokeRepeating("SpawnButtonPlay", SpawnPlayTime, SpawnPlayTime);
            //InvokeRepeating("SpawnButtonExit", SpawnExitTime, SpawnExitTime);
        //}//

    }
    public void StartGame()
    {
        Nogame.text = nonono;
        if (!start && !StarT && !START)
        {
            start = true;
            StartButton.text = Start1;
            startgame.transform.position = new Vector2(Random.Range(200, 800), Random.Range(100, 400));
            print("1!");
            if (startgame.transform.position.x <= -100)
            {
                startgame.transform.position = new Vector2(Random.Range(200, 800)+400, Random.Range(100, 400));
            }
            if (startgame.transform.position.y <= 0)
            {
                startgame.transform.position = new Vector2(Random.Range(200, 800), Random.Range(100, 400) + 400);
            }

        }
        else if (start && !StarT && !START)
        {
            StarT = true;
            StartButton.text = Start2;
            startgame.transform.position = new Vector2(Random.Range(-200, 200), Random.Range(-100, 100));
            print("2!");
            if (startgame.transform.position.x <= -100)
            {
                startgame.transform.position = new Vector2(Random.Range(200, 800) + 400, Random.Range(100, 400));
            }
            if (startgame.transform.position.y <= 0)
            {
                startgame.transform.position = new Vector2(Random.Range(200, 800), Random.Range(100, 400) + 400);
            }
        }
        else if (start&&StarT&&!START) {
            START = true;
            StartButton.text = Startfinal;
            startgame.transform.position = new Vector2(Random.Range(-200, 200), Random.Range(-100, 100));
            print("3!");
            if (startgame.transform.position.x <= -100)
            {
                startgame.transform.position = new Vector2(Random.Range(200, 800) + 400, Random.Range(100, 400));
            }
            if (startgame.transform.position.y <= 0)
            {
                startgame.transform.position = new Vector2(Random.Range(200, 800), Random.Range(100, 400) + 400);
            }
        }
        else if (start && StarT && START) {
            OpenGame = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Change to another scene
        }
    }
}