using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    Vector3 moveDir;

    Rigidbody rigidBody;

    //for rotating the player
    public float rotationSpeed;
    private float rotation;

    //for firing
    public GameObject laser;
    public Transform fireingPoint1, fireingPoint2;

    void Start() {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update () {
        rotation = Input.GetAxisRaw("Horizontal");
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;


        if (Input.GetButtonDown("Fire1")){
            Fire();
        }
    }

    void FixedUpdate () {
        rigidBody.MovePosition(rigidBody.position + transform.TransformDirection(moveDir) * moveSpeed * Time.deltaTime);

        //player rotation mechanics
        Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.fixedDeltaTime;
        Quaternion deltaRotation = Quaternion.Euler(yRotation);
        Quaternion targetRotation = rigidBody.rotation * deltaRotation;
        rigidBody.MoveRotation(Quaternion.Slerp(rigidBody.rotation, targetRotation, 50f * Time.deltaTime));
    }


    //fireing mechanics
    public void Fire() {
        Instantiate(laser, fireingPoint1.position, fireingPoint1.rotation);
        Instantiate(laser, fireingPoint2.position, fireingPoint2.rotation);
    }

}
