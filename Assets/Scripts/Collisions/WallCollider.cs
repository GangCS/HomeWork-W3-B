using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{
    private float pushBack = 0.2f; //Push back force
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerStay2D(Collider2D collision) // On trigger stay to avoid making it through the wall by spamming too much
    {
        if (collision.tag == "Ship") // push back only if its the ship
        {
            if (this.tag.CompareTo("LeftWall") == 0)
            {
                collision.transform.position = collision.transform.position + new Vector3(pushBack, 0, 0); //made contact with left wall push back to the right
            }
            else if (this.tag.CompareTo("RightWall") == 0)
            {
                collision.transform.position = collision.transform.position - new Vector3(pushBack, 0, 0);//made contact with right wall push back to the left
            }
            else if (this.tag.CompareTo("UpperWall") == 0)
            {
                collision.transform.position = collision.transform.position - new Vector3(0, pushBack, 0);//made contact with upper wall push back to down
            }
            else if (this.tag.CompareTo("BottomWall") == 0)
            {
                collision.transform.position = collision.transform.position + new Vector3(0, pushBack, 0);//made contact with bottom wall push back up
            }
        }
    }
}
