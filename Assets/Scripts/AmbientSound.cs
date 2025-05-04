using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSound : MonoBehaviour
{
    public Collider Area;   // area of the sound
    public GameObject Player;    // the object to track (player)

    private void Update()
    {
        // find the closest point on the collider to the player
        Vector3 closestPoint = Area.ClosestPoint(Player.transform.position);
        // set position to cloest point to the player
        transform.position = closestPoint;
    }
}
