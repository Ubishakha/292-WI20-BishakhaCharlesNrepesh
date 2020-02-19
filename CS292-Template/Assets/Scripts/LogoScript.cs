using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LogoScript : MonoBehaviour
{
    public GameObject logoPrefab;
	public float startForce = 10f;

	Rigidbody2D rb;


	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
	}


}
