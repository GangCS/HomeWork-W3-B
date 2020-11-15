using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class KeyboardMover: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;

    void Update() {
        float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float vertical = Input.GetAxis("Vertical");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise
        if (vertical == 1)
        {
            transform.eulerAngles = new Vector3(0, 0, 90); // rotate the ship 
        }
        if (vertical == -1)
        {
            transform.eulerAngles = new Vector3(0, 0, -90); // rotate the ship 
        }
        if (horizontal == 1)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);// rotate the ship 
        }
        if (horizontal == -1)
        {
            transform.eulerAngles = new Vector3(0, 0, 180);// rotate the ship 
        }
        Vector3 movementVector = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
        transform.position += movementVector;
    }
}
