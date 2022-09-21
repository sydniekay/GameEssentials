using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    
    public IntData counterNum;
    
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;

    private WaitForFixedUpdate wffuObj;
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        
        startEvent.Invoke();

        while (counterNum.value > 0)
        {
            repeatEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endEvent.Invoke();
    }
}
