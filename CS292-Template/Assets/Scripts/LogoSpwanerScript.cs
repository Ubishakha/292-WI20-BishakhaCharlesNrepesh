using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoSpwanerScript : MonoBehaviour
{
    public GameObject[] logos;
    public Transform[] spawnPoints;
    public float minDelay = 0.1f;
    public float maxDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnLogos());
    }
    IEnumerator SpawnLogos(){
        while (true){
            float Delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(Delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            GameObject randomLogo = logos[Random.Range(0, logos.Length)];
            Instantiate(randomLogo, spawnPoint.position, spawnPoint.rotation);
        }   
    }
}
