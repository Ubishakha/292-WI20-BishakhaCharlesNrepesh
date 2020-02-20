using UnityEngine;

public class VolumeChange : MonoBehaviour
{
    //Reference to component 
    public AudioSource audioSrc;

    //Starting value
    public float musicVolume = 1f;

    private void Start()
    {
        //Assign audio source
        audioSrc = GetComponent<AudioSource>();        
    }

    private void Update()
    {
        //Audio source equal to music Volume
        audioSrc.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", audioSrc.volume);
    }

    //This takes value passed by slider
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
    /*
    public float getVolume()
    {
        return musicVolume;
    }
    */
}
