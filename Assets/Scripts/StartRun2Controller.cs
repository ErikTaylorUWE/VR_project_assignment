using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRun2Controller : MonoBehaviour
{
    public Animator animator;
    //public AudioSource audio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Torch")
        {
            Debug.Log("Entered Trigger");
            animator.SetBool("StartSecondRun", true);
            //audio.Play();
        }

    }
}
