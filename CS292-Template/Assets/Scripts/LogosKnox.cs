using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogosKnox : MonoBehaviour
{
    
    public AudioSource hitTrigger;


    //Plays sound, reduce health associated with the knox logo

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            hitTrigger = GameObject.FindGameObjectWithTag("ground").GetComponent<AudioSource>();
            Destroy(gameObject);
            LivesControl.health -= 1;
            hitTrigger.Play();
        }
        Destroy(gameObject, 2f);
    }
}