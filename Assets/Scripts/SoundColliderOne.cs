using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundColliderOne : MonoBehaviour
{

    AudioSource source;
    BoxCollider soundTrigger;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<BoxCollider>();
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Torch")
        {
            source.Play();
        }
    }
}
