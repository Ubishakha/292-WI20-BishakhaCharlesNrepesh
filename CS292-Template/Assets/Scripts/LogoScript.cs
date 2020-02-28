using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LogoScript : MonoBehaviour
{
    public GameObject logoPrefab;
	private float startForce = 12f;

	Rigidbody2D rb;


	void Start ()
	{
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
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
