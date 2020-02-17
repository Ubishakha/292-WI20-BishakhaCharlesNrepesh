using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blade : MonoBehaviour
{
    bool isCutting = false;
    Rigidbody2D rb;
    Camera c;
    CircleCollider2D circleCol;
    Vector2 previousPosition;
    public float minVel = .001f;
    public GameObject bladeTrailPrefab;
    GameObject currBladeTrail;

    public GameObject gameOverPanel;
    public GameObject gamePanel;
    public Text ScoreDisplay;
    public Text HighScoreDisplay;
    public int score;
    public AudioSource[] sounds;
    public AudioSource slice;
    public AudioSource bonus;

    private void Start()
    {
        c = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        circleCol = GetComponent<CircleCollider2D>();
        ScoreDisplay.text = score.ToString();
        sounds = GetComponents<AudioSource>();
        slice = sounds[0];
        bonus = sounds[1];
        HighScoreDisplay.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }

        if (isCutting)
        {
            UpdateCutting();
        }
        if (PlayerPrefs.GetInt("Highscore", 0) == 0)
        {
            HighScoreDisplay.text = "0";
        }
    }

    void UpdateCutting()
    {
        Vector2 newPosition = c.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;

        float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
        if (velocity > minVel)
        {
            circleCol.enabled = true;
        }
        else
        {
            circleCol.enabled = false;
        }
        previousPosition = newPosition;
    }

    void StartCutting()
    {
        isCutting = true;
        currBladeTrail = Instantiate(bladeTrailPrefab, transform);
        previousPosition = c.ScreenToWorldPoint(Input.mousePosition);
        circleCol.enabled = false;
    }

    void StopCutting()
    {
        isCutting = false;
        currBladeTrail.transform.SetParent(null);
        Destroy(currBladeTrail, 0f);
        circleCol.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "logo")
        {
            score++;          
        }
        else if (col.tag == "knox")
        {
            if (gameOverPanel != null)
            {
                gameOverPanel.SetActive(true);

            }
            if (gameOverPanel != null && gamePanel.activeSelf == true)
            {                
                gamePanel.SetActive(false);
            }
        }
        else
        {
            score += 10;
        }      
        ScoreDisplay.text = score.ToString();
        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
        
    }
}
