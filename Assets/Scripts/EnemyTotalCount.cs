using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTotalCount : MonoBehaviour
{
    public static int EnemiesKilled = 0;
    public int enemies = 0;
    public int MaxKilled = 15;
    public int nextlevel = 2;

    void Update()
    {
        enemies = EnemiesKilled;
        if (EnemiesKilled >= MaxKilled)
        {
            
            Application.LoadLevel(nextlevel);
        }
        
    }
}
