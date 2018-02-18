﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints; // the parent of the spawn points

    private Transform[] spawnPoints;
    private bool lastRespawnToggle = false;
    private bool reSpawn = false;

    // Use this for initialization
    void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        //print(spawnPoints.Length); //check how many things get out --> gets 4

        
    }
	
	// Update is called once per frame
	void Update () {
		if (lastRespawnToggle != reSpawn)
        {
            Respawn();
            reSpawn = false;
        } else
        {
            lastRespawnToggle = reSpawn;
        }
	}

    private void Respawn ()
    {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].transform.position;
    }

    void OnFindClearArea ()
    {
        Invoke("DropFlare", 3f);
    }

    void DropFlare()
    {
        // drop a flare
    }
}
