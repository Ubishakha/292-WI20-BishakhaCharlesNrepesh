using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject tutorialPanel;
    public GameObject gamePanel;
    public GameObject titlePanel;

    public void Starttutorial()
    {

        // Update is called once per frame

        if (PlayerPrefs.GetInt("Highscore", 0) < 30)
        {
            if (tutorialPanel != null)
            {
                tutorialPanel.SetActive(true);
                titlePanel.SetActive(false);
            }
        }
        else
        {
            if (gamePanel != null)
            {
                gamePanel.SetActive(true);
                titlePanel.SetActive(false);
            }
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("Highscore");
    }
}
