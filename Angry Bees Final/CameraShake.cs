using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{


    public Animator anim;

    bool countdown = false;
    float cd = 0f;




    void Start()
    {
        //anim = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
       // Debug.Log("started");
       if (countdown == true)
        {
            cd += 1f * Time.deltaTime;
        }

       if(cd >= 1f)
        {
            anim.SetBool("shake", false);
            countdown = false;
            cd = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        anim.SetBool("shake", true);
        countdown = true;
    }


}
