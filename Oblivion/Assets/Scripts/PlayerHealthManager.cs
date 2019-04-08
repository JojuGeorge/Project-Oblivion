using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public int givenHealth;
    public static int maxPlayerHealth;
    public static int playerHealth;

    private LevelManager levelManager;

    // Text text;
    public Slider healthBar;

    public bool isDead;

    void Start()
    {
        maxPlayerHealth = givenHealth;
        playerHealth = maxPlayerHealth;
        levelManager = FindObjectOfType<LevelManager>();
        // text = GetComponent<Text>();
        healthBar = GetComponent<Slider>();
        isDead = false;
    }

    void Update()
    {
        if(playerHealth <= 0  && !isDead )
        {
            // Destroy(gameObject);
            playerHealth = 0;
            isDead = true;

            levelManager.RespawnPlayer();
        }

        // text.text = "" + playerHealth;
        healthBar.value = playerHealth;
    }

    public static void HurtPlayer(int damageToGive)
    {
        playerHealth -= damageToGive;
    }


    public void FullHealth()
    {
        playerHealth = maxPlayerHealth;
    }


    public static void AddHealth(int addHealth )
    {
        if(playerHealth >= maxPlayerHealth)
        {
            playerHealth = maxPlayerHealth;
        }
        else
        {
            playerHealth += addHealth;
        }
    }
}
