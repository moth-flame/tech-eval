using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

/// <summary>
/// Deserializes position data from a JSON file.
/// </summary>
public class PositionDataReader : MonoBehaviour
{
    [SerializeField] private TextAsset _positionData;
    
    public PositionData[] ReadPositionData()
    {
        return JsonConvert.DeserializeObject<PositionData[]>(_positionData.text);
    }
}
