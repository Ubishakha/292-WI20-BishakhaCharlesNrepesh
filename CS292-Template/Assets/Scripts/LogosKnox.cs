using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogosKnox : MonoBehaviour
{
    // public GameObject explosion;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            //Instantiate(explosion, transform.position, Quaternion.identity);
            LivesControl.health -= 1;
            Destroy(gameObject);
        }
        Destroy(gameObject, 2f);
    }
}