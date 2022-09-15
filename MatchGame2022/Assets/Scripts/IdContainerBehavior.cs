using System;
using UnityEngine;
using UnityEngine.Events;

public class IdContainerBehavior : MonoBehaviour
{
    // All this script does is literally just contain the ID of an object.
    public ID idObj;
    public UnityEvent startEvent;

    public void Start()
    {
        startEvent.Invoke();
    }
}
