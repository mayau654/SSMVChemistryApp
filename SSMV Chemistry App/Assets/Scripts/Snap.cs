using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Atom"))
        {
            other.GetComponent<Rigidbody>().MovePosition(transform.position);
        }
    }
}