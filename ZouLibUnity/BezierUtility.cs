using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierUtility
{
    /// <summary>
    /// 贝塞尔插值点计算公式
    /// PointVector3 = (1-t)*(1-t)*P0 + 2t(1-t)P1 +t*t*P2
    /// t = (0,1) t在0-1之间取值
    /// </summary>
    /// <param name="P0"></param>
    /// <param name="P1"></param>
    /// <param name="P2"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    internal static Vector3 CalculateBezierPoint(Vector3 P0, Vector3 P1, Vector3 P2, float t)
    {
        return (1 - t) * (1 - t) * P0 + 2 * t * (1 - t) * P1 + t * t * P2;
    }

    /// <summary>
    /// Lerp插值计算
    /// Lerp(y1,y2,weight) = y1+(y2-y1)*weight
    /// </summary>
    /// <param name="P0"></param>
    /// <param name="P1"></param>
    /// <param name="P2"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    internal static Vector3 BezierIntepolate3(Vector3 P0, Vector3 P1, Vector3 P2, float t)
    {
        Vector3 P0P1 = Vector3.Lerp(P0,P1,t);
        Vector3 P1P2 = Vector3.Lerp(P1, P2, t);
        return Vector3.Lerp(P0P1, P1P2, t);
    }

    internal static Vector3 BezierIntepolate4(Vector3 P0, Vector3 P1, Vector3 P2, Vector3 P3, float t)
    {
        Vector3 P0P1 = Vector3.Lerp(P0, P1, t);
        Vector3 P1P2 = Vector3.Lerp(P1, P2, t);
        Vector3 P2P3 = Vector3.Lerp(P2, P3, t);

        Vector3 Px = Vector3.Lerp(P0P1, P1P2, t);
        Vector3 Py = Vector3.Lerp(P1P2, P2P3, t);
        return Vector3.Lerp(Px, Py, t);
    }
}
