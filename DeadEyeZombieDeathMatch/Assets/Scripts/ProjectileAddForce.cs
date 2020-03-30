using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAddForce : MonoBehaviour {
    Rigidbody rigidB;
    public float shootForce = 2000;

    void OnEnable () {
        rigidB = GetComponent<Rigidbody>();
        rigidB.velocity = Vector3.zero;
        ApplyForce();
	}
	
	// Update is called once per frame
	void Update () {
        SpinObject();
	}

    void ApplyForce()
    {
        rigidB.AddRelativeForce(Vector3.right * shootForce);
    }

    void SpinObject()
    {
        //spin arrow
    }
}
