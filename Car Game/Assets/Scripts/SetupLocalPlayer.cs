using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

    

	// Use this for initialization
	void Start ()
    {
        if (isLocalPlayer)
        {
            GetComponent<Drive>().enabled = true;
            Camera.main.transform.position = transform.up * 0.6f;
            //Camera.main.transform.LookAt(this.transform.position);
            //Camera.main.transform.parent = this.transform;
        }
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
