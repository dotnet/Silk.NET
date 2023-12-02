# Summary    
Proposal API for Input via keyboards, mice, and controllers.

# Contributors
- Dylan Perks, Ultz Limited
- Aaron Pearson, Ultz Limited
- Vassalware, Silk.NET Contributors
- Void, Silk.NET codeowners

# Current Status
- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [x] Approved
- [ ] Implemented

# Design Decisions
- Vibration has been excluded from this proposal, as we'd like to come up with a complete API for HD Rumble etc.
- I've decided to use interfaces for nearly everything, so that the implementation has more control.
- All modifications of states (i.e. functions) will go within the interface, whereas structs are used for read-only data.
- **IMPLEMENTATION DETAIL/REQUIREMENT:** In implementations, once an IJoystick, IGamepad, or other IInputDevice object has been created, **it must not be destroyed until its IInputContext is disposed**. This is to preserve event bindings.
- ButtonDown/Up and KeyDown/Up events (and similar) all fire once, when the key is first pushed down or up. I intend to champion a few extension packages to support more use cases, but I've kept this API pretty barebones.

# Proposed API
## Interfaces

### IJoystick
```cs
public interface IJoystick : IInputDevice
{
    IReadOnlyList<Axis> Axes { get; }
    IReadOnlyList<Button> Buttons { get; }
    IReadOnlyList<Hat> Hats { get; }
    Deadzone Deadzone { get; set; }
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
    IReadOnlyList<Button> Buttons { get; }
    IReadOnlyList<Thumbstick> Thumbsticks { get; }
    IReadOnlyList<Trigger> Triggers { get; }
    Deadzone Deadzone { get; set; }
    event Action<IGamepad, Button> ButtonDown;
    event Action<IGamepad, Button> ButtonUp;
    event Action<IGamepad, Thumbstick> ThumbstickMoved;
    event Action<IGamepad, Trigger> TriggerMoved;
}
```

### IKeyboard
```cs
public interface IKeyboard : IInputDevice
{
    IReadOnlyList<Key> SupportedKeys { get; }
    bool IsKeyPressed(Key key);
    bool IsKeyPressed(uint scancode);
    event Action<IKeyboard, Key> KeyDown;
    event Action<IKeyboard, Key> KeyUp;
}
```

### IMouse
```cs
public interface IMouse : IInputDevice
{
    IReadOnlyList<MouseButton> SupportedButtons { get; }
    IReadOnlyList<ScrollWheel> ScrollWheels { get; }
    bool IsButtonPressed(MouseButton btn);
    event Action<IMouse, MouseButton> MouseDown;
    event Action<IMouse, MouseButton> MouseUp;
    event Action<IMouse, ScrollWheel> Scroll;
}
```

### IInputDevice
```cs
public interface IInputDevice
{
    string Name { get; }
    int Index { get; }
    bool IsConnected { get; }
    event Action<IInputDevice, bool> ConnectionChanged;
}
```

### IInputContext
```cs
public interface IInputContext : IDisposable
{
    IntPtr Handle { get; }
    IReadOnlyList<IGamepad> Gamepads { get; }
    IReadOnlyList<IJoystick> Joysticks { get; }
    IReadOnlyList<IKeyboard> Keyboards { get; }
    IReadOnlyList<IMouse> Mice { get; }
    IReadOnlyList<IInputDevice> OtherDevices { get; }
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
    public static void UnregisterInputPlatform(IInputPlatform platform);
    public static IInputContext GetInput(this IWindow window);
}
```

## Structs
### ScrollWheel
```cs
public struct ScrollWheel
{
    public float X { get; }
    public float Y { get; }
    
    public ScrollWheel(float x, float y);
}
```

### Button
```cs
public struct Button
{
    public ButtonName Name { get; }
    public int Index { get; }
    public bool Pressed { get; }
    
    public Button(ButtonName name, int index, bool pressed);
}
```

### Axis
```cs
public struct Axis
{
    public int Index { get; }
    public float Position { get; }
    
    public Axis(int index, float position);
}
```

### Thumbstick
```cs
public struct Thumbstick
{
    public int Index { get; }
    public float X { get; }
    public float Y { get; }
    public float Position { get; }
    public float Direction { get; }
    
    public Thumbstick(int index, float position, float direction);
}
```

### Trigger
```cs
public struct Trigger
{
    public int Index { get; }
    public float Position { get; }
    
    public Trigger(int index, float position);
}
```

### Hat
```cs
public struct Hat
{
    public int Index { get; }
    public Position2D Position { get; }
    
    public Hat(int index, Position2D position);
}
```

### Deadzone
```cs
public struct Deadzone
{
    public float Value { get; }
    public DeadzoneMethod Method { get; }
    
    public Deadzone(float value, DeadzoneMethod method);
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

### Key
```cs
public enum Key
{
    Unknown = 0,
    ShiftLeft,
    LShift = ShiftLeft,
    ShiftRight,
    RShift = ShiftRight,
    ControlLeft,
    LControl = ControlLeft,
    ControlRight,
    RControl = ControlRight,
    AltLeft,
    LAlt = AltLeft,
    AltRight,
    RAlt = AltRight,
    WinLeft,
    LWin = WinLeft,
    WinRight,
    RWin = WinRight,
    Menu,
    F1,
    F2,
    F3,
    F4,
    F5,
    F6,
    F7,
    F8,
    F9,
    F10,
    F11,
    F12,
    F13,
    F14,
    F15,
    F16,
    F17,
    F18,
    F19,
    F20,
    F21,
    F22,
    F23,
    F24,
    F25,
    F26,
    F27,
    F28,
    F29,
    F30,
    F31,
    F32,
    F33,
    F34,
    F35,
    Up,
    Down,
    Left,
    Right,
    Enter,
    Escape,
    Space,
    Tab,
    BackSpace,
    Back = BackSpace,
    Insert,
    Delete,
    PageUp,
    PageDown,
    Home,
    End,
    CapsLock,
    ScrollLock,
    PrintScreen,
    Pause,
    NumLock,
    Clear,
    Sleep,
    Keypad0,
    Keypad1,
    Keypad2,
    Keypad3,
    Keypad4,
    Keypad5,
    Keypad6,
    Keypad7,
    Keypad8,
    Keypad9,
    KeypadDivide,
    KeypadMultiply,
    KeypadSubtract,
    KeypadMinus = KeypadSubtract,
    KeypadAdd,
    KeypadPlus = KeypadAdd,
    KeypadDecimal,
    KeypadPeriod = KeypadDecimal,
    KeypadEnter,
    A,
    B,
    C,
    D,
    E,
    F,
    G,
    H,
    I,
    J,
    K,
    L,
    M,
    N,
    O,
    P,
    Q,
    R,
    S,
    T,
    U,
    V,
    W,
    X,
    Y,
    Z,
    Number0,
    Number1,
    Number2,
    Number3,
    Number4,
    Number5,
    Number6,
    Number7,
    Number8,
    Number9,
    Tilde,
    Grave = Tilde,
    Minus,
    Plus,
    BracketLeft,
    LBracket = BracketLeft,
    BracketRight,
    RBracket = BracketRight,
    Semicolon,
    Quote,
    Comma,
    Period,
    Slash,
    BackSlash,
    NonUSBackSlash,
    LastKey
}
```

### MouseButton
```cs
public enum MouseButton
{
    Left,
    Middle,
    Right,
    Button4,
    Button5,
    Button6,
    Button7,
    Button8,
    Button9,
    Button10,
    Button11,
    Button12
}
```
