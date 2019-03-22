using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour {

    //  THIS SCRIPT WORKS AS THE PLANETS GRAVITATION PULL. PULLING ALL THE FauxGravityBody.cs script attached objects to it

    public float gravity = -10f;

    // Transform body is the objects to be under the faux gravity
    public void Attract(Transform body) {
        Vector3 gravityUp = (body.position - transform.position).normalized;    //dir of the player/obj from the center of the planet
        Vector3 bodyUp = body.up;

        body.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;
        body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50 * Time.deltaTime);
    }
}
