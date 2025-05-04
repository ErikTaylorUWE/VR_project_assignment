using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRunController : MonoBehaviour
{
    public Animator animator;

    public void StartRunAnimation()
    {
        animator.SetBool("StartRun", true);
    }
}
