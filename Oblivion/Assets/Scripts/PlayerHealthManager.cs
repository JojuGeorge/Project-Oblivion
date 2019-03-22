using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public int maxPlayerHealth;
    public static int playerHealth;


    void Start()
    {
        playerHealth = maxPlayerHealth;
    }

    void Update()
    {
        if(playerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public static void HurtPlayer(int damageToGive)
    {
        playerHealth -= damageToGive;
    }
}
