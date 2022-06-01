using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll_start_sound_timing : MonoBehaviour
{
    public GameObject[] adsOb;
    private AudioSource[] ads;
    public GameObject train;
    // Start is called before the first frame update
    void Start()
    {
        ads = new AudioSource[adsOb.Length];
        for(int i = 0; i < adsOb.Length; i++)
        {
            ads[i] = adsOb[i].GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (train.transform.localPosition.z < 80 && train.transform.localPosition.z > -80)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
            {
                ads[0].Play(0);
            }

            if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.Space))
            {
                ads[0].Pause();
            }

            else
            {
                ads[1].Play(0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ads[2].Play(0);
        }

        else
        {
            for (int i = 0; i < adsOb.Length; i++)
            {
                ads[i].Pause();
            }

        }

        

        
        

        
        
    }
}
