using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitBase : UnitBase
{
    public SO_Enemy enemyStats;

    private float baseHealth;
    private float baseDamage;
    private float baseArmor;

    public float currentHealth;
    [SerializeField] private GameObject floatingTextPrefab;

    private void Start() {
        baseDamage = enemyStats.BaseStats.baseDamage;
        baseHealth = enemyStats.BaseStats.baseHealth;
        currentHealth = baseHealth;
    }

  
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(gameObject.name + " Collided");
            // Destroy(gameObject);
            // OnHealthPotionCollected?.Invoke(10f);
            GameManager.Instance.playerHealth.TakeDamage(baseDamage);
        }
    }


  // Update is called once per frame
    public override void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if(currentHealth <=  0) {
            // if dead
            currentHealth = 0;
            Debug.Log("Enemy died");
            Destroy(gameObject);
        }

        // OnDamageTaken?.Invoke(amount);
        DisplayDamagePopup(amount);
    }

    public void DisplayDamagePopup(float amount) {
        if(floatingTextPrefab) {
            GameObject prefab = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
            TextMesh damageText = prefab.GetComponentInChildren<TextMesh>();

            Color damageColor = Color.red;
            damageText.color = damageColor;
            damageText.text = amount.ToString();
        }
    }
}
