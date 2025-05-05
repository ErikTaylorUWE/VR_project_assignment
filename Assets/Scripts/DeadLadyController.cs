using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLadyController : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Torch")
        {
            animator.SetBool("DeadLady", true);
        }
    }
}
