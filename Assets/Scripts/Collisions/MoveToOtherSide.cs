using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToOtherSide : MonoBehaviour
{
    private float y; // vertical size of the camera
    private float maxX; // horizontal size of the camera
    // Start is called before the first frame update
    void Start()
    {
         y = Camera.main.orthographicSize; // get the camera vertical size
        float x = Camera.main.aspect; // get the aspect of the camera
        maxX = y * x; // calculate the horizontal size
    }
    private void OnTriggerEnter2D(Collider2D collision) // When a collision is triggered send the object to the other side of the camera
    {
        switch(collision.tag)
        {
            case "BottomWall":
                this.transform.position += new Vector3(0, 2 * y, 0); // when the object made contact with bottom wall(min Y) it will move it to max Y
                break;
            case "UpperWall":
                this.transform.position += new Vector3(0, -2 * y, 0); // when the object made contact with upper wall(max Y) it will move it to min Y
                break;
            case "RightWall":
                this.transform.position += new Vector3(-2*maxX, 0, 0); // when the object made contact with right wall(max X) it will move it to min X
                break;
            case "LeftWall":
                this.transform.position += new Vector3(2* maxX, 0, 0); // when the object made contact with left wall(min X) it will move it to max X
                break;
        }   
    }
}
