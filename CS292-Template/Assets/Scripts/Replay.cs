using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour
{
    public GameObject gamepanel;
    public GameObject titlepanel;
    //Canvas volumeControl;
    public AudioSource audioController;
    public void Start()
    {
        audioController = GetComponent<AudioSource>();
        //volumeControl = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>();
        audioController.volume = PlayerPrefs.GetFloat("volume");
        if (PlayerPrefs.GetInt("restart") == 1)
        {

            gamepanel.SetActive(true);
            titlepanel.SetActive(false);
            PlayerPrefs.SetInt("restart", 0);
        }
        
    }
}
