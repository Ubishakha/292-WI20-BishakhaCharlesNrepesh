using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public GameObject tutorialPanel;
    public GameObject titlePanel;
    public Text highScoreText;
    
    // Start is called before the first frame update
    void Start()
    {   
  
    // Update is called once per frame
        if(PlayerPrefs.GetInt("Highscore", 0) < 5 )
        {
            if (tutorialPanel != null)
            {
                tutorialPanel.SetActive(true);

            }
            /*
            if (tutorialPanel != null && titlePanel.activeSelf == true)
            {
                titlePanel.SetActive(false);
            }
            */
        }
    }
}
