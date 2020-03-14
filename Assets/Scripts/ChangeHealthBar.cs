using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHealthBar : MonoBehaviour
{
    [SerializeField] private Health healthBar;
    public float health = 1f;
    

    void Update()
    {
        if (health <= 0f)
        {
            Application.LoadLevel(5);
        }
        
        
    }
    void OnTriggerEnter(Collider rigidbody)
    {
        if (rigidbody.gameObject.tag == "Enemy")
        {
            EnemyTotalCount.EnemiesKilled++;
            health = health - .1f;
            healthBar.SetSize(health);
        }
    }
    
}
