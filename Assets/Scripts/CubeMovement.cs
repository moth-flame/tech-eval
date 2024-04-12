using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Interpolates a cube's position along a path of position data points using a queue.
/// </summary>
public class CubeMovement : MonoBehaviour
{
    private Queue<PositionData> _positionQueue;

    private PositionData _previousPositionData;
    private PositionData _targetPositionData;

    public void SetPositionQueue(Queue<PositionData> positionQueue)
    {
        _positionQueue = positionQueue;
    }

    public void UpdatePosition()
    {
        if (_positionQueue == null)
        {
            return;
        }
        
        var time = Time.time;
        
        var timeDifference = _targetPositionData.RelativeTimestamp - _previousPositionData.RelativeTimestamp;
        
        var t = (time - _previousPositionData.RelativeTimestamp) / timeDifference;
        
        transform.position = PositionDataUtils.LerpPosition(_previousPositionData, _targetPositionData, t);
        
        if (t >= 1)
        {
            _previousPositionData = _targetPositionData;
            _targetPositionData = _positionQueue.Dequeue();
        }
    }
}
