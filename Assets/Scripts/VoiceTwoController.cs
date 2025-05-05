using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceTwoController : MonoBehaviour
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
