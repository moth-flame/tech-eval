using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PositionDataUtils
{
    public static Vector3 LerpPosition(PositionData a, PositionData b, float t)
    {
        var latitude = Mathf.Lerp(a.RelativeLatitude, b.RelativeLatitude, t);
        var longitude = Mathf.Lerp(a.RelativeLongitude, b.RelativeLongitude, t);
        var altitude = Mathf.Lerp(a.Altitude, b.Altitude, t);
        
        return new Vector3(latitude, altitude, longitude);
    }
}
