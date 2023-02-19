using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitAudScript : MonoBehaviour
{
    public AudioSource mySounddd;
    public AudioClip hoverSounddd;
    public AudioClip clickSounddd;

    public void HoverSound()
    {
        mySounddd.PlayOneShot(hoverSounddd);
    }

    public void ClickSound()
    {
        mySounddd.PlayOneShot(clickSounddd);
    }
}
