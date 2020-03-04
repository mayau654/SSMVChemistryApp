using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomFunction : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void ZoomOnScroll(float value)
    {
        //prints value of scrollbar
        Debug.Log(value);
        //zooms in/out
        float v = (value * 5);
        transform.position = new Vector3(0, 1, -10 + v);
    }

}