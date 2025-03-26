using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomInOut : MonoBehaviour
{
    Camera FallbackObjects;
    public float zoomAMT = 60f; 

    void Start()
    {
        FallbackObjects = GetComponent<Camera>(); 
    }

    void Update()
    {
        FallbackObjects.fieldOfView = zoomAMT; 
    }

    public void sliderZoom(float zoom)
    {
        zoomAMT = zoom; 
    }
}
