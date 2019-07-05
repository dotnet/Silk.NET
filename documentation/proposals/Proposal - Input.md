# Summary    
Proposal API for Input via keyboards, mice, and controllers.

# Contributors
- Dylan Perks, Ultz Limited
- Aaron Pearson, Ultz Limited
- Vassalware, Silk.NET Contributors

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- Deadzones have been excluded from this proposal, given that we're still working out the math for the Adaptive Gradient deadzone, which also warrants its own proposal for further explanation.
- Vibration has also been excluded from this proposal, as we'd like to come up with a complete API for HD Rumble etc.
- I've decided to use interfaces for nearly everything, so that the implemenetation has more control.
- All modifications of states (i.e. functions) will go within the interface, whereas structs are used for

# Proposed API
## Interfaces

### IJoystick
```
public interface IJoystick : IInputDevice
{
    IReadOnlyCollection<Axis> Axes { get; }
    IReadOnlyCollection<Button> Buttons { get; }
    IReadOnlyCollection<Hat> Hats { get; }
    event Action<Button> ButtonDown;
    event Action<Button> ButtonUp;
    event Action<Axis> AxisMoved;
    event Action<Hat> HatMoved;
}
```

### IGamepad
```
public interface IGamepad : IInputDevice
{
    IReadOnlyCollection<Button> Buttons { get; }
    IReadOnlyCollection<Thumbstick> Thumbsticks { get; }
    IReadOnlyCollection<Trigger> Triggets { get; }
}
```

### IInputDevice
```
public interface IInputDevice
{
    string Name { get; }
    int Index { get; }
    bool IsConnected { get; }
}
```

## Structs
### Button
```cs
public struct Button
{
    public ButtonName Name { get; }
    public int Index { get; }
    public bool Pressed { get; }
}
```

### Axis
```cs
public struct Axis
{
    public int Index { get; }
    public float Position { get; }
}
```

### Thumbstick
```cs
public struct Thumbstick
{
    public int Index { get; }
    public float Position { get; }
    public float Direction { get; }
}
```

### Trigger
```cs
public struct Trigger
{
    public int Index { get; }
    public float Position { get; }
}
```

### Hat
```cs
public struct Hat
{
    public int Index { get; }
    public HatPosition Position { get; }
}
```

## Enums
### HatPosition
```cs
[Flags] // flags so we can support top left and top right etc (Up | Left, Up | Right)
public enum HatPosition
{
    Up,
    Down,
    Left,
    Right
}
