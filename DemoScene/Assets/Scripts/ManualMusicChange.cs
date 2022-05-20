using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ManualMusicChange : MonoBehaviour
{
    public List<AudioClip> tracklist;

    public float transitionTime = 0.2f;

    private int iterator = 1;
    public bool canChange;

    private AudioSource source;
    private void Start()
    {
        canChange = false;
        source = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
        canChange = false;
        
        
        float dist = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);
        if (dist < source.maxDistance/2 && source.name != "IndistinctChatter")
        {
            canChange = true;
        }


        if(canChange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (iterator < tracklist.Count)
                {
                    source.clip = tracklist[iterator];
                    source.Play();
                    iterator++;
                }

                else
                    iterator = 0;
            }
        }
        
        if(!source.isPlaying)
        {
            iterator++;
            if (iterator > 2)
                iterator = 0;
            source.clip = tracklist[iterator];
        }
    }
    void OnGUI()
    {
        if(canChange) GUI.Box(new Rect(Screen.width - 175, Screen.height - 25, 170, 20), "Press 'e' to change track");
    }
}
