using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public float speed;

    // Update is called once per frame
    void Update()
    {
       
        var middle = Screen.width / 2;

        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetMouseButton(0) && Input.mousePosition.x > middle))
        {
            var destination = transform.position;
            destination.x = 3f;
            transform.position = Vector3.MoveTowards(transform.position, destination, speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetMouseButton(0) && Input.mousePosition.x < middle))
        {
            var destination = transform.position;
            destination.x = -3f;
            transform.position = Vector3.MoveTowards(transform.position, destination, speed);

        }
    }
}
