using UnityEngine;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour
{
    //Reference to component 
    private AudioSource audioSrc;
    //Starting value
    private float musicVolume = 1f;
    public Slider slider;


    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
    audioSrc.volume = slider.value;
    PlayerPrefs.SetFloat("slider", slider.value);

    }
        

    //This takes value passed by slider
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

    public float getVolume()
    {
        return musicVolume;
    }

    public AudioSource getAudioSRC()
    {
        return audioSrc;
    }
    
}
