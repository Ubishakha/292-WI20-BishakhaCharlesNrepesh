using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoSpwanerScript : MonoBehaviour
{
    public GameObject[] logos;
    // public GameObject mwc;
    public Transform[] spawnPoints;
    // public Transform[] spawnpointSides;
    // public float minDelay;
    // public float maxDelay;

    public float DelayandSpawnRate = 1f;
    public float timeUntilSpawnRateIncrease = 10f;
    void Start()
    {
        StartCoroutine(SpawnLogos(DelayandSpawnRate));
    }
    IEnumerator SpawnLogos(float firstDelay){
        // remaining time before delayandspawnrate is decreased
        float spawnRateCountDown = timeUntilSpawnRateIncrease;
        // remaining time before a new logo is spawned
        float spawnCountDown = firstDelay;
        
        while (true){
            yield return null;
            // begin countdown
            spawnRateCountDown -= Time.deltaTime;
            // rate of logos appearing on screen decreases
            spawnCountDown     -= Time.deltaTime;
            
            // should a new logo be spawned?
            // if 1 decreases down to 0
            if (spawnCountDown < 0){
                // add the original delay rate to countdown
                spawnCountDown += DelayandSpawnRate;
                //pick randown spawnpoint    
                int spawnIndex = Random.Range(0, spawnPoints.Length);
                Transform spawnPoint = spawnPoints[spawnIndex];
                // get a random logo from the list 
                GameObject randomLogo = logos[Random.Range(0, logos.Length)];
                Instantiate(randomLogo, spawnPoint.position, spawnPoint.rotation); 
            }
            //should the spawn rate increase?
            // if countdown has ended and while delay rate is still greater than 0.1 so that logos don't stop spawning in between
            if( spawnRateCountDown < 0 && DelayandSpawnRate > 0.1 )
             {
                //  reset the countdown 
                 spawnRateCountDown += timeUntilSpawnRateIncrease;
                //  decrease the spwnrate by 0.05
                 DelayandSpawnRate -= 0.03f;
             }
 
        }   
    }
}
