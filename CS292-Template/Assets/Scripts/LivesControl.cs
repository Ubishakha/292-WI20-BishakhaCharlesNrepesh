using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesControl : MonoBehaviour
{
    public GameObject GameOverPanel,GamePanel;
    public static int health; 
    public Image Flame1, Flame2, Flame3, Flame4;

    // Start is called before the first frame update
    void Start()
    {
        health = 4;
        Flame1.enabled = true;
        Flame2.enabled = false;
        Flame3.enabled = false;
        Flame4.enabled = false;
    }

    // First, second, third and forth sprite enables when the health decreases.  
    void Update()
    {
        if (health > 4) {
            health = 4;
        }
        switch (health)
        {
            case 4:
                Flame1.enabled = true;
                Flame2.enabled = false;
                Flame3.enabled = false;
                Flame4.enabled = false;
                break;
            case 3:
                Flame1.enabled = false;
                Flame2.enabled = true;
                Flame3.enabled = false;
                Flame4.enabled = false;
                break;
            case 2:
                Flame1.enabled = false;
                Flame2.enabled = false;
                Flame3.enabled = true;
                Flame4.enabled = false;
                break;
            case 1:
                Flame1.enabled = false;
                Flame2.enabled = false;
                Flame3.enabled = false;
                Flame4.enabled = true;
                break;
            case 0:
                Flame1.enabled = false;
                Flame2.enabled = false;
                Flame3.enabled = false;
                Flame4.enabled = false;
                GamePanel.gameObject.SetActive(false);
                GameOverPanel.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    }
}
