using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCollision : MonoBehaviour
{
    public int pointsPerHit = 1; // Points to gain per hit
    public AudioSource myAudioSource;
    public AudioClip myAudioClip;

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target")) // Assuming the target has a tag "Target"
        {
            // Increment points
            GameManager.instance.AddPoints(pointsPerHit);
            Debug.Log("Target Hit");

            // Optionally, you can add sound or visual feedback here
            myAudioSource.PlayOneShot(myAudioClip);

            // Destroy the axe
            Destroy(gameObject);
        }
    }
}