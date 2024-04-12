using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// Controls a cube's position update loop and position data.
/// </summary>
public class CubeMovementController : MonoBehaviour
{
    [SerializeField] private CubeMovement _cubeMovement;
    
    private bool _isMovementEnabled;
    
    public void SetPositionData(PositionData[] positionData)
    {
        var positionQueue = positionData != null ? new Queue<PositionData>(positionData) : new Queue<PositionData>();
        _cubeMovement.SetPositionQueue(positionQueue);
    }

    public void SetMovementEnabled(bool isMovementEnabled)
    {
        _isMovementEnabled = isMovementEnabled;
    }

    private void Update()
    {
        if (!_isMovementEnabled)
        {
            return;
        }
        
        _cubeMovement.UpdatePosition();
    }
}
