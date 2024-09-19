using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWorldManipulation : MonoBehaviour
{

    private Ray mouseRay;
    private RaycastHit hitData;
    private GameObject selectedObject;
    private float selectedObjectDist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseManipulateObject();

        MouseSelectObject();
    }


    void MouseManipulateObject()
    {
        if(selectedObject != null)
        {
            if(selectedObject.GetComponent<AnchoredObject>() != null)
            {
                MouseRotateAnchoredObject();
            }
            else
            {
                MouseTransformObject();
            }
            
        }
    }
    void MouseTransformObject()
    {
        Vector3 targetTransform = mouseRay.direction.normalized * selectedObjectDist;
        selectedObject.transform.position = targetTransform;
    }

    void MouseRotateAnchoredObject()
    {
        
    }
    void MouseSelectObject()
    {
        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Input.GetMouseButton(0))
        {
            if (Physics.Raycast(mouseRay, out hitData, 1000))
            {
                if (selectedObject != hitData.transform.gameObject && selectedObject == null)
                {
                    selectedObject = hitData.transform.gameObject;
                    selectedObject.GetComponent<Renderer>().material.color = Color.red;
                    selectedObjectDist = hitData.distance;
                }

            }
        }
        else
        {
            if (selectedObject != null)
            {
                selectedObject.GetComponent<Renderer>().material.color = Color.white;
                selectedObject = null;
            }
        }
    }
}
