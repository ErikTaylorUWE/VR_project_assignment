using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGateVoiceController : MonoBehaviour
{
    public AudioSource audio;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Torch")
        {
            audio.Play();
        }
    }
}
