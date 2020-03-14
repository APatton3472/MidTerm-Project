using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    float moveSpeed = 10f;
    
    public Transform target;
    
    
    void Start()
    {
        
    }
    void Update()
    {
        FindClosestEnemy();

        Destroy(gameObject, 5f);
    }

    void FindClosestEnemy()
    {
        float distanceToClosestEnemy = Mathf.Infinity;
        EnemyScript closestEnemy = null;
        EnemyScript[] allEnemies = GameObject.FindObjectsOfType<EnemyScript>();
        
        foreach(EnemyScript currentEnemy in allEnemies)
        {
            float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceToClosestEnemy)
            {
                distanceToClosestEnemy = distanceToEnemy;
                closestEnemy = currentEnemy;
            }
        }
        
        float step = moveSpeed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(this.transform.position, closestEnemy.transform.position, step);
    }


    private void OnTriggerEnter(Collider rigidbody)
    {
        if (rigidbody.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
    
}
