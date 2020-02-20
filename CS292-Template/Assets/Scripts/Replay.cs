using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Replay : MonoBehaviour
{
    public GameObject gamepanel;
    public GameObject titlepanel;
    private AudioSource audioController;

    public Slider slider;

    public void Start()
    {
        slider.value = PlayerPrefs.GetFloat("slider");
        if (PlayerPrefs.GetInt("restart") == 1)
        {
            gamepanel.SetActive(true);
            titlepanel.SetActive(false);
            PlayerPrefs.SetInt("restart", 0);
        }
    }
}
