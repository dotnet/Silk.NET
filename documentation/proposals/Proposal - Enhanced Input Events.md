# Summary
Proposal for adding important missing functionality to input, as well as other enhancements.

# Contributors
- ThomasMiz

# Current Status
- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- Event parameters will be turned into readonly structures to prevent long parameter lists in some cases and allow more parameters (such as deltas) to be added in the future without breaking.

# Proposed API
The only API changes will be to the events presented by IMouse, IKeyboard and possibly other device interfaces.

## Enums

#### KeyAction
```cs
/// <summary>
/// Defines actions for keyboard keys.
/// </summary>
public enum KeyAction
{
    Pressed,
    Repeat,
    Released
}
```

#### ButtonAction
```cs
/// <summary>
/// Defines actions for mouse buttons.
/// </summary>
public enum ButtonAction
{
    Pressed,
    Released
}
```

#### KeyModifiers
Based on [the modifier keys flag from GLFW](https://www.glfw.org/docs/latest/group__mods.html).
```cs
[Flags]
public enum KeyModifiers
{
    Shift = 1 << 1,
    Control = 1 << 2,
    Alt = 1 << 3,
    Super = 1 << 4,
    CapsLock = 1 << 5,
    NumLock = 1 << 6
}
```

## Structs

#### KeyEvent
```cs
public readonly struct KeyEvent
{
    public IKeyboard Keyboard { get; }
    public Key Key { get; }
    public int KeyCode { get; }
    public KeyAction Action { get; }
    public KeyModifiers Modifiers { get; }
}
```

#### KeyCharEvent
```cs
public readonly struct KeyCharEvent
{
    public IKeyboard Keyboard { get; }
    public char Character { get; }
}
```

#### MouseMoveEvent
```cs
public readonly struct MouseMoveEvent
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    // We can also add to get the difference between Position and the Position in the last move mouse invocation:
    // public Vector2 Delta { get; }
}
```

#### MouseButtonEvent
```cs
public readonly struct MouseButtonEvent
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    public MouseButton Button { get; }
    public ButtonAction Action { get; }
    public KeyModifiers Modifiers { get; }
}
```

#### MouseScrollEvent
This would replace the current ScrollWheel struct.
```cs
public readonly struct MouseScrollEvent
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    public Vector2 WheelPosition { get; }
    // public Vector2 Delta { get; }
}
```

#### MouseClickEvent
```cs
public readonly struct MouseClickEvent
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    public MouseButton Button { get; }
    public KeyModifier Modifiers { get; }
}
```

## Interface changes

#### IKeyboard
```cs
public interface IKeyboard : IInputDevice
{
    // The old events get removed:
    // event Action<IKeyboard, Key> KeyDown;
    // event Action<IKeyboard, Key> KeyUp;
    // event Action<IKeyboard, char> KeyChar;
    
    // Reports all key events, KeyAction.Press, KeyAction.Repeat and KeyAction.Release
    event Action<KeyEvent> KeyAction;
    
    event Action<KeyCharEvent> KeyChar;
}
```

#### IMouse
```cs
public interface IMouse : IInputDevice
{
    // The old events get removed:
    // event Action<IMouse, Vector2> MouseMove;
    // event Action<IMouse, MouseButton> MouseDown;
    // event Action<IMouse, MouseButton> MouseUp;
    // event Action<IMouse, ScrollWheel> Scroll;
    // event Action<IMouse, MouseButton, Vector2> Click;
    // event Action<IMouse, MouseButton, Vector2> DoubleClick;
    
    event Action<MouseMoveEvent> MouseMove;
    event Action<MouseButtonEvent> MouseDown;
    event Action<MouseButtonEvent> MouseUp;
    event Action<MouseScrollEvent> Scroll;
    event Action<MouseClickEvent> Click;
    event Action<MouseClickEvent> DoubleClick;
}
```

These changes can also be applied to other IDevices to keep consistency across our API.
