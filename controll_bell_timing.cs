using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll_bell_timing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<AudioSource>().Play(0);
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            GetComponent<AudioSource>().Pause();
        }

    }
}
