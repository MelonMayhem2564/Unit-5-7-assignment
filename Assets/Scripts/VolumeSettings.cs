using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] public AudioMixer AudioMixer;
    [SerializeField] public AudioSource AudioSource;
    [SerializeField] public Slider Musicvolume;
    [SerializeField] public Slider Soundeffectsvolume;
    [SerializeField] public Toggle MusicToggle;

    public void Start()
    {
        SetMusicVolume();
        SetSoundEffectsVolume();
    }

    public void SetMusicVolume()
    {
        float volume = Musicvolume.value;
        AudioMixer.SetFloat("Music", Mathf.Log10(volume)*20);
    }

    public void SetSoundEffectsVolume()
    {
        float volume = Soundeffectsvolume.value;
        AudioMixer.SetFloat("Sound effect", Mathf.Log10(volume)*20);
    }

    public void SetMusicToggle()
    {
        bool toggle = MusicToggle.isOn;
        if (toggle == true)
        {
            Musicvolume.value = 1f;
        }
        else if (toggle == false)
        {
            Musicvolume.value = 0.0001f;
        }
    }
    public void EnableMusicToggle()
    {
        if (Musicvolume.value > 0.0001f)
        {
            MusicToggle.isOn = true;
        }
        else if (Musicvolume.value == 0.0001f)
        {
            MusicToggle.isOn = false;
        }
    }
}

