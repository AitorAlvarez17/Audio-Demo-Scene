using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip[] foostepsOnGrass;
    public AudioClip[] foostepsOnConcrete;
    public AudioClip[] foostepsOnGlass;

    private string surface;

    void PlayFootstepSound()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = Random.Range(0.9f, 1.0f);
        audioSource.pitch = Random.Range(0.9f, 1.1f);

        switch (surface)
        {
            case "Grass":
                if (foostepsOnGrass.Length > 0)
                    audioSource.PlayOneShot(foostepsOnGrass[Random.Range(0, foostepsOnGrass.Length)]);
                break;

            case "Concrete":
                if (foostepsOnConcrete.Length > 0)
                    audioSource.PlayOneShot(foostepsOnConcrete[Random.Range(0, foostepsOnConcrete.Length)]);
                break;

            case "Glass":
                if (foostepsOnGlass.Length > 0)
                    audioSource.PlayOneShot(foostepsOnGlass[Random.Range(0, foostepsOnGlass.Length)]);
                break;

            default:
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Grass":
            case "Concrete":
            case "Glass":
                surface = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }
}
