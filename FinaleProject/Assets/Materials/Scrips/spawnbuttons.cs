using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class spawnbuttons : MonoBehaviour
{
    public GameObject startgame;
    public GameObject quitgame;
    public Text Nogame;
    public float SpawnPlayTime = 1.0f;
    public float SpawnExitTime = 0.2f;
    public float speedmin = 5f;
    public float speedmax = 10f;
    public void SpawnbuttonPlay()
    {
        int spawnPointPlayX = Random.Range(-300, 300);
        //int spawnPointPlayY = Random.Range(300, 500);
        Vector2 spawnPlayPosition = new Vector2(spawnPointPlayX, transform.position.y);
        Instantiate(startgame, spawnPlayPosition, Quaternion.identity);
        
    }
    public void SpawnbuttonExit()
    {
        int spawnPointExitX = Random.Range(-300, 300);
        //int spawnPointExitY = Random.Range(300, 500);
        Vector2 spawnExitPosition = Nogame.transform.position;
        Instantiate(quitgame, spawnExitPosition, transform.rotation);
        

    }

    void Start()
    {
        InvokeRepeating("SpawnButtonPlay", SpawnPlayTime, SpawnPlayTime);
        InvokeRepeating("SpawnButtonExit", SpawnExitTime, SpawnExitTime);
    }
    void Update()
    {
        startgame.transform.position = new Vector2(transform.position.x, transform.position.y - (Random.Range(speedmin, speedmax) * Time.deltaTime));
        quitgame.transform.position = new Vector2(transform.position.x, transform.position.y - (Random.Range(speedmin, speedmax) * Time.deltaTime));
    }

}
