using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Enemy[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = FindObjectsOfType<Enemy>();
        SetDamagePointsTo(0);
    }


    void SetDamagePointsTo(int newValue)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].damagePoints = newValue;
        }
    }
}
