# Summary
Proposal API for backend-agnostic, refactored Input via keyboards, mice, and controllers.

# Contributors
- Dylan Perks (@Perksey)

# Current Status
- [x] Proposed
- [x] Discussed with Working Group
- [x] Approved
- [ ] Implemented

# Design Decisions
- This proposal, while aiming to keep the same look and feel as the 2.0 API, is a complete redesign of the Input API with the following goals:
    - Input backends can be added and removed at will to a central input context object.
    - All input devices, regardless of what backends they come from, can be accessed from a central input context object.
    - Should the Silk.NET team design more APIs for more devices (for example VR hands using OpenXR) in the future, this can be added in a non-breaking way.
    - All input devices instead of exposing properties only expose a single `State` property, with additional properties and/or methods for writable state (i.e. vibration motors, mouse position). This also addresses comments from the Working Group on previous iterations of this proposal, where the Working Group expressed interest in the state being immutable and trivially capturable.
    - Ensuring the input API is accessible and easy to use.
    - Addressing APIs that the userbase frequently had issues/distaste with. For example, events are no longer on each individual device, rather they are aggregated in a list and accessed from a single entry-point.
- This proposal aims to keep the look and feel of the Input APIs intended for general consumption similar to that of 2.0.
- This proposal incorporates/supersedes the Enhanced Input Events proposal.
- This proposal assumes knowledge of the Windowing 3.0 proposal.
- This proposal assumes knowledge of Silk.NET.Core 2.0.

Please note that text marked **INFORMATIVE TEXT** does not form part of this proposal's requirements or proposed API, and is merely text to help the reader understand our intentions. Informative text is not well-defined, and may not reflect the actual implementation.

Note that the parties in this proposal are:
- **developer**: The developer using Silk.NET.
- **end user**: The user using an application using Silk.NET, and by extension the user inputting data into the application via Silk.NET.

Cases where the **user** word is used without the **end** prefix can be assumed to be referring to the **developer** rather than the **end user**.

# Usage Examples
```cs
INativeWindow someWindow = null!;
var inputContext = someWindow.CreateInput();
inputContext.Update();
inputContext.Gamepads.ThumbstickMove += @event =>
{
    Console.WriteLine($"Thumbstick {@event.Index} moved from {@event.Value - @event.Delta} to {@event.Value}");
};
var isButtonDown = inputContext.Gamepads.Any(gamepadState => gamepadState.Buttons[JoystickButton.A]);
```
```cs
INativeWindow someWindow = null!;
var inputContext = new InputContext();
inputContext.Update();
inputContext.Backends.Add(someWindow.CreateInputBackend());
// in future:
// inputContext.Backends.Add(new OpenXRInputBackend(...));
```
```cs
class Program : ISurfaceApplication
{
    public static void Initialize<TSurface>(TSurface surface) where TSurface : Surface
    {
        var inputContext = surface.CreateInput();
        surface.Update += _ => inputContext.Update();
        inputContext.Gamepads.ThumbstickMove += @event =>
        {
            Console.WriteLine($"Thumbstick {@event.Index} moved from {@event.OldValue} to {@event.NewValue}");
        };
    }

    public static void Main() => ISurfaceApplication.Run<Program>();
}
```

# Reference Implementation

Similar to Windowing 3.0, a reference implementation will be included in the main `Silk.NET.Input` package which uses the same API or family of APIs as Windowing's reference implementation. This will be exposed by the `InputWindowExtensions` class.

```cs
public static class InputWindowExtensions
{
    public static IInputBackend CreateInputBackend(this INativeWindow window);
    public static InputContext CreateInput(this INativeWindow window);
}
```

The `CreateInputBackend` will create an instance of the reference implementation for the given `INativeWindow`. `Surface` will implement `INativeWindow`, so the extension methods will be usable on a `Surface` without having a hard reference between Windowing and Input.

The `CreateInput` methods simply return an `InputContext` preconfigured with the backend created by `CreateInputBackend` for ease of use.

Please see the Windowing 3.0 proposal for `INativeWindow`.

# Devices

Input devices all inherit from a root interface.

```cs
public interface IInputDevice
{
    nint Id { get; }
    string Name { get; }
}
```

`Id` is an globally-unique integral identifier for this device.

`Name` is a rough description of the input device. Its value is not intrinsically meaningful.

All devices originate from a backend.

# Backends

```cs
public interface IInputBackend
{
    string Name { get; }
    nint Id { get; }
    IReadOnlyList<IInputDevice> Devices { get; }
    void Update(IInputHandler? handler = null);
}
```

`Name` is a rough description of the input backend. Its value is not intrinsically meaningful.

`Id` is a globally-unique integral identifier for this backend.

`Devices` enumerates all of the **connected** devices available from this input backend. When a device is disconnected, its `IInputDevice` object should be discarded by all that consumed it, as it can not be relied upon for being reused by the input backend. An implementation is welcome to reuse old objects, but this is strictly implementation-defined. A device not being present in the `Devices` list is sufficient evidence that a device has been disconnected.

`Update` will update the state of all devices contained within this input backend. The value of the `State` properties on each device must not change until this method is called. This is a departure from 1.0's and 2.0's model of updating state as soon as new information is available, which has resulted in lots of inconsistencies in the past.

The onus is on the user to coordinate using this type across threads, as the input context is not thread safe. In addition, certain backends may have (unavoidable) restrictions on what thread `IInputBackend.Update` can be called on - the user is responsible for respecting these threading rules as well.

Threading rules for the reference implementation (if any) will be explicitly documented, and guidance for using this type safely against any first-party implementations will be included in the XML and user documentation.

**INFORMATIVE TEXT:** For example, it is illegal for GLFW functions to be called anywhere except the thread `glfwInit` was called on, and it is illegal on some operating systems (such as macOS) for `glfwInit` to be called anywhere except the thread that called `main`.

## Input Handlers

Some users will want to receive events in the order that they happen. Observing state does not allow us to do this if, for instance, a button was pressed and released between update calls - the state would have a net-zero change and thus we wouldn't be able to detect such events.

This is solved by the handler model, which is implemented by the custom list types - the handler methods invoking the matching events.

**INFORMATIVE TEXT:** A possible question is "why don't we just expose the events directly on the devices? Why do we need this handler model?". The answer to that is having events on the devices has considerations for the lifetime of the device objects, which the Silk.NET team wishes to leave unrestricted. For instance, when a device connects the input context will need to bind the events on each device itself and when a device disconnects the behaviour thereafter would be undefined because we have not explicitly allowed or disallowed the reuse of device objects, and we do not wish to. If a device object were to be reused when the device reconnects, those events would still be there. It's better to encapsulate these events in their own object using this handler model.

```cs
public interface IInputHandler
{
    void HandleDeviceConnectionChanged(ConnectionEvent @event);
}
```

The base `IInputHandler` is simple, handling only device connections and device disconnections.

`HandleDeviceConnectionChanged` must be called with a device and a value of `true` if the `ConnectionEvent.Device` has just been added to the `IInputBackend.Devices` list.

`HandleDeviceConnectionChanged` must be called with a device and a value of `false` if the `ConnectionEvent.Device` has just been removed from the `IInputBackend.Devices` list.

All handler methods are called in the order that the state changes happened in the underlying backend. For example, a "double click" would be mouse down, mouse up, mouse down, and mouse up again. Even if those events happened entirely between two update calls (thus resulting in a net-zero change of state, given the button was released at the last update and is still released at this update), the input backend is expected to queue up the events so they may be delivered to the handler in the order in which they occurred when `Update` is called **where possible**. The events being in order is preferred and strongly recommended for backend implementations, and if a backend is able to order events in this way it is required to do so and required to do so consistently. If the backend is unable to do so, then the events being in order is not required. 

**INFORMATIVE TEXT:** Some backends, such as OpenXR, may only operate on a state query basis, and obviously we only query the state when `Update` is called. This is the reason why it's only a "where possible" requirement, because if we can't actually get the events in the order they happened from the underlying backend (like we can for GLFW, for example) then it's impossible for us to convey this up to the developer. However, regardless of backend-specifics, a `State` update must always be paired with an handler method call.

The `IInputHandler` passed into `Update` may implement multiple other handler interfaces (as defined below), and if the actor implements an extra interface (such as `IMouseInputHandler` defined below) that would allow the backend to forward more events to the handler, the backend must do so via type checking. That is, if `handler` is an instance of `IMouseInputHandler`, any mouse events are delivered to that actor. But if `handler` does not implement `IMouseInputHandler`, no mouse events will be delivered. All events, including those that were not delivered due to the actor not implementing a necessary interface, must be discarded at the end of the `Update` call.

Note that during the `Update` call, a backend must only update the device's state in the order that the events are delivered. For example when `IInputBackend.Update` is called:
1. The backend has a queued "mouse down" event.
2. The backend updates the `State` of the relevant `IMouse` for that button press.
3. The backend calls `HandleButtonDown` on the `IMouseInputHandler` (if applicable).
4. The backend has a queued "mouse up" event.
5. The backend updates the `State` of the relevant `IMouse` for that button release.
6. The backend calls `HandleButtonUp` on the `IMouseInputHandler` (if applicable).

This allows the actor to work with the whole device state with the device state being representative of the time that the original event occurred.

More actors will be defined later in the proposal.

All of the `Devices` and `Update`s are aggregated and coordinated by a central input context object.

# Contexts

```cs
public partial class InputContext
{
    public Mice Mice { get; }
    public Keyboards Keyboards { get; }
    public Gamepads Gamepads { get; }
    public Joysticks Joysticks { get; }
    public IReadOnlyList<IInputDevice> Devices { get; }
    public IList<IInputBackend> Backends { get; }
    public event Action<ConnectionEvent>? ConnectionChanged;
    public void Update();
}
```

The central input object acts as the main entry point into the Input API, and is responsible for comparing the state reported by the devices for differences between `Update` calls (raising events as necessary). 

`Mice`, `Keyboards`, `Gamepads`, and `Joysticks` are all custom `IReadOnlyList` types for enumerating the devices. However, these custom types also contain the events. This is so we can "scope" the events, rather than putting them at the top-level and having to call the events `MouseButtonDown`, `JoystickButtonDown`, etc.

By virtue of the `State` properties not updating until `IInputBackend.Update` is called, the states of the devices enumerated by the lists will not change until `Update` is called.

`Update` will call `IInputBackend.Update` on each of the `Backends`, passing in a handler which implements `IInputHandler`, `IMouseInputHandler`, `IKeyboardInputHandler`, `IGamepadInputHandler`, and `IJoystickInputHandler` with each of the methods invoking a matching event defined in "Custom List Types" or on the input context itself (such as `ConnectionChanged`).

`Backends` is a mutable list of input backends. Until `Update` is called again, no device lists, state, etc on the context will be updated. The `ConnectionChanged` rules above will still be respected e.g. when you remove a backend, all of its devices will have a disconnected event raised for them.

`Devices` contains all devices reported by all backends, including devices that do not necessarily fit into one of our more specialized wrapper lists. This means that if a backend has a device type we do not recognise, it will be accessible via this list.

## Custom List Types

These are relatively simple list wrappers with the events fired when state changes.

```cs
public partial class Mice : IReadOnlyList<IMouse>
{
    public MouseClickConfiguration ClickConfiguration { get; set; }
    public event Action<MouseDownEvent>? ButtonDown;
    public event Action<MouseUpEvent>? ButtonUp;
    public event Action<MouseClickEvent>? Click;
    public event Action<MouseClickEvent>? DoubleClick;
    public event Action<MouseMoveEvent>? CursorMove;
    public event Action<MouseScrollEvent>? Scroll;
}

public partial class Keyboards : IReadOnlyList<IKeyboard>
{
    public event Action<KeyDownEvent>? KeyDown;
    public event Action<KeyUpEvent>? KeyUp;
    public event Action<KeyCharEvent>? KeyChar;
}

public partial class Gamepads : IReadOnlyList<IGamepad>
{
    public event Action<GamepadDownEvent>? ButtonDown;
    public event Action<GamepadUpEvent>? ButtonUp;
    public event Action<GamepadThumbstickMoveEvent>? ThumbstickMove;
    public event Action<GamepadTriggerMoveEvent>? TriggerMove;
}

public partial class Joysticks : IReadOnlyList<IJoystick>
{
    public event Action<JoystickDownEvent>? ButtonDown;
    public event Action<JoystickUpEvent>? ButtonUp;
    public event Action<JoystickAxisMoveEvent>? AxisMove;
    public event Action<JoystickHatMoveEvent>? HatMove;
}
```

All events will be raised when their matching handler methods are called, with the exception of `Click` and `DoubleClick` which are implemented on top of `ButtonDown` and `ButtonUp` respectively (as in 2.X).

`DoubleClick` will be raised if `Mice.ButtonDown` is raised two consecutive times within `MouseClickConfiguration.DoubleClickTime` milliseconds, and the `MouseState.Position`'s `X` or `Y` did not change more than `MouseClickConfiguration.DoubleClickRange` between the two events. If these conditions are not met, `Click` is raised instead. For the avoidance of doubt, the behaviour of the click implementation here is exactly as it is in 2.X.

**INFORMATIVE TEXT:** The click implementation may also even be exactly the same implementation as it is 2.X copied and pasted into 3.0, given a lot of research and effort went into this by the community contributor that implemented it.

`MouseClickConfiguration` is defined as follows:

```cs
public record struct MouseClickConfiguration(int DoubleClickTime, float DoubleClickRange);
```

This will be configurable on `Mice` (i.e. via `InputContext.Mice.ClickConfiguration`). The Silk.NET team wishes to reserve the right to define the initial values set on `Mice.ClickConfiguration`, but these will most likely be the same as in 2.X.

Unlike 1.0 and 2.0, this proposal uses `readonly record struct`s as their only argument for the event action. This allows us to provide more information to the event handlers without breaking in the future. These types are farily simple:

```cs
public readonly record struct ConnectionEvent(IInputDevice Device, bool IsConnected);
public readonly record struct KeyDownEvent(IKeyboard Keyboard, Key Key, bool IsRepeat);
public readonly record struct KeyUpEvent(IKeyboard Keyboard, Key Key);
public readonly record struct KeyCharEvent(IKeyboard Keyboard, char Character);
public readonly record struct MouseDownEvent(IMouse Mouse, Vector2 Position, MouseButton Button);
public readonly record struct MouseUpEvent(IMouse Mouse, Vector2 Position, MouseButton Button);
public readonly record struct MouseMoveEvent(IMouse Mouse, Vector2 Position, Vector2 Delta);
public readonly record struct MouseScrollEvent(IMouse Mouse, Vector2 Position, Vector2 WheelPosition, Vector2 Delta);
public readonly record struct MouseClickEvent(IMouse Mouse, Vector2 Position, MouseButton Button);
public readonly record struct JoystickDownEvent(IJoystick Joystick, JoystickButton Button);
public readonly record struct JoystickUpEvent(IJoystick Joystick, JoystickButton Button);
public readonly record struct JoystickHatMoveEvent(IJoystick, Vector2 Value, Vector2 Delta);
public readonly record struct JoystickAxisMoveEvent(IJoystick Joystick, int Axis, float Value, float Delta);
public readonly record struct GamepadDownEvent(IGamepad Gamepad, JoystickButton Button);
public readonly record struct GamepadUpEvent(IGamepad Gamepad, JoystickButton Button);
public readonly record struct GamepadThumbstickMoveEvent(IJoystick, Vector2 Value, Vector2 Delta);
public readonly record struct GamepadTriggerMoveEvent(IJoystick Joystick, int Axis, float Value, float Delta);
```

This is the part of this proposal that incorporates the ideas in Enhanced Input Events, and is why this proposal supersedes that one.

One final point to note is that throughout the rest of the proposal the following type will be used:

```cs
public struct InputReadOnlyList<T> : IReadOnlyList<T>
{
    public InputReadOnlyList(IReadOnlyList<T> other);
}
```

The Silk.NET team wishes to reserve the right to add more constructors to this type as it sees fit.

This exists so that, should the Silk.NET choose to, we can optimize the lookup of elements while ensuring things like indexers are inlined and don't result in a virtual call if our implementation allows us to do so.

**INFORMATIVE TEXT:** For example, for joystick and mouse buttons we could use a fixed-sized bit buffer where each bit represents an individual button: 1 for pressed, 0 for unpressed. But for something like keyboard input where there are a large amount of keys, we can't do that and will likely use `Memory<T>` instead.

# Mouse Input

As discussed earlier, the interface will be very simple.

```cs
public interface IMouse : IInputDevice
{
    ref readonly MouseState State { get; }
    ICursorConfiguration Cursor { get; }
    void SetPosition(Vector2 pos);
}
```

`State` is the device state as defined earlier.

`Cursor` contains the cursor configuration. This isn't actually state that the end user can change, and has been made an interface rather than a state struct accordingly.

`SetPosition` allows moving the mouse cursor without the end user physically moving their mouse. Please note that this does not immediately update `State` with the new value - the changes will be reflected next time `IInputBackend.Update` is called.

The device state returned by `State` fills out the following structure:

```cs
public readonly record struct MouseState
(
    MouseButtonState Buttons,
    Vector2 Position,
    Vector2 WheelPosition
);
```

`MouseButtonState` is defined as:
```cs
public readonly record struct MouseButtonState
(
    InputReadOnlyList<MouseButton> Down
)
{
    public bool this[MouseButton btn] { get; }
}
```

The indexer returns `true` if a particular button is pressed, false otherwise. If the developer wishes to enumerate the button state, they must explicitly enumerate through the `Down` buttons.

**INFORMATIVE TEXT:** This struct only exists so we can implement an indexer that accepts a `MouseButton`, given that `Down` is effectively just a list and only takes an `int` index as a result. 

The indexer will be implemented in terms of `Down`, which is the only property that a backend will need to set.

Changes to `MouseState` also have matching handler methods which are subject to the handler method rules i.e. the backend should call them in the order in which the backend received the events where possible etc (read the Input Handlers section).

```cs
public interface IMouseInputHandler : IInputHandler
{
    void HandleButtonDown(MouseDownEvent @event);
    void HandleButtonUp(MouseUpEvent @event);
    void HandleCursorMove(MouseCursorEvent @event);
    void HandleScroll(MouseScrollEvent @event);
}
```

`HandleButtonDown` must be called when a button is added to `MouseState.Buttons.Down`.

`HandleButtonUp` must be called when a button is removed from `MouseState.Buttons.Down`.

`HandleCursorMove` must be called when `MouseState.Position` changes.

`HandleScroll` must be called when `MouseState.WheelPosition` changes.

Note that the click events, just as in 2.X, are not implemented by the backend and instead implemented by the input context because it is not a requirement that backends can record clicks. **INFORMATIVE TEXT:** The original reason for this requirement in 2.X is because GLFW doesn't actually send click and double click events.

## Enums

```cs
public enum MouseButton
{
    Unknown,
    LeftButton,
    RightButton,
    MiddleButton,
    Button4,
    Button5,
    Button6,
    Button7,
    Button8,
    Button9,
    Button10,
    Button11,
    Button12,
    Button13,
    Button14,
    Button15,
    Button16,
    Button17,
    Button18,
    Button19,
    Button20,
    Button21,
    Button22,
    Button23,
    Button24,
    Button25,
    Button26,
    Button27,
    Button28,
    Button29,
    Button30,
    Button31
}
```

## Cursor Configuration

`ICursorConfiguration` is defined as:

```cs
public interface ICursorConfiguration
{
    CursorModes SupportedModes { get; }
    CursorModes Mode { get; set; }
    CursorStyles SupportedStyles { get; }
    CursorStyles Style { get; set; }
    CursorFlags SupportedFlags { get; }
    CursorFlags Flags { get; set; }
    RawImage? Image { get; set; }
}
```

Please note that the `Hotspot` properties present in 1.X and 2.0 have been removed given that they didn't do anything, only providing a place for the developer to store that information and use it if they want to. If the developer wants this, they should use their own variables instead.

`SupportedModes` is a bitmask containing all of the cursor modes that are supported by this backend. This must be queried before setting `Mode` - the currently active cursor mode. An exception should be thrown if an attempt is made to set `Mode` to an unsupported mode or multiple modes (i.e. multiple bits set).

`SupportedStyles` is a bitmask containing all of the cursor styles that are supported by this backend. This must be queried before setting `Style` - the currently active cursor style. An exception should be thrown if an attempt is made to set `Style` to an unsupported style or multiple styles (i.e. multiple bits set).

`Image` uses `RawImage` as-is from Silk.NET.Core, and when set to a non-null value implicitly sets `Style` to custom. As such, you must query `SupportedStyles` before using this property as well. Setting `Image` to `null` will set `Style` back to a standard cursor style, defined by the implementation. It is therefore recommended you set `Style` explicitly when disabling a custom cursor. Note that setting `Style` to a non-`Custom` value will also implicitly set this property to `null`. Setting `Mode` **to** `Custom` explicitly is undefined behaviour, as `Image` won't be set at the time of setting `Mode`.

`SupportedFlags` is a bitmask containing other supported options for the cursor which can be mixed and matched if supported. This must be queried before setting `Flags` - the currently active options. An exception should be thrown if an attempt is made to set an unsupported flag on `Flags`. Unlike the other properties, `Flags` can have multiple bits set.

`Flags` replaces `IsConfined`, which was undefined behaviour on platforms where it was not supported in 2.X - now with `SupportedFlags` you can query its support before setting it.

### Enums

```cs
[Flags]
public enum CursorModes
{
    Normal,
    Hidden = 1 << 0,
    Disabled = 1 << 1,
    Raw = 1 << 2
}
```
```cs
[Flags]
public enum CursorStyles
{
    Default,
    Arrow = 1 << 0,
    IBeam = 1 << 1,
    Crosshair = 1 << 2,
    Hand = 1 << 3,
    HResize = 1 << 4,
    VResize = 1 << 5,
    Custom = 1 << 6,
}
```
```cs
[Flags]
public enum CursorFlags
{
    None,
    Confined = 1 << 0
}
```

# Keyboard Input

Once again, the interface is very simple.

```cs
public interface IKeyboard : IInputDevice
{
    ref readonly KeyboardState State { get; }
    string? ClipboardText { get; set; }
    void BeginInput();
    void EndInput();
}
```

`State` is the device state as defined earlier.

`BeginInput` starts recording textual input, bringing up the on-screen keyboard on platforms where this is needed (i.e. mobile). The `State.Text` property will not be populated until after this is called.

`ClipboardText` allows getting and setting the text on the user's clipboard so they can paste information to/from your application in others.

`KeyboardState` is defined as follows:

```cs
public readonly record struct KeyboardState
(
    InputReadOnlyList<char>? Text,
    KeyState Keys
);
```

`Text` contains the characters typed on the keyboard since `IKeyboard.BeginInput`, and accounts for backspaces. This is cleared (set to `null`) when `IKeyboard.EndInput` is called, and will not be non-`null` again until another `IKeyboard.BeginInput` call. Given that `KeyChar` events are raised one character at a time, this property will update one character at a time to keep the state consistent with the event.

**INFORMATIVE TEXT:** This is something we can optimize in `InputList` to not be allocatey, rest assured it is not acceptable to the Silk.NET team to allocate a new list for every character.

```cs
public readonly record struct KeyState
(
    InputReadOnlyList<Key> Down
)
{
    public bool this[KeyName btn] { get; }
    public bool this[int scancode] { get; }
}
```

The indexer returns `true` if a particular key is pressed, false otherwise. If the developer wishes to enumerate the key state, they must explicitly enumerate through the `Down` buttons.

**INFORMATIVE TEXT:** This struct only exists so we can implement an indexer that accepts a `KeyName` or scancode, given that `Down` is effectively just a list and only takes an `int` index as a result. 

The indexer will be implemented in terms of `Down`, which is the only property that a backend will need to set.

Note because not all keys are named, and because some developers may prefer to use scancodes instead, a `Key` struct is used instead of just having the list be a list of key names.

```cs
public readonly record struct Key(KeyName Name, int Scancode);
```

`KeyName` will be `Unknown` for scancode-only, unnamed keys.

Changes to `KeyboardState` also have matching handler methods which are subject to the handler method rules i.e. the backend should call them in the order in which the backend received the events where possible etc (read the Input Handlers section).

```cs
public interface IKeyboardInputHandler : IInputHandler
{
    void HandleKeyDown(KeyDownEvent @event);
    void HandleKeyUp(KeyUpEvent @event);
    void HandleKeyChar(KeyCharEvent @event);
}
```

`HandleKeyDown` must be called when a `Key` is added to the `KeyState.Down` list.

`HandleKeyUp` must be called when a `Key` is removed from the `KeyState.Down` list.

`HandleKeyChar` must be called when a character is added to `KeyboardState.Text`.


## Enums

```cs
public enum KeyName
{
    Unknown = 0,
    Space,
    Apostrophe /* ' */,
    Comma /* , */,
    Minus /* - */,
    Period /* . */,
    Slash /* / */,
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
    Semicolon /* ; */,
    Equal /* = */,
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
    LeftBracket /* [ */,
    BackSlash /* \ */,
    RightBracket /* ] */,
    GraveAccent /* ` */,
    Escape,
    Enter,
    Tab,
    Backspace,
    Insert,
    Delete,
    Right,
    Left,
    Down,
    Up,
    PageUp,
    PageDown,
    Home,
    End,
    CapsLock,
    ScrollLock,
    NumLock,
    PrintScreen,
    Pause,
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
    KeypadDecimal,
    KeypadDivide,
    KeypadMultiply,
    KeypadSubtract,
    KeypadAdd,
    KeypadEnter,
    KeypadEqual,
    ShiftLeft,
    ControlLeft,
    AltLeft,
    SuperLeft,
    ShiftRight,
    ControlRight,
    AltRight,
    SuperRight,
    Menu
}
```

The `KeyName` enum is exactly the same as the `Key` enum in 2.X. The integral values of each enumerant, not included here, must match the en-US scancode for that key. A backend must match a scancode to a `KeyName` as if it were an en-US scancode, as this is the keyboard layout from which these key names were derived.

The Silk.NET team wishes to reserve the right to remove any key names which do not have a matching en-US scancode. This is because the above enum is just copied and pasted from 2.X, and has not been cross-referenced with the keyboard layout at this time.

# Gamepad Input

```cs
public interface IGamepad : IInputDevice
{
    ref readonly GamepadState State { get; }
    IReadOnlyList<IMotor> VibrationMotors { get; }
}
```

`State` is the device state as defined earlier.

`VibrationMotors` enumerates the vibration motors on the device. The values within `IMotor` do not change according to end user input, as such they are not encapsulated in the `State`, following the same principles as `ICursorConfiguration`.

`IMotor` is defined as follows:
```cs
public interface IMotor
{
    float Speed { get; set; }
}
```

This is exactly as in 2.X.

**INFORMATIVE TEXT:** It is possible that, should integration with DualSense controllers be implemented, that more properties are added to `IMotor` than just `Speed`.

`GamepadState` is defined as follows:
```cs
public readonly record struct GamepadState
(
    JoystickButtonState Buttons,
    DualReadOnlyList<Vector2> Thumbsticks,
    DualReadOnlyList<float> Triggers,
);
```

`GamepadState` reuses a lot of the joystick API types, which are defined later in this proposal.

`Thumbsticks` contain the two thumbsticks on this gamepad. The X and Y values within this list range from -1 to 1: -1 being leftmost, and 1 being rightmost.

`Triggers` contains the two triggers on thsi gamepad. The values within this list range from 0 to 1: 0 being unpressed, and 1 being fully pressed.

Note the use of the `DualReadOnlyList` type. This is basically just:
```cs
public readonly struct DualReadOnlyList<T> : IReadOnlyList<T>
{
    public readonly T Left;
    public readonly T Right;
}
```

This is used where the list will only ever have exactly two elements, mainly because the "gamepad" form factor is standard and it doesn't make sense to have multiple thumbsticks or triggers given a human only has two thumbs or index fingers. More exotic devices should be exposed using the joystick API.

Changes to `GamepadState` also have matching handler methods which are subject to the handler method rules i.e. the backend should call them in the order in which the backend received the events where possible etc (read the Input Handlers section).

```cs
public interface IGamepadInputHandler : IInputHandler
{
    void HandleButtonDown(GamepadDownEvent @event);
    void HandleButtonUp(GamepadUpEvent @event);
    void HandleThumbstickMove(GamepadThumbstickMoveEvent @event);
    void HandleTriggerMove(GamepadTriggerMoveEvent @event);
}
```

`HandleButtonDown` must be called when a button is added to `GamepadState.Buttons.Down`.

`HandleButtonUp` must be called when a button is removed from `GamepadState.Buttons.Down`.

`HandleThumbstickMove` must be called when any value of `GamepadState.Thumbsticks` changes.

`HandleTriggerMove` must be called when any value of `GamepadState.Triggers` changes.

# Joystick Input

This is the polyglot interface for any other human input device that roughly meets the description of being "joystick".

```cs
public interface IJoystick : IInputDevice
{
    ref readonly JoystickState State { get; }
}
```
```cs
public readonly record struct JoystickState
{
    InputReadOnlyList<float> Axes,
    JoystickButtonState Buttons,
    InputReadOnlyList<Vector2> Hats
}
```

This is pretty closely modeled as in 2.X: `Axes` containing the individual axes that can be represented by this joystick, `Buttons` containing the buttons which can be pressed, and `Hats` containing the hats.

**INFORMATIVE TEXT:** The only difference is `Hats` is now a `Vector2` instead of a `Position2D`. It is still intended that the X and Y values are only ever `0` or `1`, but this is not a requirement for more exotic backends.

`JoystickButtonState` is defined as follows:
```cs
public readonly record struct JoystickButtonState
(
    InputReadOnlyList<JoystickButton> Down
)
{
    public bool this[JoystickButton btn] { get; }
}
```

The indexer returns `true` if a particular button is pressed, false otherwise. If the developer wishes to enumerate the button state, they must explicitly enumerate through the `Down` buttons.

**INFORMATIVE TEXT:** This struct only exists so we can implement an indexer that accepts a `JoystickButton`, given that `Down` is effectively just a list and only takes an `int` index as a result.

The indexer will be implemented in terms of `Down`, which is the only property that a backend will need to set.

`JoystickButton` is defined as follows:
```cs
public enum JoystickButton
{
    Unknown,
    ButtonDown,
    A = ButtonDown,
    ButtonRight,
    B = ButtonRight,
    ButtonLeft,
    X = ButtonLeft,
    ButtonUp,
    Y = ButtonUp,
    LeftBumper,
    RightBumper,
    Back,
    Start,
    Home,
    LeftStick,
    RightStick,
    DPadUp,
    DPadRight,
    DPadDown,
    DPadLeft
}
```

Changes to `JoystickState` also have matching handler methods which are subject to the handler method rules i.e. the backend should call them in the order in which the backend received the events where possible etc (read the Input Handlers section).

```cs
public interface IJoystickInputHandler : IInputHandler
{
    void HandleButtonDown(JoystickDownEvent @event);
    void HandleButtonUp(JoystickUpEvent @event);
    void HandleAxisMove(JoystickAxisMoveEvent @event);
    void HandleHatMove(JoystickHatMoveEvent @event);
}
```

`HandleButtonDown` must be called when a button is added to `JoystickState.Buttons.Down`.

`HandleButtonUp` must be called when a button is removed from `JoystickState.Buttons.Down`.

`HandleAxisMove` must be called when any value of `JoystickState.Axes` changes.

`HandleHatMove` must be called when any value of `JoystickState.Hats` changes.

# Meeting Notes

## 05/08/2021

This also includes notes for [Enhanced Input Events]((Superseded)%20Proposal%20-%20Enhanced%20Input%20Events) as well as the previous version of this proposal.

- Document the change in the enhanced input events (migration guide?)
- Record struct ASAP when available to us, unanimous agreement
    - no need for meeting clarification 
- Make IsConnected less meaningful
- Return `IReadOnlyList<T>` 
- Make input states structs (immutable)
    - have a `State` readonly property
    - have methods for all settable things (where necessary)
 - @HurricanKai To rework Multi Backend Input the proposal slightly

## 25/02/2022

[Video](https://youtu.be/dac3t0oh3VU?t=3722)

- Approved, but do make the joystick buttons direction instead of Xbox-opinionated ABXY.
- Structs are good for inputs. Help with versioning and more performant if you pass more than ~4-5 args.
- Both event-driven input and state-based input available.
    - Call Update with an IInputHandler to get events in the order they were received, pass null to just use the state-based API
    - State will always be updated regardless of null
- Some examples on using gamepads, keyboards, and mice in the same game would be appreciated.
    - (Silk is fine with you using all simultaneously, you don't need to tell it to switch)
- e.g. what if you want to assert that spacebar was hit exactly 2 times, or one before a frame and one after a frame?
    - If spacebar was pressed between two frames, you will get up and down events for each press.
    - Examples would be appreciated.
- Engines are moving towards an "input action" model, where you have something like "Jump" and then have buttons mapped to that.
    - If a user wants to jump, is A/X/Space pressed? It's an inverse mapping to what we have today.
    - Possible extension point/on top of this API.
- Enums are potentially opinionated for naming.
    - Perhaps we could have something like the Key struct for joysticks as well?
    - GLFW doesn't support anything other that the buttons we've exposed today.
    - Not sure that having an integer helps if we haven't named it at all.
    - Introducing multiple names for a single enum should be fine.
    - Most trivial example is Nintendo controllers vs the Xbox controllers, A/B and X/Y are swapped (could be confusing!). Either going to assume that A = Nintendo's A (middle right) or A = Xbox A (bottom button)
    - **Rename to be positional rather than opinionated.**
    - More nuanced buttons can be via the joystick API, and gamepad kept a standard controller. We can't accomodate for everything, so we need to make concessions and be opinionated for gamepad, and leave the more exotic stuff for joystick.
    - We could just have ISteamControllerGamepad on top of IGamepad for controllers with touch pads, for example.
    - Take keyboards: you have integer-identified buttons but no keyboard layout is the same. An API is built on top of that abstract concept and query "what does that button represent" - on the high-level side we could have a nicer abstraction.
    - Comes back to that concept of button codes.
    - Nice and easy API for the common case, need for esoteric features like touchpads then you can actually go and add that support, you just need to do some more additional work.
    - Difficult to say where this starts and ends: we might want to expose all of the buttons, but we also want to expose low-level features then we might want to expose all of the motors, then all the lights, etc etc: where does it end?!
    - Difficult to tell what we can and can't support, and comes back to what the backends can actually do.
    - Basically every OS exposes a "here's the raw PCI device ID, and here's a byte array of the data and what HID input it came from" - low-level API is very primitive
    - Could always add another input backend.
    - "Easier to get a smaller thing done now than have a larger thing in the works forever" - @Redhacker
    - What we have today is a lot of what most people will want to use. A low-level thing could be built _as a parallel_.
    - **Think about low-level input in the future in addition to this**
    - Could we expose at least the vendor ID/device ID to the developer (in raw form or common vendor enums) to mitigate this for now.
    - Notably, the same vendor/device information by Vulkan/DirectX and any audio device - it's a very common concept.
    - **Think about exposing vendor and device IDs**
        - Potentially modifying GLFW to get us that

**ACTIONS**
- [x] Rename ABXY to be less opinionated, and alias ABXY to that.

**FUTURE**
- [ ] Think about an "input action" model
- [ ] Add examples on using gamepads, keyboards, and mice in the same game.
- [ ] Think about low-level input in the future in addition to this
- [ ] Think about exposing vendor and device IDs
