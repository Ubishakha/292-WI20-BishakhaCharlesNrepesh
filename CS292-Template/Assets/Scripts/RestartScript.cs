using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

    public void RestartGame()
    {
        //store volume
        //PlayerPrefs.SetInt("volume", volumeControl.VolumeChange.getVolume());
        PlayerPrefs.SetInt("restart", 1);
        SceneManager.LoadScene("Gameplay");        
    }

    public void goHome()
    {
        //store volume
        //PlayerPrefs.SetInt("volume", volumeControl.getVolume());
        PlayerPrefs.SetInt("restart", 0);
        SceneManager.LoadScene("Gameplay");
    }
}
