using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject torch;

    public void InstantiateTorch()
    {
        Instantiate(torch, new Vector3(1, 10, 6), Quaternion.identity);
    }
}
