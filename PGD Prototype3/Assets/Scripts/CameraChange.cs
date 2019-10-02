﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Cinemachine.CinemachineFreeLook Camera;
    public Cinemachine.CinemachineFreeLook Camera2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Camera.Priority = 9;
            Camera2.Priority = 10;
            GameObject.Find("YBot").GetComponent<MovementInput>().enabled = false;
        }

        if (Input.GetKey(KeyCode.X))
        {
            Camera.Priority = 10;
            Camera2.Priority = 9;
            GameObject.Find("YBot").GetComponent<MovementInput>().enabled = true;
        }

    }
}

