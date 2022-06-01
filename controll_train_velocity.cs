using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll_train_velocity : MonoBehaviour
{
    public Rigidbody[] rb;
    public int m_Thrust = 0;
    // Start is called before the first frame update
    void Start()
    {
        //rb = new Rigidbody[rb.Length];
        
        
    }
     
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_Thrust += 1;
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_Thrust -= 1;
        }

        

        for(int i = 0; i < rb.Length; i++)
        {
            rb[i].AddForce(transform.forward * m_Thrust);
        }

        //Debug.Log(m_Thrust);
        
        
    }
}
