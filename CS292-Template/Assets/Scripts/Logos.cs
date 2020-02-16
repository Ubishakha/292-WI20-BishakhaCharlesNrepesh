using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logos : MonoBehaviour
{
    public GameObject explosion;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (col.tag == "ground")
        {           
            Destroy(gameObject);
            LivesControl.health -= 1;
        }
    }
}