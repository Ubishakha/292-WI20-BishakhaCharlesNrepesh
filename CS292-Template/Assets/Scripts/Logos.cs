using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logos : MonoBehaviour
{
    public GameObject explosion;
    public AudioSource hitTrigger;

    // destroys game object when tag blade or tag ground hits it and reduce lives
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        hitTrigger = GameObject.FindGameObjectWithTag("ground").GetComponent<AudioSource>();
        if (col.tag == "ground")
        {           
            hitTrigger.Play();
            Destroy(gameObject, 2f);
            LivesControl.health -= 1;
            
        }
    }
}