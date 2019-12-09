using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
    
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public Dictionary<string, string> webster;
    public Dictionary<GameObject, string> friends;
    // Start is called before the first frame update
    void Start()
    {
        webster = new Dictionary<string,string>();
        friends = new Dictionary<GameObject, string>();
        DontDestroyOnLoad(gameObject);
        webster.Add("Bird", "The Word!");
        webster.Add("Dog", "An animal that runs.");

        print("Dog" + webster["Dog"]);
        friends.Add(item1, "Sword");
        friends.Add(item2, "Bow");
        friends.Add(item3, "Shield");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
