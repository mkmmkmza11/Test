using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float volume) 
    {
        audioMixer.SetFloat("Volume", volume); 

    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);   
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
