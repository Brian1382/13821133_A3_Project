using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDirector : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip start;
    public AudioClip transition;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = start;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (audioSource.isPlaying)
        {

        }
        else 
        {
            audioSource.clip = transition;
            audioSource.Play();
        }
    }
}
