using UnityEngine;
using System.Collections;

public class Pacdot : MonoBehaviour
{
    public AudioClip pickupSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag == "Pacman")
        {
            ScoreDisplay.scoreValue += 100; 
            Destroy(gameObject);

            if (audioSource && pickupSound)
            {
                audioSource.PlayOneShot(pickupSound);
            }
        }
    }
}
