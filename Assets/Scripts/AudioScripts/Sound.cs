using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static AudioClip jumpSound;
    static AudioSource audioSrc;
    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("JumpEffect");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "JumpEffect":
                Debug.Log("audio is playing");
                audioSrc.PlayOneShot(jumpSound);
                break;
        }
    }
}
