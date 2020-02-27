using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logoSpawnerKnox : MonoBehaviour
{
     public GameObject[] logos;
    // public GameObject mwc;
    public Transform[] spawnPoints;
    private float nextDrop = 1f; //The time for the next item to spawn
 private float dropInterval = 2f; //The interval between spawned items
 private float changeInterval = 15f; //The interval between changing the interval between spanwed times.

 void Update()
 {
     if(Time.time >= nextDrop) //If ready to spawn
     {
         SpawnObject();
         nextDrop += dropInterval; //Set next spawn time
         if(Time.time >= changeInterval) //If ready to change spawn interval
         {
             if(dropInterval > 1f) //Change spawn interval to 3/4ths what it was
                 dropInterval -= 0.1f;
             else //Make sure dropInterval stays above 1.
                 dropInterval = 1f;
         }
     }
 }

 void SpawnObject(){
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        GameObject randomLogo = logos[Random.Range(0, logos.Length)];
        Transform spawnPoint = spawnPoints[spawnIndex];
        Instantiate(randomLogo, spawnPoint.position, spawnPoint.rotation);
 }

}
