using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    private Vector3 vecToPlayerDisp;
    private Vector3 vecToPlayer;

   

    // Start is called before the first frame update
    void Start()
    {
        vecToPlayer = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        vecToPlayerDisp = vecToPlayer + player.transform.position;
        //if((transform.position + vecToCube - vecToCubeDisp).magnitude > 1)
        //{
        //    transform.position += (transform.position + vecToCubeDisp) * 0.5f;
        //}
        //
        transform.position = vecToPlayerDisp;

        
    }

    
}
