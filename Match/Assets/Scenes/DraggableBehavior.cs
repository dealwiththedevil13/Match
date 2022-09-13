using System.Collections;
using UnityEngine;

public class DraggableBehavior : MonoBehaviour
{
    
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent

    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position -cameraObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yeild return new WaitForFixedUpdate();

        while (draggable)
        {
            yeild return new WaitForFixedUpdate(); 
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }
    
    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}
