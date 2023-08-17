using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sci_Fi_Rotate : MonoBehaviour
{
    public enum XYZ { X, Y, Z};
    public float MinSpeed = 0.001f;
    public float MaxSpeed = 0.005f;
    public float MinTime = 1.0f;
    public float MaxTime = 6.0f;
    public float Speed = 0.001f;
    public XYZ Axis = XYZ.X;
    public bool isRollBack = true;
    private Vector3 RotateAxis = Vector3.right;
    //public float Time = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        switch (Axis)
        {
            case XYZ.X:
                RotateAxis = Vector3.right;
                break;
            case XYZ.Y:
                RotateAxis = Vector3.up;
                break;
            case XYZ.Z:
                RotateAxis = Vector3.forward;
                break;
            default:
                break;
        }
        ChangeRotate();
    }

    private void ChangeRotate()
    {
        Speed = UnityEngine.Random.Range(MinSpeed, MaxSpeed);
        if (isRollBack)
        {
            if (UnityEngine.Random.Range(1, 10) >= 5)
            {
                Speed = -Speed;
            }
        }             
        Invoke("ChangeRotate", UnityEngine.Random.Range(MinTime, MaxTime));
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(RotateAxis, Speed);
    }

    private void FixedUpdate()
    {
        transform.Rotate(RotateAxis, Speed);
    }
}
