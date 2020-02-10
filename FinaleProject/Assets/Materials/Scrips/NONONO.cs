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
    public float positionxmin = 1f;
    public float positionxmax = 400f;
    public float positionymin = 1f;
    public float positionymax = 100f;
    public string nonono;
    public string Start1;
    public string Start2;
    public string Startfinal;
    public string StartFinally;
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
            startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax), Random.Range(positionymin, positionymax));
            print("1!");
            if (startgame.transform.position.x <= 100)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax) + 400, Random.Range(positionymin, positionymax));
            }
            if (startgame.transform.position.y <= 20)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax), Random.Range(positionymin, positionymax) + 400);
            }
            if (startgame.transform.position.x >= 800)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax) - 400, Random.Range(positionymin, positionymax));
            }
            if (startgame.transform.position.y >= 500)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax), Random.Range(positionymin, positionymax) - 400);
            }

        }
        else if (start && !StarT && !START)
        {
            StarT = true;
            StartButton.text = Start2;
            startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax), Random.Range(100, 400));
            print("2!");
            if (startgame.transform.position.x <= 100)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax) + 400, Random.Range(positionymin, positionymax));
            }
            if (startgame.transform.position.y <= 20)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax), Random.Range(positionymin, positionymax) + 400);
            }
            if (startgame.transform.position.x >= 800)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax) - 400, Random.Range(positionymin, positionymax));
            }
            if (startgame.transform.position.y >= 500)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax), Random.Range(positionymin, positionymax) - 400);
            }
        }
        else if (start && StarT && !START)
        {
            START = true;
            StartButton.text = Startfinal;
            startgame.transform.position = new Vector2(Random.Range(200, 500), Random.Range(100, 400));
            print("3!");
            if (startgame.transform.position.x <= 100)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax) + 400, Random.Range(positionymin, positionymax));
            }
            if (startgame.transform.position.y <= 20)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax), Random.Range(positionymin, positionymax) + 400);
            }
            if (startgame.transform.position.x >= 800)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax) - 400, Random.Range(positionymin, positionymax));
            }
            if (startgame.transform.position.y >= 500)
            {
                startgame.transform.position = new Vector2(Random.Range(positionxmin, positionxmax), Random.Range(positionymin, positionymax) - 400);
            }
        }
        else if (start && StarT && START)
        {
            StartButton.text = StartFinally;
            if (!OpenGame)
            {
                OpenGame = true;
            }
            else
            {
                print("Finally! ");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Change to another scene
            }
        }
    }
}