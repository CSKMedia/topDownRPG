using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public static event Action <float> OnHealthPotionCollected;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(gameObject.name + " Collided");
            Destroy(gameObject);
            OnHealthPotionCollected?.Invoke(20f);
        }
    }
}
