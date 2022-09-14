using System.Collections;
using UnityEngine;
using UnityEngine.Events;


public class DraggableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    
    void Start()
    {
        cameraObj = Camera.main;
    }

    /* We're creating a bool inside of the OnMouseDown() function,
     which detects when you click an object with the draggable attribute.*/
    public IEnumerator OnMouseDown()
    {
        
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        yield return new WaitForFixedUpdate();
        
        draggable = true;
        
        startDragEvent.Invoke();
        
        while (draggable)
        {
            // We use WaitForFixedUpdate instead of the Update() function.
            yield return new WaitForFixedUpdate();
            // now we tell it to get the position of the mouse
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            // then tell the object to move to that position
            transform.position = position;
        }
    }
    
    // Turning off our while loop with OnMouseUp()
    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
    
}
