using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public int maxPlayerHealth;
    public static int playerHealth;

    private LevelManager levelManager;


    void Start()
    {
        playerHealth = maxPlayerHealth;
        levelManager = FindObjectOfType<LevelManager>();
    }

    void Update()
    {
        if(playerHealth <= 0)
        {
           // Destroy(gameObject);
            playerHealth = maxPlayerHealth;
            levelManager.RespawnPlayer();
        }
    }

    public static void HurtPlayer(int damageToGive)
    {
        playerHealth -= damageToGive;
    }
}
