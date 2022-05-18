using System;
using UnityEngine;

public abstract class SO_EnemyBase : ScriptableObject {
  public EnemyType _enemyType;

  [SerializeField]
  private Stats _stats;

  public Stats BaseStats => _stats;

  // used in game
  public EnemyUnitBase prefab;

  // used in menus
  public string description;
  public Sprite MenuSprite;
}

  [Serializable]
  public struct Stats {
    public float baseHealth;
    public float baseDamage;
    public float baseArmor;
  }

  [Serializable]
  public enum EnemyType
  {
    Human = 0,
    Undead = 1,
  }



