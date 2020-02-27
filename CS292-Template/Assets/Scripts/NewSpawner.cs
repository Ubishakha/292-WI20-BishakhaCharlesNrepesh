using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawner : MonoBehaviour
{
    public GameObject oneLogo;    

    public Transform[] spawnpointTop;

    public float DelayandSpawnRate = 5f;
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
           
            int spawnIndex2 = Random.Range(0, spawnpointTop.Length);
            Transform spawnPoint2 = spawnpointTop[spawnIndex2];
            
            Instantiate(oneLogo, spawnPoint2.position, spawnPoint2.rotation);
            }
            //should the spawn rate increase?
            // if countdown has ended and while delay rate is still greater than 0.1 so that logos don't stop spawning in between
            if( spawnRateCountDown < 0 && DelayandSpawnRate > 1 )
             {
                //  reset the countdown 
                 spawnRateCountDown += timeUntilSpawnRateIncrease;
                //  decrease the spwnrate by 0.05
                 DelayandSpawnRate -= 0.5f;
             }
        }   
    }
}
