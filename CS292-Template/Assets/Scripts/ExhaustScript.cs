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
    private RipplePostProcessor camRipple;

    private void Start()
    {
        camRipple = Camera.main.GetComponent<RipplePostProcessor>();        //get camera object 
    }

    // When lives are lost: 1. Smoke animation plays, 2. Phone vibrates, 3.lives flame sprite decreased, 4. Ripple effect 
    void Update()
    {
        if(Flame2.enabled == true )
        {
            if (ranbool2)
            {
                Instantiate(exhaust, transform.position, Quaternion.identity);
                camRipple.RippleEffect();
                Handheld.Vibrate();
                ranbool2 = false;
            }
        }
        if (Flame3.enabled == true)
        {
            if (ranbool3)
            {
                Instantiate(exhaust, transform.position, Quaternion.identity);
                camRipple.RippleEffect();
                Handheld.Vibrate();
                ranbool3 = false;
            }
        }
        if (Flame4.enabled == true)
        {
            if (ranbool4)
            {
                Instantiate(exhaust, transform.position, Quaternion.identity);
                camRipple.RippleEffect();
                Handheld.Vibrate();
                ranbool4 = false;
            }
        }
    }
}
