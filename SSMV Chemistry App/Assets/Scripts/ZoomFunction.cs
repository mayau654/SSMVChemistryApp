using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomFunction : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    float OldValue = 0.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // movement code off of internet
    }



    public void ZoomOnScroll(float value)
    {
        Debug.Log(value);
        if (value < OldValue)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (value > OldValue)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (value == 0.0f)
        {
            transform.position = new Vector3(0, 1, -10);
        }
        if (value == 1.0f)
        {
            transform.position = new Vector3(0, 1, -5);
        }
        OldValue = value;
    }

}
