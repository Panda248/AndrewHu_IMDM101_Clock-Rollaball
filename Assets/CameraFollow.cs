using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject cube;
    private Vector3 vecToCubeDisp;
    private Vector3 vecToCube;

   

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        vecToCube = transform.position - cube.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        vecToCubeDisp = vecToCube + cube.transform.position;
        //if((transform.position + vecToCube - vecToCubeDisp).magnitude > 1)
        //{
        //    transform.position += (transform.position + vecToCubeDisp) * 0.5f;
        //}
        //
        transform.position = vecToCubeDisp;

        
    }

    
}
