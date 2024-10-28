using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionException : MonoBehaviour
{
    //// This method is called when another collider makes contact with this collider (if both have Rigidbody components)
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))  // Check if the object colliding is the Player
    //    {
    //        throw new Exception("Player collided with this object!");
    //    }
    //}

    // Alternatively, if using triggers instead of colliders
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))  // Check if the object entering the trigger is the Player
        {
            throw new Exception("Player collided with a power-up!");
        }
    }
}