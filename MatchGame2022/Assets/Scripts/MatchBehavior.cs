using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    // Creating a match by comparing the two IDs to see if they are the same
    /* Matching the IDs versus the color itself, allows it to be dynamic,
     because you could change the scriptable object at any time, and the 
     unique ID of that object would still be the same.*/
    
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IdContainerBehavior>();
        if (tempObj == null) 
            return;
            
            
        var otherID = tempObj.idObj;
        
        
        /* Alternative code:
         * Debug.Log(message: otherID == idObj ? "Matched" : "No Match");
         */
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
        }
        
    }
}
