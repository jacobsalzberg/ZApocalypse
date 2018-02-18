using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {


    private bool called = false;
    public AudioClip callSound;
    private AudioSource audioSource;

    private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
}
	
	// Update is called once per frame


    public void Call ()
    {
        if (!called)
        {
            called = true;
            Debug.Log("Heli called");
            audioSource.clip = callSound;
            audioSource.Play();
            rigidBody.velocity = new Vector3(0, 0, 50f);
        }
    }
}
