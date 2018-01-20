using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointActivation : MonoBehaviour
{

    public GameObject spawnPoint;

	// Use this for initialization
	void Start ()
    {
        spawnPoint.tag = "Open";
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            spawnPoint.tag = "Used";
        }
    }
}
