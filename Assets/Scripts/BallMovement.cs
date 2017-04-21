using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    public float BallSpeed = 0.2f;
    private Vector3 _direction;

    // Use this for initialization
    void Start()
    {
        _direction = new Vector3(1, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        var destination = transform.position + _direction;
        destination.y = 0.5f; //correction pour conserver la balle au sol
        transform.position = Vector3.MoveTowards(transform.position, destination, BallSpeed);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        //reflect direction
        _direction = Vector3.Reflect(_direction, collisionInfo.contacts[0].normal);

        //si la direction est trop faible(on lui donne un petit boost)
        if (Mathf.Abs(_direction.z) < 1)
        {
            _direction.z = _direction.z * 10;
        }

        //on ne veux pas changer la hauteur de la balle
        _direction.y = 0.5f;
    }
}
