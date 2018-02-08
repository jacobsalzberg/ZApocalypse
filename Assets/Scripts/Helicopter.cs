using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {


    private bool called = false;
    public AudioClip callSound;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("CallHeli") & !called) //done only once
        {
            called = true;
            Debug.Log("Heli called");
            audioSource.clip = callSound;
            audioSource.Play();

        }
        else
        {
            
        }
    }
}
