using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public  static AudioController _instance;
    public List<AudioClip> sources;
    public AudioSource audioSource;

    private void Awake()
    {
        if (_instance!= null)
        {
            Destroy(_instance);
        }
        else
        {
            _instance = this;
        }
    }

   


    public void ClothVoice()
    {
        audioSource.PlayOneShot(sources[0]);
    }
    public void CollectableVoice()
    {
        audioSource.PlayOneShot(sources[1]);
    }
}
