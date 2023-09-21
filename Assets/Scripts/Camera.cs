using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Car _car;

    [SerializeField]
    private Vector3 _offset;
    
    private void LateUpdate()
    {
        transform.position = _car.transform.position + _offset;
    }
}
