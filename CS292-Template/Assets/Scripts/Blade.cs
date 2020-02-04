using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    bool isCutting = false;
    Rigidbody2D rb;
    Camera c;
    CircleCollider2D circleCol;
    Vector2 previousPosition;
    public float minVel = .001f;

    private void Start()
    {
        c = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        circleCol = GetComponent<CircleCollider2D>();
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
        previousPosition = c.ScreenToWorldPoint(Input.mousePosition);
        circleCol.enabled = false;
    }

    void StopCutting()
    {
        isCutting = false;
        circleCol.enabled = false;
    }
}
