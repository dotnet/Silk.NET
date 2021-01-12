# Summary
Proposal for adding important missing functionality to input, as well as other enhancements.

# Contributors
- ThomasMiz

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
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
    Press,
    Repeat,
    Release
}
```

#### ButtonAction
```cs
/// <summary>
/// Defines actions for mouse buttons.
/// </summary>
public enum ButtonAction
{
    Press,
    Release
}
```

#### KeyModifiers
Based on [the modifier keys flag from GLFW](https://www.glfw.org/docs/latest/group__mods.html).
```cs
[Flags]
public enum KeyModifiers
{
    Shift = 1,
    Control = 2,
    Alt = 4,
    Super = 8,
    CapsLock = 16,
    NumLock = 32
}
```

## Structs

#### KeyEventArgs
```cs
public readonly struct KeyEventArgs
{
    public IKeyboard Keyboard { get; }
    public Key Key { get; }
    public int KeyCode { get; }
    public KeyAction Action { get; }
    public KeyModifiers Modifiers { get; }
}
```

#### CharacterTypedEventArgs
```cs
public readonly struct CharacterTypedEventArgs
{
    public IKeyboard Keyboard { get; }
    public char Character { get; }
}
```

#### MouseMoveEventArgs
```cs
public readonly struct MouseMoveEventArgs
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    // We can also add to get the difference between Position and the Position in the last move mouse invocation:
    // public Vector2 Delta { get; }
}
```

#### MouseButtonEventArgs
```cs
public readonly struct MouseButtonEventArgs
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    public MouseButton Button { get; }
    public ButtonAction Action { get; }
    public KeyModifiers Modifiers { get; }
}
```

#### MouseScrollEventArgs
This would replace the current ScrollWheel struct.
```cs
public readonly struct MouseScrollEventArgs
{
    public IMouse Mouse { get; }
    public Vector2 Position { get; }
    public Vector2 WheelPosition { get; }
}
```

## Interface changes

#### IKeyboard
```cs
public interface IKeyboard : IInputDevice
{
    // event Action<IKeyboard, Key> KeyDown;
    // event Action<IKeyboard, Key> KeyUp;
    // event Action<IKeyboard, char> KeyChar;
    
    event Action<KeyEventArgs> KeyDown;
    event Action<KeyEventArgs> KeyUp;
    // The KeyAction.Press and Repeat are reported through KeyDown. KeyAction.Release is reported through KeyUp.
    // Another possibility is to report KeyAction.Repeat on a separate event, or to pack the three into a single KeyAction event.
    
    event Action<CharacterTypedEventArgs> CharacterTyped;
}
```

#### IMouse
```cs
public interface IMouse : IInputDevice
{
    // event Action<IMouse, Vector2> MouseMove;
    // event Action<IMouse, MouseButton> MouseDown;
    // event Action<IMouse, MouseButton> MouseUp;
    // event Action<IMouse, ScrollWheel> Scroll;
    // event Action<IMouse, MouseButton, Vector2> Click;
    // event Action<IMouse, MouseButton, Vector2> DoubleClick;
    
    event Action<MouseMoveEventArgs> MouseMove;
    event Action<MouseButtonEventArgs> MouseDown;
    event Action<MouseButtonEventArgs> MouseUp;
    event Action<MouseScrollEventArgs> Scroll;
    event Action<MouseButtonEventArgs> Click;
    event Action<MouseButtonEventArgs> DoubleClick;
}
```

These changes can also be applied to other IDevices to keep consistency across our API.