using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour
{
    public GameObject currGamePanel;
    public GameObject nextGamePanel;
    public void ReplayGame()
    {
        Destroy(currGamePanel);
        Instantiate(nextGamePanel);
    }
}
