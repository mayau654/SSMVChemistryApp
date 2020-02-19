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
        // movement code off of internet

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }



    public void ZoomOnScroll(float value)
    {
        Debug.Log(value);

    }

}
