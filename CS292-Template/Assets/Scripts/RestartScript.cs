using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

    public void RestartGame()
    {
        //store player prefs if game is restarted      
        PlayerPrefs.SetInt("restart", 1);
        SceneManager.LoadScene("Gameplay");        
    }

    public void goHome()
    {
        //store player prefs if player wantes to go home    
        PlayerPrefs.SetInt("restart", 0);
        SceneManager.LoadScene("Gameplay");
    }
}
