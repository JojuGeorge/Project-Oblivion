﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserController : MonoBehaviour
{

    public float speed;

    private Transform player;
    private Vector3 target;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector3(player.position.x, player.position.y, player.position.z);
    }

    void Update()
    {
        // transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}