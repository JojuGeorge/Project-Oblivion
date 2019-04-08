using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyCannonController : MonoBehaviour
{

    private PlayerController player;

    public GameObject laser;
    public Transform fireingPoint;
    private float timeBtwShots;
    public float startTimeBtwShots;


    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        timeBtwShots = startTimeBtwShots;
    }

    void Update()
    {
        // so that no error happens when player is destroyed. since this script looks for the player always
        if (player == null)
            return;

        if(timeBtwShots <= 0)
        {
            Instantiate(laser, fireingPoint.position, fireingPoint.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3(player.transform.position.x,
            transform.position.y, player.transform.position.z);
        transform.LookAt(targetPosition);
    }
}
