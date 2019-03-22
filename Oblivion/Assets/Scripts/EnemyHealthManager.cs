using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{

    public int enemyHealth;
    void Start()
    {
        
    }

    void Update()
    {
        if (enemyHealth <= 0) {
            Destroy(gameObject);
        }
    }

    public void GiveDamage(int damageToGive) {
        enemyHealth -= damageToGive;
    }
}
