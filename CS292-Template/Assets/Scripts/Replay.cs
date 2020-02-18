using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour
{
    public GameObject gamepanel;
    public GameObject titlepanel;

    public void Start()
    {
        if (PlayerPrefs.GetInt("restart") == 1)
        {
            gamepanel.SetActive(true);
            titlepanel.SetActive(false);
            PlayerPrefs.SetInt("restart", 0);
        }
        
    }
}
