# Summary    
Proposal API for Input via keyboards, mice, and controllers.

# Contributors
- Dylan P, Ultz Limited
- Aaron P, Ultz Limited
- Vassalware, Silk.NET Contributors

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- Deadzones have been excluded from this proposal, given that we're still working out the math for the Adaptive Gradient deadzone, which also warrants its own proposal for further explanation.
- Vibration has also been excluded from this proposal, as we'd like to come up with a complete API for HD Rumble etc.
- I've decided to use interfaces for nearly everything,

# Proposed API
## Interfaces
### IJoystick
```
public interface IJoystick : IInputDevice
{
    IReadOnlyCollection<Axis> Axes { get; }
    IReadOnlyCollection<Button> Buttons { get; }
    event Action<Button> ButtonDown;
    event Action<Button> ButtonUp;
}
```

### IGamepad
```
public interface IGamepad : IInputDevice
{
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
