﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logos : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
    }
}
