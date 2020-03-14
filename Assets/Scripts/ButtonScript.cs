using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void play()
    {
        Application.LoadLevel(1);
    }
    public void MM()
    {
        Application.LoadLevel(0);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void credits()
    {
        Application.LoadLevel(6);
    }
}
