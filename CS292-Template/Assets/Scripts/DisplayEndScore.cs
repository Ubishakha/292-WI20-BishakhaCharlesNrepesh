using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayEndScore : MonoBehaviour
{
    public Text scoreText;

    Blade bladeScript;
    // Start is called before the first frame update
    void Start()
    {
        bladeScript = GameObject.FindGameObjectWithTag("Blade").GetComponent<Blade>();
        scoreText.text = bladeScript.getScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
