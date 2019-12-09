using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SayHelloScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SayHello() {
        print("Hello!");
    }
    public void ChangeScene(string sceneName) {
        SceneManager.LoadScene(sceneName);//Change to another scene
    }
}
