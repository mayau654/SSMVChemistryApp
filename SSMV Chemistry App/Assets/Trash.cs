using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trash : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) //destroys atoms that touch the flame (aka trash) icon
    {
        if (other.gameObject.CompareTag("Atom")) //if other gameobject with the tag "Atom" touches the object
        {
            Destroy(other.gameObject); //destroy the other gameobject
        }
    }
}
