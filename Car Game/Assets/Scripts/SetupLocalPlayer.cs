using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

    public Camera cam; //Camera attached to the player
    // Spawnpoints
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;

    // Use this for initialization
    void Start ()
    {
        // Setting spawnpoint to gameobject
        spawnPoint1 = GameObject.Find("Spawn Point #1");
        spawnPoint2 = GameObject.Find("Spawn Point #2");
        spawnPoint3 = GameObject.Find("Spawn Point #3");
        spawnPoint4 = GameObject.Find("Spawn Point #4");
        if (isLocalPlayer)
        {
            GetComponent<Drive>().enabled = true; //Enables drive script, disabled for all but turned on the local player

            // Goes through spawnpoint gameobjects, if tag set to open, then will spawn the player
            if (spawnPoint1.tag == "Open")
            {
                Debug.Log("spawnpoint works");
                gameObject.transform.position = spawnPoint1.transform.position;
                spawnPoint1.tag = "Used";
                return;
            }
            if (spawnPoint2.tag == "Open")
            {
                gameObject.transform.position = spawnPoint2.transform.position;
                spawnPoint2.tag = "Used";
                return;
            }
            if (spawnPoint3.tag == "Open")
            {
                gameObject.transform.position = spawnPoint3.transform.position;
                spawnPoint3.tag = "Used";
                return;
            }
            if (spawnPoint4.tag == "Open")
            {
                gameObject.transform.position = spawnPoint4.transform.position;
                spawnPoint4.tag = "Used";
                return;
            }
        }
        if (!isLocalPlayer)
        {
            cam.enabled = false; //If not local player, all cameras in the scene get disabled
        }
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
