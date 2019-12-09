using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem : MonoBehaviour
{

    public Vector2 minForce;

    public Vector2 maxForce;



    bool particleSwitch = false;



    List<GameObject> particleList = new List<GameObject>();



    // Start is called before the first frame update

    void Start()

    {



    }



    // Update is called once per frame

    void Update()

    {

        if (particleSwitch)
        {

            GameObject newPart = Instantiate<GameObject>(Resources.Load<GameObject>("Prefabs/ParticleSprite"));

            newPart.transform.position = transform.position;

            Rigidbody2D rb = newPart.GetComponent<Rigidbody2D>();

            rb.AddForce(

                new Vector2(

                    Random.Range(minForce.x, maxForce.x),

                    Random.Range(minForce.y, maxForce.y)));



            particleList.Add(newPart);

        }



        List<GameObject> retiredParticles = new List<GameObject>();



        foreach (GameObject particle in particleList)
        {

            if (particle.transform.position.y < -20)
            {

                retiredParticles.Add(particle);

            }

        }



        foreach (GameObject particle in retiredParticles)
        {

            particleList.Remove(particle);

            Destroy(particle);

        }

    }



    //toggle particle system

    public void ToggleParticleSystem()
    {

        particleSwitch = !particleSwitch;

    }

}
/*
{
    public Vector2 initForce;
    bool particleswitch=false;
    List<GameObject> particleList = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (particleswitch)
        {
            GameObject newPart = Instantiate<GameObject>(Resources.Load<GameObject>("PrefabParticle"));
            newPart.transform.position = transform.position;
            Rigidbody2D rb = newPart.GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(Random.Range(-initForce.x, initForce.x), Random.Range(-initForce.y, initForce.y)));
            particleList.Add(newPart);
        }
        List<GameObject> retiredParticles = new List<GameObject>();
        foreach (GameObject particle in particleList)
        {
            if (particle.transform.position.y < -20)
            {
                retiredParticles.Add(particle);
            }
        }
        foreach (GameObject particle in retiredParticles)
        {
            if (particle.transform.position.y < -20)
            {
                retiredParticles.Add(particle);
            }
        }
    }

        //toggle particle system
        public void ToggleParticleSystem()
    {
        particleswitch = !particleswitch;
    }

}*/
