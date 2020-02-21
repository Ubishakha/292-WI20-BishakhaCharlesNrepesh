using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogosKnox : MonoBehaviour
{
    // public GameObject explosion;
    public AudioSource hitTrigger;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            hitTrigger = GameObject.FindGameObjectWithTag("ground").GetComponent<AudioSource>();
            //Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            LivesControl.health -= 1;
            hitTrigger.Play();
        }
        Destroy(gameObject, 2f);
    }
}