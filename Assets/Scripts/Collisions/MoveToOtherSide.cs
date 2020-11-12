using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToOtherSide : MonoBehaviour
{
    private float x;
    private float y;
    private float maxX;
    // Start is called before the first frame update
    void Start()
    {
         y = Camera.main.orthographicSize;
         x = Camera.main.aspect;
        maxX = y * x;
        Debug.Log(y);
        Debug.Log(maxX);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.tag)
        {
            case "BottomWall":
                this.transform.position += new Vector3(0, 2 * y, 0);
                break;
            case "UpperWall":
                this.transform.position += new Vector3(0, -2 * y, 0);
                break;
            case "RightWall":
                this.transform.position += new Vector3(-2*maxX, 0, 0);
                break;
            case "LeftWall":
                this.transform.position += new Vector3(2* maxX, 0, 0);
                break;
        }
            
        
        
    }

}
