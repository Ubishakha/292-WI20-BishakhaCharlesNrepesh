using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    // Update is called once per frame
    public GameObject pausebutton;

    // public static GameObject selectedBtn;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            if (GameIsPaused){
                Resume();
            }
            else{
                PauseIt();
            }
        }
    }
    public void Resume(){
        pausebutton.SetActive(false);
        Time.timeScale =1f;
        GameIsPaused = false;
    }

    void PauseIt(){
        pausebutton.SetActive(true);
        Time.timeScale =0f;
        GameIsPaused = true;
    }
    
}
