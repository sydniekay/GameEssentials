using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
    
    public IntData counterNum;

    public bool canRun;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;

    private WaitForFixedUpdate wffuObj;


    private void Start()
    { 
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        
        startEvent.Invoke();   
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    private IEnumerator Counting()
    {
        startCountEvent.Invoke();

        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }
    }
}
