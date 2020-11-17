# Tech Eval
### Chose your own adventure
##### JSON Goal: 
1. Use the included Unity or Newtonsoft json library to parse flight data json.
2. Use the parsed data to move a cube around on screen.
3. The cube should move smoothly to waypoints by giving a new waypoint from data every 1 second.

Json flight data looks like this.
[
  {
    "object_id": "803",
    "relative_timestamp": 0.0,
    "relative_longitude": 2.9110509,
    "relative_latitiude": 5.4351641,
    "altitude": 10.0
  }  
]


##### User Interaction Goal
1. Click with mouse in your app to set a waypoint.
2. Collect all clicked points into an array
3. When you click the spacebar, show waypoints with spheres.
4. Have a cube GameObject move smoothly to waypoints.
*Bonus: Have the cube face toward the current waypoint.
*Bonus: Write these points back to json similar to the other challenge.
