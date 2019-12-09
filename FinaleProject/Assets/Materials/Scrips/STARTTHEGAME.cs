using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class STARTTHEGAME : MonoBehaviour
{
    public bool S = false;
    public bool T = false;
    public bool A = false;
    public bool R = false;
    public bool Tt = false;
    public Text ExitButtonText;
    public Text NoGameText;
    public string startGameText;
    public string HaveGameText;
    public GameObject Sbutton;
    public GameObject Tbutton;
    public GameObject Abutton;
    public GameObject Rbutton;
    public GameObject Ttbutton;

    public void pressS() {
        print("S pressed!");
        S = true;
        Object.Destroy(Sbutton);
        if (S && T && A && R && Tt)
        {
            NoGameText.text = startGameText;
            print("I'm playing a game! ");
            ExitButtonText.text = startGameText;
        }
    }
    public void pressT()
    {
        print("T pressed!");
        T = true;
        Object.Destroy(Tbutton);
        if (S && T && A && R && Tt)
        {
            NoGameText.text = startGameText;
            print("I'm playing a game! ");
            ExitButtonText.text = startGameText;
        }
    }
    public void pressA()
    {
        print("A pressed!");
        A = true;
        Object.Destroy(Abutton);
        if (S && T && A && R && Tt)
        {
            NoGameText.text = startGameText;
            print("I'm playing a game! ");
            ExitButtonText.text = startGameText;
        }
    }
    public void pressR()
    {
        print("R pressed!");
        R = true;
        Object.Destroy(Rbutton);
        if (S && T && A && R && Tt)
        {
            NoGameText.text = startGameText;
            print("I'm playing a game! ");
            ExitButtonText.text = startGameText;
        }
    }
    public void pressTt()
    {
        print("T! pressed!");
        Tt = true;
        Object.Destroy(Ttbutton);
        if (S && T && A && R && Tt)
        {
            NoGameText.text = HaveGameText;
            print("I'm playing a game! ");
            ExitButtonText.text = startGameText;
        }
    }

    public void STARTtheGAME() {
        if (S && T && A && R && Tt)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Change to another scene
        }
        else {
            print("No game for you");
            Application.Quit();//Quit
        }
    }

}
