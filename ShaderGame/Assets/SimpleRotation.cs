using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A) == true)
        {
            this.transform.Rotate(new Vector3(0,0,0.5f));
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            this.transform.Rotate(new Vector3(0, 0, -0.5f));
        }
        if (Input.GetKey(KeyCode.W) == true)
        {
            this.transform.Rotate(new Vector3(.5f, 0, 0));
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            this.transform.Rotate(new Vector3(-.5f, 0, 0));
        }
    }
}
