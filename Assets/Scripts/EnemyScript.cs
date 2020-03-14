using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Nodes nodeManager;
    public float Speed = 1f;
    int currentIndex = 0;
    float currentPercentage = 0f;
    public float EnemyHealth = 10f;
    

    private void Start()
    {
        nodeManager = Nodes.Instance;
        

    }

    // Update is called once per frame
    void Update()
    {
        currentPercentage = currentPercentage + (Speed * Time.deltaTime);

        Vector3 A = nodeManager.nodes[currentIndex].transform.position;
        Vector3 B = nodeManager.nodes[(currentIndex+1) % nodeManager.nodes.Length].transform.position;
               
        Vector3 newPos = Vector3.Lerp( A, B, currentPercentage);

        this.transform.position = newPos;

        if (currentPercentage >= 1)
        {
            currentPercentage = 0;
            currentIndex = (currentIndex + 1) % (nodeManager.nodes.Length);
        }

        if (EnemyHealth <= 0)
        {
            EnemyTotalCount.EnemiesKilled += 1;
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter(Collider rigidbody)
    {
        if (rigidbody.gameObject.tag == "Finish")
        {
            
            Destroy(gameObject);
        }
        if (rigidbody.gameObject.tag == "Arrow")
        {
            EnemyHealth = EnemyHealth - 2.5f;
        }
        if (rigidbody.gameObject.tag == "Tower1")
        {
            EnemyHealth=EnemyHealth-5f;
        }
    }
    
}
