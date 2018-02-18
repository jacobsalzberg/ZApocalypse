using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Helicopter helicopter;
    public Transform playerSpawnPoints; // the parent of the spawn points

    public AudioClip whatHappened;


    private Transform[] spawnPoints;
    private bool lastToggle = false;
    private bool reSpawn = false;
    private AudioSource innerVoice; 

    // Use this for initialization
    void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        //print(spawnPoints.Length); //check how many things get out --> gets 4

        AudioSource[] audioSources = GetComponents<AudioSource>();
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.priority == 1)
            {
                innerVoice = audioSource;
            }
        }

        innerVoice.clip = whatHappened;
        innerVoice.Play();
    }
	
	// Update is called once per frame
	void Update () {
		if (lastToggle != reSpawn)
        {
            Respawn();
            reSpawn = false;
        } else
        {
            lastToggle = reSpawn;
        }
	}

    private void Respawn ()
    {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].transform.position;
    }

    void OnFindClearArea ()
    {
        Debug.Log("found clear area");
        helicopter.Call();
        //Deploy Flare
    }
}
