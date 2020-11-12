using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnExitMap : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string EnemyTag;
    [SerializeField] string MissileTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == EnemyTag && enabled)
        {
            Destroy(other.gameObject);
        }
        if (other.tag == MissileTag && enabled)
        {
            Destroy(other.gameObject);
        }
    }
}
