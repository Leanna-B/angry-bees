using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeScript : MonoBehaviour
{

    //Rigidbody rb;
    //new Vector3 beemov;
    // Start is called before the first frame update
    void Start()
    {
        //beemov = 
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.position += transform.forward * Time.deltaTime;

    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("test");
        OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
        OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
        Destroy(gameObject);



    }


}
