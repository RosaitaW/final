using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SubmitNameScript : MonoBehaviour
{
    public GameObject nameField;
    public Text nameText;
    public Text titleText;
    public Text buttonText;
    public string welcomeText;
    public string ReplaceWithName;
    public string AgreeText;
    public bool submit = false;
    public void Submit() {
        print("Name Submited: " + nameText.text);
        string[] names = nameText.text.Split(' ');
        titleText.text = welcomeText.Replace(ReplaceWithName, names[0]);
        buttonText.text = AgreeText;
        nameField.SetActive(false);
        if (!submit) {
            submit = true; }
        else{
            print("submit is true");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Change to another scene
        }

        //Regex reg = new Regex(*);
    }
    /*public void ChangeScenes()
    {
        if (submit) {
            print("submit is true");
            buttonText.text = AgreeText;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);//Change to another scene
        }
        
    }*/

}
