using UnityEngine;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour
{
    //Reference to component 
    private AudioSource audioSrc;
    //Starting value
    private float musicVolume = 1f;
    public Slider slider;
    public Slider sliderSFX;

    Blade blade;
    public GameObject ground;
    public GameObject groundL;
    public GameObject groundR;
    public GameObject gameOverPanel;
    public GameObject gameScreenPanel;

    AudioSource[] sounds;
    AudioSource groundSound;
    AudioSource groundSoundL;
    AudioSource groundSoundR;

    AudioSource gameOverSound;
    private void Start()
    {
        blade = GameObject.FindGameObjectWithTag("Blade").GetComponent<Blade>();
        
        audioSrc = GetComponent<AudioSource>();
        sounds = blade.GetComponents<AudioSource>();
        groundSound = ground.GetComponent<AudioSource>();
        groundSoundL = groundL.GetComponent<AudioSource>();
        groundSoundR = groundR.GetComponent<AudioSource>();
        gameOverSound = gameOverPanel.GetComponent<AudioSource>();
    }

    private void Update()
    {
        
        audioSrc.volume = slider.value;
        sounds[0].volume = sliderSFX.value;
        sounds[1].volume = sliderSFX.value;
        sounds[2].volume = sliderSFX.value;
        groundSound.volume = sliderSFX.value;
        groundSoundL.volume = sliderSFX.value;
        groundSoundR.volume = sliderSFX.value;
        gameOverSound.volume = sliderSFX.value;
        PlayerPrefs.SetFloat("slider", slider.value);
        PlayerPrefs.SetFloat("sliderSFX", sliderSFX.value);
        
    }
        

    //This takes value passed by slider
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

    public void SetSFX(float vol)
    {
        sounds[0].volume = vol;
        sounds[1].volume = vol;
        sounds[2].volume = vol;

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
