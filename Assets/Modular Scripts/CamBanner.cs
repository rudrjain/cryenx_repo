﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CamBanner : MonoBehaviour
{
    Transform cam;
    Vector3 targetAngle = Vector3.zero;

    private void Start()
    {
        cam = Camera.main.transform;
    }

    private void Update()
    {
        transform.LookAt(cam);
        targetAngle = transform.localEulerAngles;
        targetAngle.x = 0;
        targetAngle.z = 0;
        transform.localEulerAngles = targetAngle;
    }

    
}
