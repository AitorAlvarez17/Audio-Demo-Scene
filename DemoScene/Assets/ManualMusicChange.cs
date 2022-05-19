using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ManualMusicChange : MonoBehaviour
{
    public List<AudioMixerSnapshot> tracklist;

    public float transitionTime = 0.2f;

    private int iterator = 0;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (iterator < tracklist.Count)
                tracklist[iterator].TransitionTo(transitionTime);
            else
                iterator = 0;
        }
    }
}
