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
- Vibration has been excluded from this proposal, as we'd like to come up with a complete API for HD Rumble etc.
- I've decided to use interfaces for nearly everything, so that the implementation has more control.
- All modifications of states (i.e. functions) will go within the interface, whereas structs are used for read-only data.
- In implementations, once an IJoystick, IGamepad, or other IInputDevice object has been created, **it must not be destroyed until disconnected**. This is to preserve event bindings.

# Proposed API
## Interfaces

### IJoystick
```cs
public interface IJoystick : IInputDevice
{
    IReadOnlyCollection<Axis> Axes { get; }
    IReadOnlyCollection<Button> Buttons { get; }
    IReadOnlyCollection<Hat> Hats { get; }
    event Action<IJoystick, Button> ButtonDown;
    event Action<IJoystick, Button> ButtonUp;
    event Action<IJoystick, Axis> AxisMoved;
    event Action<IJoystick, Hat> HatMoved;
}
```

### IGamepad
```cs
public interface IGamepad : IInputDevice
{
    IReadOnlyCollection<Button> Buttons { get; }
    IReadOnlyCollection<Thumbstick> Thumbsticks { get; }
    IReadOnlyCollection<Trigger> Triggers { get; }
    Deadzone Deadzone { get; set; }
    event Action<IGamepad, Button> ButtonDown;
    event Action<IGamepad, Button> ButtonUp;
    event Action<IGamepad, Thumbstick> ThumbstickMoved;
    event Action<IGamepad, Hat> HatMoved;
}
```

### IInputDevice
```cs
public interface IInputDevice
{
    string Name { get; }
    int Index { get; }
    bool IsConnected { get; }
    event Action<IInputDevice> Disconnected;
}
```

### IInputContext
```cs
public interface IInputContext
{
    IntPtr Handle { get; }
    IReadOnlyCollection<IGamepad> Gamepads { get; }
    IReadOnlyCollection<IJoystick> Joysticks { get; }
    IReadOnlyCollection<IKeyboard> Keyboards { get; }
    IReadOnlyCollection<IMouse> Mice { get; }
    IReadOnlyCollection<IInputDevice> OtherDevices { get; }
}
```

### IInputPlatform\<T\>
```cs
public interface IInputPlatform
{
    bool IsApplicable(IWindow window);
    IInputContext GetInput(IWindow window);
}
```

## Classes

### InputWindowExtensions
```cs
public static class InputWindowExtensions
{
    public static void RegisterInputPlatform(IInputPlatform platform);
    public static void DeregisterInputPlatform(IInputPlatform platform);
    public static IInputContext GetInput(this IWindow window);
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
    public Position2D Position { get; }
}
```

### Deadzone
```cs
public struct Deadzone
{
    public float Value { get; }
    public DeadzoneMethod Method { get; }
}
```

## Enums
### Position2D
```cs
[Flags] // flags so we can support top left and top right etc (Up | Left, Up | Right)
public enum Position2D
{
    Up,
    Down,
    Left,
    Right
}
```

### DeadzoneMethod
```cs
public enum DeadzoneMethod
{
    // y = x except where |x| is between 0 and d (the deadzone value)
    Traditional,
    // y = (1 - d)x + (d * sgn(x))
    AdaptiveGradient
}
```

### ButtonName
```cs
public enum ButtonName
{
    A,
    B,
    X,
    Y,
    Back,
    Home,
    DPadUp,
    DPadDown,
    DPadLeft,
    DPadRight,
    LeftBumper,
    LeftStick,
    LeftTrigger,
    RightBumper,
    RightStick,
    RightTrigger,
    Start
}
```
