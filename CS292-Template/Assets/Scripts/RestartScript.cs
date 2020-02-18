using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public void RestartGame()
    {
        PlayerPrefs.SetInt("restart", 1);
        SceneManager.LoadScene("Gameplay");        
    }

    public void goHome()
    {
        PlayerPrefs.SetInt("restart", 0);
        SceneManager.LoadScene("Gameplay");
    }
}
