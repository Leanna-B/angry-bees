using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_one : MonoBehaviour{
    new AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource> ();
    }
	
	void OnCollisionEnter(Collision collision){  

if (collision.gameObject.name == "Bee") {

  audio.Play ();
   }
  }
 }
