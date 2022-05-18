using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class UnitBase : MonoBehaviour
{
    // could also have dying, animation triggers etc
    public Stats Stats { get; private set;}
    public virtual void SetStats(Stats stats) => Stats = stats;
    public virtual void TakeDamage(float damage){
        Debug.Log("Taking damage" + damage);
    }

    public virtual void DealDamage(float damage){
        Debug.Log("Dealing damage" + damage);
    }
}
