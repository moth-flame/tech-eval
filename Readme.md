# Tech Eval

Please ensure you have a valid Unity version installed, ideally 2020.3.39f1 or newer.

## Palindrome
Objective: Design an algorithm that determines if a given string is a palindrome.

Background:
A palindrome is a word, phrase, number, or other sequences of characters that reads the same forward and backward (ignoring spaces, punctuation, and capitalization).

Notes:
1. Put your work in Palindrome.cs using the words provided.

## JSON Cube
Objective: Move a cube by ingesting JSON data and using that data as a list of waypoints.

Notes:
1. Use the included Unity JSON or Newtonsoft JSON library to parse flight data JSON.
2. Use the parsed data to move the cube to waypoints by giving a new waypoint from data every 1 second.
3. Update the movement to move smoothly.

Json flight data looks like this.
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
