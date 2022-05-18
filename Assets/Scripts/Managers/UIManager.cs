using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI levelText;
    public PlayerHealth playerHealth;

    float hpValue;
    float levelValue;
    float maxValue;

    void Start()
    {
        maxValue = playerHealth.maxHealth;
        hpValue = maxValue;

        hpText.text = $"HP: {hpValue} / {maxValue}";
    }

    private void OnEnable() {
        PlayerHealth.OnHealTaken += IncrementHealthText;
        PlayerHealth.OnDamageTaken += DecrementHealthText;
    }

    private void OnDisable() {
        PlayerHealth.OnHealTaken -=  IncrementHealthText;
        PlayerHealth.OnDamageTaken -= DecrementHealthText;
    }

    public void IncrementHealthText(float healing)
    {
        hpValue += healing;
        if (hpValue > maxValue) hpValue = maxValue;
        hpText.text = $"HP: {hpValue} / {maxValue}";
    }

    public void DecrementHealthText(float damage)
    {
        hpValue -= damage;
        if (hpValue <= 0) hpValue = 0;
        hpText.text = $"HP: {hpValue} / {maxValue}";
    }

    public void levelUp()
    {
        levelValue ++;
        levelText.text = $"Level: {levelValue}";
    }

}
