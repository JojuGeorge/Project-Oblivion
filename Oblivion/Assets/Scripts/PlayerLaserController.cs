using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserController : MonoBehaviour {

    public float fireingSpeed;

	void Start () {
		
	}
	
	void Update () {
        transform.position += transform.forward * Time.deltaTime * fireingSpeed;
    }
}
