using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class indicate_distance_to_nextStation : MonoBehaviour
{
    public GameObject station;
    public Slider slider;
    public GameObject train;
    private Vector3 distance;
    private Vector3 train_pos;
    private Vector3 station_pos;
    private float indicater;
    private GameObject nextStation;
    private Rigidbody rb_train;
    private float distance_first;
    int i;


    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        rb_train = train.GetComponent<Rigidbody>();
        //distance_first = Math.Abs(train.transform.position.z - stations[i].transform.position.z);
        slider.maxValue = Math.Abs(station.transform.position.z - train.transform.position.z);
        slider.minValue = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        station_pos = station.transform.position;
        train_pos = train.transform.position;
        distance = station_pos - train_pos;

        indicater = Math.Abs(distance.z) ;

        slider.value = indicater;

        if (rb_train.velocity.z < 0)
        {
            i += 1;
            
        }
        
    }
}
