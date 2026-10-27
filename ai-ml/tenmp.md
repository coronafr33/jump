# Practical: Design a Simple Rational Agent

## Aim

To define PEAS for a Vacuum Cleaner Environment and an Autonomous Taxi, classify their environments, and implement a simple table-driven agent in Python.

## 1. PEAS Description

Vacuum Cleaner Environment

| PEAS        | Description                          |
| ----------- | ------------------------------------ |
| Performance | Clean rooms, minimum time and energy |
| Environment | Rooms A and B                        |
| Actuators   | Move Left, Move Right, Suck          |
| Sensors     | Location and room status             |

Autonomous Taxi

| PEAS        | Description                             |
| ----------- | --------------------------------------- |
| Performance | Safety, reaching destination, low cost  |
| Environment | Roads, traffic, pedestrians, passengers |
| Actuators   | Steering, brakes, accelerator, horn     |
| Sensors     | Cameras, GPS, radar, speedometer        |

## 2. Environment Classification

| Property      | Vacuum Cleaner       | Autonomous Taxi      |
| ------------- | -------------------- | -------------------- |
| Observability | Partially observable | Partially observable |
| Nature        | Deterministic        | Stochastic           |
| Task          | Sequential           | Sequential           |

Explanation: A vacuum cleaner may not know the condition of every room at once. An autonomous taxi cannot predict all traffic and pedestrian behavior with certainty. Both are sequential because each action affects future states.

## 3. Python Program

```
# Table-driven Vacuum Cleaner Agenttable = {    ("A", "Dirty"): "Suck",    ("A", "Clean"): "Right",    ("B", "Dirty"): "Suck",    ("B", "Clean"): "Left"}def vacuum_agent(location, status):    return table[(location, status)]print(vacuum_agent("A", "Dirty"))print(vacuum_agent("A", "Clean"))print(vacuum_agent("B", "Dirty"))print(vacuum_agent("B", "Clean"))
```

## Output

```
Suck
Right
Suck
Left
```

## Result

The PEAS descriptions and environment classifications were completed, and the table-driven Vacuum Cleaner Agent was implemented successfully in Python.