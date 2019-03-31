using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{

    public int enemyHealth;
    public int pointsToGive;

    void Start()
    {
        
    }

    void Update()
    {
        if (enemyHealth <= 0) {
            ScoreManager.AddPoints(pointsToGive);
            Destroy(gameObject);
            
        }
    }

    public void GiveDamage(int damageToGive) {
        enemyHealth -= damageToGive;
    }
}
