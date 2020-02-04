using UnityEngine;

public class VolumeChange : MonoBehaviour
{
    //Reference to component 
    private AudioSource audioSrc;

    //Starting value
    private float musicVolume = 1f;

    private void Start()
    {
        //Assign audio source
        audioSrc = GetComponent<AudioSource>();        
    }

    private void Update()
    {
        //Audio source equal to music Volume
        audioSrc.volume = musicVolume;
    }

    //This takes value passed by slider
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

}
