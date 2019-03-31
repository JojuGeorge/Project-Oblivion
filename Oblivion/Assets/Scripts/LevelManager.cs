using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject currentCheckPoint;

    private PlayerController player;


    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        //Debug.Log("Player respawn");
        player.transform.position = currentCheckPoint.transform.position;
    }
}
