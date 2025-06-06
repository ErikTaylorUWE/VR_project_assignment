using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator animator;
    public AudioSource audio;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Torch")
        {
            animator.SetBool("Open", true);
            audio.Play();
        }
        
    }
}
