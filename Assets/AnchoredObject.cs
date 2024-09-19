using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchoredObject : MonoBehaviour
{
    private Transform anchor;
    public void Start()
    {
        anchor = transform.parent;
    }
    public Transform GetAnchor()
    {
        return anchor;
    }
}
