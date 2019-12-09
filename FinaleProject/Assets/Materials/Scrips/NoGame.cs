using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NoGame : MonoBehaviour
{
    public Text NiceTitleText;
    public Text ButtonText;
    public GameObject destroy;
    public string BackButtonText;
    public string NiceText;
    public string BadText;
    public bool Okay = false;
    public void OkayThen() {
        print("Okay then");
        NiceTitleText.text = NiceText;
        ButtonText.text = BackButtonText;
        if (!Okay)
        {
            Okay = true;
        }else
        {
            print("Back to home now");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Change to another scene
        }

    }
    public void No() {
        print("No");
        Object.Destroy(destroy);
        NiceTitleText.text = BadText;
        Okay = false;
    }
    /*public void BackToHome()
    {
        
        if (Okay)
        {
            print("Back to home now");
            ButtonText.text = BackButtonText;
            SceneManager.LoadScene(0);//Change to another scene
        }
    }*/
}
