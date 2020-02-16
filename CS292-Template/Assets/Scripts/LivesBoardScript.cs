using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesBoardScript : MonoBehaviour
{

    public GameObject LivesBoard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LivesBoard.activeSelf == false)
        {
            LivesBoard.SetActive(true);
        }
    }
}
