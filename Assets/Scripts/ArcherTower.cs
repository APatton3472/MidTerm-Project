using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherTower : MonoBehaviour
{
    [SerializeField]
    GameObject arrow;

    public float fireRate;
    public float nextFire;

    void Start()
    {
        fireRate = 3f;
        nextFire += Time.deltaTime;
        Instantiate(arrow, transform.position, Quaternion.identity);
    }
    void Update()
    {
        Destroy(gameObject, 45f);
        nextFire += Time.deltaTime;
        if (nextFire >= fireRate)
        {
            Instantiate(arrow, transform.position, Quaternion.identity);
            nextFire = 0f;
        }
    }
    
}

