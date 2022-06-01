using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll_force_sound_timing : MonoBehaviour
{
    private Rigidbody rigidbody;
    //public AudioClip[] audioclips;
    //private AudioSource ads;
    controll_train_velocity ctv;
    public GameObject ctv_ob;
    private bool flag1;
    private bool flag2;
    private bool flag3;
    public GameObject cs_ob;
    controll_sounds cs;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        //ads = GetComponent<AudioSource>();
        ctv = ctv_ob.GetComponent<controll_train_velocity>();
        flag1 = false;
        flag2 = true;
        flag3 = false;
        cs = this.GetComponent<controll_sounds>();

    }

    // Update is called once per frame
    void Update()
    {
        if (ctv.m_Thrust > 0 && flag1 == false)
        {
            flag1 = true;
            flag2 = false;
            flag3 = false;
            cs.Play("accell");
            print("â¡ë¨");
        }

        else if(ctv.m_Thrust==0 && flag2 == false)
        {
            flag2 = true;
            flag3 = false;
            flag1 = false;
            cs.Play("joko");
            print("èôçs");
        }

        else if(ctv.m_Thrust < 0 && flag3 == false)
        {
            flag3 = true;
            flag1 = false;
            flag2 = false;
            cs.Play("deccell");
            print("å∏ë¨");
        }

        else if(rigidbody.velocity.z<=0)
        {
            cs.Play("stop");
            ctv.m_Thrust = 0;
            rigidbody.velocity = Vector3.zero;
            print("í‚é~íÜ");
            
        }




        //Debug.Log(ctv.m_Thrust);
        //Debug.Log(flag1);





    }
}
