using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower1 : MonoBehaviour
{
    public bool loop;
    public float frameSeconds = 1;
    //The file location of the sprites within the resources folder
    private SpriteRenderer spr;
    private Sprite[] sprites;
    private int frame = 0;
    public float deltaTime = 0;
    public GameObject knightbutton;
    public GameObject archerbutton;

    // Use this for initialization
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>("TowerSprite1");
    }

    // Update is called once per frame
    void Update()
    {
        //Keep track of the time that has passed
        deltaTime += Time.deltaTime;

        /*Loop to allow for multiple sprite frame 
         jumps in a single update call if needed
         Useful if frameSeconds is very small*/
        while (deltaTime >= frameSeconds)
        {
            deltaTime -= frameSeconds;
            frame++;
            if (loop)
                frame %= sprites.Length;
            //Max limit
            else if (frame >= sprites.Length)
                frame = sprites.Length - 1;
        }

        spr.sprite = sprites[frame];

        Destroy(gameObject, 45f);

        
    }
    
}

