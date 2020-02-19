using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoSpwanerScript : MonoBehaviour
{
    public GameObject[] logos;
    // public GameObject mwc;
    public Transform[] spawnPoints;
    // public Transform[] spawnpointSides;
    public float minDelay;
    public float maxDelay;

    public float DelayRate;
    public float timeIncrease;
    void Start()
    {
        StartCoroutine(SpawnLogos(DelayRate));
    }
    IEnumerator SpawnLogos(float firstDelay){
        float spawnRateCountDown = timeIncrease;
        float spawnCountDown = firstDelay;
        while (true){
            yield return null;
            spawnRateCountDown -= Time.deltaTime;
            spawnCountDown     -= Time.deltaTime;
            // should a new logo be spawned?
            if (spawnCountDown < 0){
                spawnCountDown += DelayRate;
                int spawnIndex = Random.Range(0, spawnPoints.Length);
                Transform spawnPoint = spawnPoints[spawnIndex];
                // get a random logo from the list 
                GameObject randomLogo = logos[Random.Range(0, logos.Length)];
                Instantiate(randomLogo, spawnPoint.position, spawnPoint.rotation); 
            }
            //should the spawn rate increase?
            if( spawnRateCountDown < 0 && DelayRate > 1 )
             {
                 spawnRateCountDown += timeIncrease;
                 DelayRate -= 0.5f;
             }
 
        }   
    }
}
