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
    void FixedUpdate()
    {
        Controls();
    }

    void Controls()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rbRef.velocity += new Vector3(0, 10, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rbRef.AddForce(new Vector3(0, 0, 10));
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rbRef.AddForce(new Vector3(0, 0, -10));
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rbRef.AddForce(new Vector3(-10, 0, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rbRef.AddForce(new Vector3(10, 0, 0));
        }
    }
}
