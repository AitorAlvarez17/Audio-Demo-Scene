using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ManualMusicChange : MonoBehaviour
{
    public List<AudioClip> tracklist;

    public float transitionTime = 0.2f;

    private int iterator = 0;

    private AudioSource source;
    private void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
        Collider[] player = Physics.OverlapSphere(transform.position, source.maxDistance/2, LayerMask.GetMask("Player"));

        if(player.Length > 0)
        { 
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (iterator < tracklist.Count)
                    source.clip = tracklist[iterator];
                else
                    iterator = 0;
            }
        }
    }
}
