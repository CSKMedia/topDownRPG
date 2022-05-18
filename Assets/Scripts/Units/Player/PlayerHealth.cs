using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    [SerializeField] private GameObject floatingTextPrefab;

    public static event Action <float> OnDamageTaken;
    public static event Action <float> OnHealTaken;


    private void OnEnable() {
        HealthPotion.OnHealthPotionCollected += Heal;
    }

    private void OnDisable() {
        HealthPotion.OnHealthPotionCollected -= Heal;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if(currentHealth <=  0) {
            // if dead
            currentHealth = 0;
            Debug.Log("We died");
        }
        OnDamageTaken?.Invoke(amount);
        DisplayDamagePopup(amount);
    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        if(currentHealth >  maxHealth) currentHealth = maxHealth;
        OnHealTaken?.Invoke(amount);
        DisplayHealthPopup(amount);
    }


    public void DisplayHealthPopup(float amount) {
        if(floatingTextPrefab) {
            GameObject prefab = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
            prefab.GetComponentInChildren<TextMesh>().text = amount.ToString();
        }
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
