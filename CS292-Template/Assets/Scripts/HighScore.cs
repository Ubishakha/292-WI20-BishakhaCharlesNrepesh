using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public GameObject tutorialPanel;
    public GameObject titlePanel;
    public Text highScoreText;
    public int highScore = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = highScore.ToString();
    
  
    // Update is called once per frame
        if(highScore == 0)
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
