using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogosMWC : MonoBehaviour
{
    public GameObject explosion;

    //Plays sound, reduce health associated with the MWC logo
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        Destroy(gameObject, 2f);
    }
}