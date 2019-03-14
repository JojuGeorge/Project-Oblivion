using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour {

    public FauxGravityAttractor attractor;
    Rigidbody rigidBody;


	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        attractor = FindObjectOfType<FauxGravityAttractor>();

        // rotation and the gravity are controlled by the Attrack() in FausGravityAttractor.cs
        rigidBody.constraints = RigidbodyConstraints.FreezeRotation;
        rigidBody.useGravity = false;
	}
	
	void Update () {
        attractor.Attract(transform);
	}
}
