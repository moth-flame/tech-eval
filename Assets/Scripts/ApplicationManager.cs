using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Primary entry point for the application.
/// </summary>
public class ApplicationManager : MonoBehaviour
{
    [SerializeField] private PositionDataReader _positionDataReader;
    [SerializeField] private CubeMovementController _cubeMovementController;

    private void Start()
    {
        var data = _positionDataReader.ReadPositionData();
        
        _cubeMovementController.SetPositionData(data);
        _cubeMovementController.SetMovementEnabled(true);
    }
}
