using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject tutorialPanel;

    public void tutorial()
    {   
  
    // Update is called once per frame
        if(PlayerPrefs.GetInt("Highscore", 0) < 5 )
        {
            if (tutorialPanel != null)
            {
                tutorialPanel.SetActive(true);
            }
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("Highscore");
    }
}
