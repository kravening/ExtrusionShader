using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSizeModifier : MonoBehaviour {
    float sizeModifier = 0;
    float maxSizeModifier = 0.5f;
    float minSizeModifier = -0.25f;
    float growthRate = 0.00125f;

    int growthState = 0; // 0 = not growing, 1 = growing 2 = shrinking

    SphereCollider sphereCollider;
    Renderer renderer;


	// Use this for initialization
	void Start () {
        sphereCollider = GetComponent<SphereCollider>();
        renderer = GetComponent<Renderer>();
	}

    void Update()
    {
        switch (growthState){
            case 0:
                break;
            case 1:
                IncreaseSizeModifier();
                break;
            case 2:
                DecreaseSizeModifier();
                break;
        }
    }

    public void IncreaseSizeModifier()
    {
        if (sizeModifier < maxSizeModifier) {
            sizeModifier += growthRate;
        }
        else
        {
            sizeModifier = maxSizeModifier;
        }
        ApplyModifier();
    }

    public void DecreaseSizeModifier()
    {
        if (sizeModifier > minSizeModifier)
        {
            sizeModifier -= growthRate;
        }
        else
        {
            sizeModifier = minSizeModifier;
        }
        ApplyModifier();
    }

    private void ApplyModifier()
    {
        sphereCollider.radius = 0.5f + sizeModifier;
        renderer.material.SetFloat("_Amount", sizeModifier);
    }

    public int GrowthState
    {
        set { growthState = value; }
    }
}
