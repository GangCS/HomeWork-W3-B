using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{
    private float pushBack = 0.2f;
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ship")
        {
            if (this.tag.CompareTo("LeftWall") == 0)
            {
                collision.transform.position = collision.transform.position + new Vector3(pushBack, 0, 0);
            }
            else if (this.tag.CompareTo("RightWall") == 0)
            {
                collision.transform.position = collision.transform.position - new Vector3(pushBack, 0, 0);
            }
            else if (this.tag.CompareTo("UpperWall") == 0)
            {
                collision.transform.position = collision.transform.position - new Vector3(0, pushBack, 0);
            }
            else if (this.tag.CompareTo("BottomWall") == 0)
            {
                collision.transform.position = collision.transform.position + new Vector3(0, pushBack, 0);
            }
        }
    }
}
