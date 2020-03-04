using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnoxTopLogos : MonoBehaviour
{
     public GameObject logoPrefab;

	Rigidbody2D rb;


	void Start ()
	{
        //Rotates knox object when tag is found 
        rb = GetComponent<Rigidbody2D>();

        if (logoPrefab.tag == "knox")
        {
            rb.AddTorque(Random.Range(-1000, 1000));
        }
        else
        {
            rb.AddTorque(Random.Range(-180, 180));
        }
	}
}
