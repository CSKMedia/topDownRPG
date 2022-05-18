using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public PlayerHealth playerHealth;

    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }

    private void Update() {

        // test damage
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            playerHealth.TakeDamage(10);
        }
    }
}
