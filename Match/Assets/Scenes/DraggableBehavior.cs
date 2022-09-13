using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehavior : MonoBehaviour
{
    
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position;

    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        draggable = true;

        while (draggable)
        {
            yeild return new WaitForFixedUpdate(); 
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition);
        }
    }
    
    private void OnMouseUp()
    {
        draggable = false;
    }
}
