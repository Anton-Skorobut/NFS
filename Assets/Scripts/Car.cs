using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    private float _speed = 120f;
    
    [SerializeField] 
    private float _rotationSpeed = 50;
    
    private void Update()
    {
        var speedStep = _speed * Time.deltaTime;
        var rotationStep = _rotationSpeed * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speedStep);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * speedStep);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up * rotationStep);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotationStep);
        }
    }
}
