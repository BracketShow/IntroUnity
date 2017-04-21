using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

    void OnCollisionEnter(Collision collisionInfo)
    {
        Invoke("Explode", 0.1f);
    }
    private void Explode()
    {
        gameObject.SetActive(false);
    }
}
