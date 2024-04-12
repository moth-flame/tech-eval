# Tech Eval
Please ensure you have Unity version 2022.3.21f1 installed as well as an IDE of your choice.

# Bug Tickets
## Ticket 1: Movement loop doesn't start
Repro Steps:
1. Start cube movement app
2. Observe cube not moving

## Ticket 2: Movement stops halfway through
Repro Steps:
1. Start cube movement app
2. Observe cube beginning movement
3. Observe cube stopping halfway through the full circle

## Ticket 3: Error log spam on movement completion
Repro Steps:
1. Start cube movement app
2. Observe cube moving along the full path circle
3. Observe error logs every frame once cube reaches end of path

## Ticket 4: Minor error log at start
Repro Steps:
1. Start cube movement app
2. Observe invalid position assignment at start of app, even though cube continues moving

# Feature Request: Multi-Cube Data
Problem:
1. Current cube movement system is hardcoded to only handle data for one cube in a given data file.

Objective:
1. Extend the cube movement system to allow for an arbitrary number of cubes to be moved by one data file.

Notes:
1. `positionData_FourCubes.json` contains data for 4 different cubes associated with separate integer IDs.
2. Json flight data looks like this.
```
[
  {
    "object_id": "803",
    "relative_timestamp": 0.0,
    "relative_longitude": 2.9110509,
    "relative_latitiude": 5.4351641,
    "altitude": 10.0
  }  
]
```
