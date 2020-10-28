using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 mOffset; //mouse offset

    private float mZCoord; //z coordinate of mouse

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z; //This gets the Z coordinates of the gameobject that the mouse clicks and turns it into the mouse z coordinate

        mOffset = gameObject.transform.position - GetMouseWorldPos(); // mouse offset = world position of the gameobject - mouse world position
    }

    private Vector3 GetMouseWorldPos() //gets the vector3 values from the world position of the mouse
    {
        Vector3 mousePoint = Input.mousePosition; //mouse position (x,y)

        mousePoint.z = mZCoord; //z coordinate of gameobject on screen

        return Camera.main.ScreenToWorldPoint(mousePoint); //transforms the 2d coordinates of the mouse to 3d coordinates of the game through mousePoint
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset; //transforms the gameobject (world position of the gameobject + mouse offset)
    }
}