using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public Animator animator;
    public AudioSource audio;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Torch")
        {
            animator.SetBool("ZombieRun", true);
            audio.Play();
        }
        
    }
}
