using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesControl : MonoBehaviour
{

    public GameObject Flame1, Flame2, Flame3, Flame4, GameOverPanel;
    public static int health; 

    // Start is called before the first frame update
    void Start()
    {
        health = 4;
        Flame1.gameObject.SetActive(true);
        Flame2.gameObject.SetActive(false);
        Flame3.gameObject.SetActive(false);
        Flame4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 4) {
            health = 4;
        }
        switch (health)
        {
            case 4:
                Flame1.gameObject.SetActive(true);
                Flame2.gameObject.SetActive(false);
                Flame3.gameObject.SetActive(false);
                Flame4.gameObject.SetActive(false);
                break;
            case 3:
                Flame1.gameObject.SetActive(false);
                Flame2.gameObject.SetActive(true);
                Flame3.gameObject.SetActive(false);
                Flame4.gameObject.SetActive(false);
                break;
            case 2:
                Flame1.gameObject.SetActive(false);
                Flame2.gameObject.SetActive(false);
                Flame3.gameObject.SetActive(true);
                Flame4.gameObject.SetActive(false);
                break;
            case 1:
                Flame1.gameObject.SetActive(false);
                Flame2.gameObject.SetActive(false);
                Flame3.gameObject.SetActive(false);
                Flame4.gameObject.SetActive(true);
                break;
            case 0:
                Flame1.gameObject.SetActive(false);
                Flame2.gameObject.SetActive(false);
                Flame3.gameObject.SetActive(false);
                Flame4.gameObject.SetActive(false);
                GameOverPanel.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    }
}
