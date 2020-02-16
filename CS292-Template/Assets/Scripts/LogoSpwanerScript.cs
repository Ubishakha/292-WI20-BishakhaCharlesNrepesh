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

            if (spawnCountDown < 0){
                spawnCountDown += DelayRate;
                int spawnIndex = Random.Range(0, spawnPoints.Length);
                Transform spawnPoint = spawnPoints[spawnIndex];
                
                GameObject randomLogo = logos[Random.Range(0, logos.Length)];
                Instantiate(randomLogo, spawnPoint.position, spawnPoint.rotation); 
            }

            if( spawnRateCountDown < 0 && DelayRate > 0.1 )
             {
                 spawnRateCountDown += timeIncrease;
                 DelayRate -= 0.1f;
             }
 
        }   
    }
}
