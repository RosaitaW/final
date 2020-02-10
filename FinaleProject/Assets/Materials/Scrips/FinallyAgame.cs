using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinallyAgame : MonoBehaviour
{
    public Text YouwinText;
    public Text ButtonNoText;
    public Text ButtonYayText;
    public GameObject destroy;
    public GameObject destroyNo;
    public string Yay;
    public string No1;
    public string No2;
    public string Okay;
    public string No1text;
    public string No2text;
    public string YayText;
    public bool YayGame = false;
    public bool no1 = false;
    public bool no2 = false;
    //public bool no3 = false;
    // Start is called before the first frame update

    public void Playgame()
    {
        if (!YayGame)
        {
            print("Yay! Play a Game!");
            YouwinText.text = YayText;
            ButtonYayText.text = Yay;
            Object.Destroy(destroyNo);
            YayGame = true;
        }
        else
        {
            print("Game started!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void Iquit()
    {
        Object.Destroy(destroy);
        if (!no1 && !no2)
        {
            print("Enough for game!");
            YouwinText.text = No1text;
            ButtonNoText.text = No1;
            no1 = true;
        }
        else if (no1 && !no2)
        {
            print("I said no game!");
            YouwinText.text = No2text;
            ButtonNoText.text = No2;
            no2 = true;
        }
        else if (no1 && no2)
        {
            print("Okay? ");
            YouwinText.text = YayText;
            ButtonNoText.text = Okay;
            
            if (!YayGame)
            {
                YayGame = true;
            }
            else
            {
                print("Game started!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        /*else if (no1 && no2 && no3)
        {
            ButtonNoText.text =Yay;
            if (!YayGame)
            {
                YayGame = true;
            }
            else
            {
                print("Game started!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }*/

    }
}
