using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    private float secondsAngSpeed = 6;
    private float minutesAngSpeed = 0.1f;
    private float hoursAngSpeed = 0.00166f;

    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log(DateTime.Now);
        hoursPivot.localRotation = Quaternion.Euler(DateTime.Now.Hour * 30, 0, 0);
        minutesPivot.localRotation = Quaternion.Euler(DateTime.Now.Minute * 6f, 0, 0);
        secondsPivot.localRotation = Quaternion.Euler(DateTime.Now.Second * 6f, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        hoursPivot.Rotate(new Vector3(hoursAngSpeed * 0.02f, 0, 0));
        minutesPivot.Rotate(new Vector3(minutesAngSpeed * 0.02f, 0, 0));
        secondsPivot.Rotate(new Vector3(secondsAngSpeed *0.02f, 0, 0));
    }
}
