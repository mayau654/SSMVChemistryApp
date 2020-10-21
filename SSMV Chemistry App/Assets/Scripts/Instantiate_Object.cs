using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Object : MonoBehaviour
{
    public GameObject myPrefabObject = null; //set to none

    public void CreateAtom()
    {
     Instantiate //creates the object at the set position with no rotation
            (
            myPrefabObject,
            transform.position,
            Quaternion.identity
             );   
    }
}
