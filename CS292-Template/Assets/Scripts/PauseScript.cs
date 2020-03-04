using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    // Update is called once per frame
    public GameObject pausePanel;

    // Pauses the whole screen using Time.timeScale.
    void Update()
    {
        if (pausePanel.activeSelf == true){
            PauseIt();
        }
        else{
            Resume();
        }
    }
    public void Resume(){
        pausePanel.SetActive(false);
        Time.timeScale =1f;
        GameIsPaused = false;
    }

    void PauseIt(){
        pausePanel.SetActive(true);
        Time.timeScale =0f;
        GameIsPaused = true;
    }
    
}
