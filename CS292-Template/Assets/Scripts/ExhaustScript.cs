using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExhaustScript : MonoBehaviour
{
    public Image Flame1, Flame2, Flame3, Flame4;
    public GameObject exhaust;
    public bool ranbool2 = true;
    public bool ranbool3 = true;
    public bool ranbool4 = true;

    // Update is called once per frame
    void Update()
    {
        if(Flame2.enabled == true )
        {
            if (ranbool2)
            {
                Instantiate(exhaust, transform.position, Quaternion.identity);
                ranbool2 = false;
            }
        }
        if (Flame3.enabled == true)
        {
            if (ranbool3)
            {
                Instantiate(exhaust, transform.position, Quaternion.identity);
                ranbool3 = false;
            }
        }
        if (Flame4.enabled == true)
        {
            if (ranbool4)
            {
                Instantiate(exhaust, transform.position, Quaternion.identity);
                ranbool4 = false;
            }
        }
    }
}
