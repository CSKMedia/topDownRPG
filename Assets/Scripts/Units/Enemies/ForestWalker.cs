using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestWalker : EnemyUnitBase
{

//     public SO_Enemy enemyStats;

//     private float baseHealth;
//     private float baseDamage;
//     private float baseArmor;

//     public float maxHealth = 100f;
//     public float currentHealth;

//     private void Start() {
//         baseDamage = enemyStats.BaseStats.baseDamage;
//         baseHealth = enemyStats.BaseStats.baseHealth;
//         currentHealth = baseHealth;
//     }

//     private void OnTriggerEnter2D(Collider2D collision) {
//         if(collision.gameObject.CompareTag("Player"))
//         {
//             Debug.Log(gameObject.name + " Collided");
//             // Destroy(gameObject);
//             // OnHealthPotionCollected?.Invoke(10f);
//             GameManager.Instance.playerHealth.TakeDamage(baseDamage);
//         }
//     }


//   // Update is called once per frame
//     public void TakeDamage(float amount)
//     {
//         currentHealth -= amount;
//         if(currentHealth <=  0) {
//             // if dead
//             currentHealth = 0;
//             Debug.Log("Enemy died");
//         }

//         // OnDamageTaken?.Invoke(amount);
//         // DisplayDamagePopup(amount);
//     }

}
