using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOneController : MonoBehaviour
{
    public AudioSource audio;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Torch")
        {
            audio.Play();
        }
    }
}
