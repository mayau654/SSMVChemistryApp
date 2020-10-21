using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomScript : MonoBehaviour
{

    private Camera cam;
    private float targetZoom;
    private float zoomFactor = 3f;
    [SerializeField] private float zoomLerpSpeed = 10; //SerializeField allows Unity to store and reconstruct this value

    void Start()
    {
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        float scrollData;
        scrollData = Input.GetAxis("Mouse ScrollWheel");

        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, 4.5f, 8f); //restricts the number between min and max values. In this case it's 4.5 and 8
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed); //when deltatime = 0 the lerp is cam size. when deltatime = 1 the lerp is target zoom. when deltatime is between 0 and 1 the lerp is between cam and zoom
    }
}
