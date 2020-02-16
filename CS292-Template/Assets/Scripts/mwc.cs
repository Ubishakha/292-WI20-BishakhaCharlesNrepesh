using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mwc : MonoBehaviour
{
    public GameObject mwcLogo;    

    public Transform[] spawnpointSides;

    public float minDelay = 0.1f;
    public float maxDelay = 1f;
    
    void Start()
    {
        StartCoroutine(SpawnLogos());
    }
    IEnumerator SpawnLogos(){
       
        while (true){
            float Delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(Delay);
    
            int spawnIndex2 = Random.Range(0, spawnpointSides.Length);
            Transform spawnPoint2 = spawnpointSides[spawnIndex2];
            
            Instantiate(mwcLogo, spawnPoint2.position, spawnPoint2.rotation);
        }   
    }
}
