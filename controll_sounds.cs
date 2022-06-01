using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll_sounds : MonoBehaviour
{
    public AudioClip[] audioClips;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Play(string seName)
    {
        switch (seName)
        {
            case "accell":
                audioSource.PlayOneShot(audioClips[0]);
                break;
            case "joko":
                audioSource.PlayOneShot(audioClips[1]);
                break;
            case "deccell":
                audioSource.PlayOneShot(audioClips[2]);
                break;
            case "stop":
                audioSource.Pause();
                break;

        }
    }
}
