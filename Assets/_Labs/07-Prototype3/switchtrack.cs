using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchtrack: MonoBehaviour
{
    public AudioClip mainMusicClip;
    public AudioClip auxMusicClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            AudioManager.manager.mainMusic.clip = mainMusicClip;
            AudioManager.manager.auxMusic.clip = auxMusicClip;

            AudioManager.manager.mainMusic.Play();
            AudioManager.manager.auxMusic.Play();

        }
    }
}
