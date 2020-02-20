using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    
    public void PlayerQuit()
    {
        Debug.Log("Player Quit The Game");
        PlayerPrefs.SetFloat("slider", 1f);
        Application.Quit(); 
    }
    
}
