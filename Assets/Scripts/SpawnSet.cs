using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnSet : MonoBehaviour
{
    public Transform KnightPrefab;
    public Transform ArcherPrefab;
    public Transform spawnPoint;
    public GameObject knightbutton;
    public GameObject archerbutton;


    public void Knight()
    {
        Instantiate(KnightPrefab, spawnPoint.position, Quaternion.identity);
        knightbutton.SetActive(false);
        
    }
    public void Archer()
    {
        Instantiate(ArcherPrefab, spawnPoint.position, Quaternion.identity);
        archerbutton.SetActive(false);
    }
}
