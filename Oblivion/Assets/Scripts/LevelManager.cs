using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject currentCheckPoint;
    private PlayerController player;
    private PlayerHealthManager healthManager;


    public int penaltyOnDeath;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        healthManager = FindObjectOfType<PlayerHealthManager>();
    }

    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        //Debug.Log("Player respawn");
        player.transform.position = currentCheckPoint.transform.position;
        ScoreManager.AddPoints(-penaltyOnDeath);
        healthManager.FullHealth();
        healthManager.isDead = false;
    }
}
