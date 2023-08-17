using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierTest : MonoBehaviour
{
    public Transform P0;
    public Transform P1;
    public Transform P2;
    public Transform P3;

    public LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer.positionCount = 50;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 50; i++)
        {
            Vector3 point =  BezierUtility.BezierIntepolate3(P0.position, P1.position, P2.position, (i / 50.0f));
            if (P3 != null)
            {
                point = BezierUtility.BezierIntepolate4(P0.position, P1.position, P2.position, P3.position, (i / 50.0f));
            }
            lineRenderer.SetPosition(i, point);
        }
    }
}
