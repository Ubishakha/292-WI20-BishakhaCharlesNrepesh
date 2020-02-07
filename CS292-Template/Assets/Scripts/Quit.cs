using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void PlayerQuit()
    {
        Debug.Log("Player Quit The Game");
        Application.Quit(); 
    }
}
