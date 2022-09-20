using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehavior : MonoBehaviour
{
    public bool canRun = true;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        Debug.Log("Start");
        yield return wfsObj;
        Debug.Log("Late Start");

        while(canRun)
        {
            yield return wffuObj;
            Debug.Log("Run on start");
        }
    }
}
