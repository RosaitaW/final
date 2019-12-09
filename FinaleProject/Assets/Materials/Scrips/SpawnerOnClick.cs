using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOnClick : MonoBehaviour
{
    public GameObject newSphere;
    public void SpawnSphere() {
        GameObject newSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        SphereCollider sc = newSphere.GetComponent<SphereCollider>();
        Destroy(sc);
        Invoke("Add2DPhysics", 0.1f);
    }
    public void Add2DPhysics() {
        newSphere.AddComponent<CircleCollider2D>();
        newSphere.AddComponent<Rigidbody2D>();
    }
}
