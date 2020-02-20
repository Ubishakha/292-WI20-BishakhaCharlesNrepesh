using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Replay : MonoBehaviour
{
    public GameObject gamepanel;
    public GameObject titlepanel;
    private AudioSource audioController;
    //Canvas canvas;

    public void Start()
    {
        audioController = GetComponent<AudioSource>();

        //canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>();
        //audioController = canvas.GetComponent<AudioSource>();
        Debug.Log(PlayerPrefs.GetFloat("volume"));
        // canvas.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volume");
        if (PlayerPrefs.HasKey("volume"))
        {
            audioController.volume = PlayerPrefs.GetFloat("volume");
        }
            if (PlayerPrefs.GetInt("restart") == 1)
            {
                gamepanel.SetActive(true);
                titlepanel.SetActive(false);
                PlayerPrefs.SetInt("restart", 0);
            }
        }
    
}
