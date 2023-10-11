using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public struct PositionData
{
    [JsonProperty("object_id")]
    public int ObjectID { get; set; }
    
    [JsonProperty("relative_timestamp")]
    public float RelativeTimestamp { get; set; }
    
    [JsonProperty("relative_latitiude")]
    public float RelativeLatitude { get; set; }
    
    [JsonProperty("relative_longitude")]
    public float RelativeLongitude { get; set; }
    
    [JsonProperty("altitude")]
    public float Altitude { get; set; }
}
