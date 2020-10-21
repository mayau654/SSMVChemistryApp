using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public Canvas canvas;
    public bool a = false;
    public void Joe() //Attatch Joe to a gameobject and clicking the gameobject will make the canvas appear/dissapear
    {
    if (a == false) //if gameobject is clicked and the canvas is off, enable the canvas
        {
            a = true;
            canvas.enabled = true;
        }
    else if (a == true) //if gameobject is clicked and canvas is off, disable the canvas
        {
            a = false;
            canvas.enabled = false;
        }
    }
}
