using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material[] materials; //make an array of materials that you can set in the inspector
    MeshRenderer meshRenderer; //make a reference for the meshRenders

    int materialNum = 0; //make a private int that tracks which material you are using

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>(); //get the meshrenderer component from this gameObject

        meshRenderer.material = materials[0]; //set the objects meshRenderer to use the first material in the materials array
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //a public function that changes the color of this gameObject's meshRenderer
    public void ChangeColor(){
        materialNum++; //Add one to the current material num

        //if(materialNum >= materials.Length){
        //    materialNum = 0;
        //}

        //change the material to be the next material in the array
        //use the % to make sure that the number materialNum is modded
        //so that it never exceeds materials.Length
        meshRenderer.material = materials[materialNum % materials.Length];
    }
}
