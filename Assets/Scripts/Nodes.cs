using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{
    public GameObject[] nodes;

    public static Nodes Instance;
    
    void Start()
    {
        Instance = this;
        
    }
}
