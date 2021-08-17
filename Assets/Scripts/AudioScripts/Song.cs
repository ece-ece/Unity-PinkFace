using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Song : MonoBehaviour
{
    private AudioSource aud = null;

    void Start()
    {
        aud = this.GetComponent<AudioSource>();
        StartCoroutine(LoadAudio());
    }
    private IEnumerator LoadAudio()
    {
       
        string fullpath = "file://" + "C:/UnityProjelerim/PinkFace/Assets/Audio/string.wav";
        WWW url = new WWW(fullpath);
        yield return url;

        aud.clip = url.GetAudioClip(false, true);
        aud.Play();
    }
   
}
