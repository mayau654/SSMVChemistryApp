using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
    


        if (other.gameObject.CompareTag("Bond")) //if the gameobject is tagged "Bond"
        {
            other.GetComponent<Rigidbody>().MovePosition(transform.position); //then get the rigidbody of "Square" and move the rigidbody of "Bond" to the transform attatched to the rigidbody of "Square"


        }
    }

}