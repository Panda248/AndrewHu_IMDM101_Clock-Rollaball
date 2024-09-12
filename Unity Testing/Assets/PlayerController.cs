using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbRef;
    // Start is called before the first frame update
    void Start()
    {
        rbRef  = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(rbRef.velocity.x != 0)
        //{
        //    rbRef.velocity.x -= 1;
        //}
        //if (rbRef.velocity.z != 0)
        //{
        //    rbRef.velocity.z -= 1;
        //}
        Controls();
    }

    void Controls()
    {
        Vector3 vel = rbRef.velocity;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rbRef.position += new Vector3(0, 10, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            vel.z = 10;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            vel.z = -10;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            vel.x = -10;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            vel.x = 10;
        }

        rbRef.velocity = vel;
    }
}
