using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    public List<SoundID> SoundObject;

    public bool stopOtherSounds = false;
    public void PlaySound(Sounds sound,
                         Vector3 targetObject,
                         AudioSource audioSource = null, 
                         bool loop = false,
                         bool stopOtherSounds = false,
                         float volume = 1,
                         float pitch = 1)
                         
    {
        if(stopOtherSounds == true)
        {
            foreach (var soundObject in SoundObject)
            {
                soundObject.audioSource.Stop();
            }
        }

        
        SoundObject[(int)sound].audioSource.loop = loop;               
        SoundObject[(int)sound].audioSource.transform.position = targetObject;
        SoundObject[(int)sound].audioSource.volume = volume;
        SoundObject[(int)sound].audioSource.pitch = pitch;
        SoundObject[(int)sound].audioSource.Play();
        Debug.Log(sound);

    }

}

[System.Serializable]
public class SoundID
{
    public Sounds sounds;
    public AudioSource audioSource;

    public SoundID(Sounds _sounds,AudioSource _audioSource)
    {
        sounds = _sounds;
        audioSource = _audioSource;
    }
}

public enum Sounds
{
    CapThrow,
    Jump,
    Background,
    Coin,
    Moon,
    PurpleCoin,





}
