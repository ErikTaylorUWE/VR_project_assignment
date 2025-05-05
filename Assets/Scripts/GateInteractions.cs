using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateInteractions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Animator animator;
    public AudioSource audio;

    public void Hover()
    {
        Debug.Log("Hover");
    }
    public void Selected()
    {
        Debug.Log("Selected");
        animator.SetBool("DeadLady", true);
        audio.Play();

    }

    public void Activated()
    {
        Debug.Log("Activated");
    }
}
