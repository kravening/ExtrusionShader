using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "IncreaseCube")
        {
            gameObject.GetComponent<SphereSizeModifier>().GrowthState = 1;
        }
        else if(col.gameObject.name == "DecreaseCube")
        {
            gameObject.GetComponent<SphereSizeModifier>().GrowthState = 2;
        }
    }
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "IncreaseCube" || col.gameObject.name == "DecreaseCube")
        {
            gameObject.GetComponent<SphereSizeModifier>().GrowthState = 0;
        }
    }
}
