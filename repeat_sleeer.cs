using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeat_sleeer : MonoBehaviour
{
    public GameObject sleeper_prefab;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = -10000; i < 10000; i++)
        {
            Instantiate(sleeper_prefab, new Vector3(sleeper_prefab.transform.position.x, sleeper_prefab.transform.position.y, i * 0.6f), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
