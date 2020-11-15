using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnExitMap : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string EnemyTag; // Enemy tags of objects to be destroyed 
    [SerializeField] string MissileTag; // missile tags of objects to be destroyed

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == EnemyTag || other.tag == MissileTag) && enabled) // check if the tag of the colliding object is enemy or missile
        {
            Destroy(other.gameObject);
        }
    }
}
