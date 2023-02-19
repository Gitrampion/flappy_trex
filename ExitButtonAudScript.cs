using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonAudScript : MonoBehaviour
{
    public AudioSource mySoundd;
    public AudioClip hoverSoundd;
    public AudioClip clickSoundd;

    public void HoverSound()
    {
        mySoundd.PlayOneShot(hoverSoundd);
    }

    public void ClickSound()
    {
        mySoundd.PlayOneShot(clickSoundd);
    }
}
