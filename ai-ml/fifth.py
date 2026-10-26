# Table-Driven Vacuum Cleaner Agent

# Table containing percept-action pairs
table = {
    ('A', 'Dirty'): 'Suck',
    ('A', 'Clean'): 'Right',
    ('B', 'Dirty'): 'Suck',
    ('B', 'Clean'): 'Left'
}

# Percept sequence
percepts = []

def table_driven_agent(percept):
    # Add current percept to percept sequence
    percepts.append(percept)

    # Look up action in the table
    action = table.get(percept)

    return action


# Test the agent
print("Vacuum Cleaner Agent")

test_percepts = [
    ('A', 'Dirty'),
    ('A', 'Clean'),
    ('B', 'Dirty'),
    ('B', 'Clean')
]

for percept in test_percepts:
    action = table_driven_agent(percept)
    print("Percept:", percept, "=> Action:", action)

print("\nPercept Sequence:")
print(percepts)