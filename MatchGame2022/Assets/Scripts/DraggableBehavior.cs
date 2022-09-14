using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    
    void Start()
    {
        cameraObj = Camera.main;
    }

    /* We're creating a bool inside of the OnMouseDown() function,
     which detects when you click an object with the draggable attribute.*/
    public IEnumerator OnMouseDown()
    {
        draggable = true;
        while (draggable)
        {
            // We use WaitForFixedUpdate instead of the Update() function.
            yield return new WaitForFixedUpdate();
            // now we have to tell the object to do something
            Debug.Log("Drag");
        }
    }
    
    // Turning off our while loop with OnMouseUp()
    private void OnMouseUp()
    {
        draggable = false;
    }
    
}
