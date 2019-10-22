using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAudio : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        AudioSource audioSource = this.GetDeGaulleAudioSource();
        if (audioSource != null) audioSource.enabled = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        var audioSource = this.GetDeGaulleAudioSource();
        if (audioSource != null && audioSource.enabled) audioSource.enabled = false;
    }

    private AudioSource GetDeGaulleAudioSource()
    {
        GameObject deGaulleObject = GameObject.Find("DeGaulle");
        if (deGaulleObject != null)
        {
            AudioSource audioSource = deGaulleObject.GetComponent<AudioSource>();
            return audioSource;
        }
        return null;
    }
}
