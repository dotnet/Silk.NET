# Summary
Proposal API for backend-agnostic, refactored Input via keyboards, mice, and controllers.

# Contributors
- Dylan Perks (@Perksey)

# Current Status
- [x] Proposed
- [ ] Discussed with Working Group
- [ ] Approved
- [ ] Implemented

# Design Decisions
- This proposal, while aiming to keep the same look and feel as the 2.0 API, is a complete redesign of the Input API with the following goals:
    - Input backends can be added and removed at will to a central input context object.
    - All input devices, regardless of what backends they come from, can be accessed from a central input context object.
    - Should the Silk.NET team design more APIs for more devices (for example VR hands using OpenXR) in the future, this can be added in a non-breaking way.
    - All input devices instead of exposing properties only expose a single `State` property, with additional properties and/or methods for writable state (i.e. vibration motors, mouse position). This also addresses comments from the Working Group on previous iterations of this proposal, where the Working Group expressed interest in the state being immutable and trivially capturable.
    - Ensuring the input API is accessible and easy to use (e.g. this is why later in the proposal we have made properties on the state structures that just forward to the underlying device object)
    - Addressing APIs that the userbase frequently had issues/distaste with. For example, events are no longer on each individual 
- This proposal aims to keep the look and feel of the Input APIs intended for general consumption similar to that of 2.0.
- This proposal incorporates/supersedes the Enhanced Input Events proposal.
- This proposal assumes knowledge of the Windowing 3.0 proposal.
- This proposal assumes knowledge of Silk.NET.Core 2.0.

Please note that text marked **INFORMATIVE TEXT** does not form part of this proposal's requirements or proposed API, and is merely text to help the reader understand our intentions. Informative text is not well-defined, and may not reflect the actual implementation.

# Reference Implementation

Similar to Windowing 3.0, a reference implementation will be included in the main `Silk.NET.Input` package which uses the same API or family of APIs as Windowing's reference implementation. This will be exposed by the `InputWindowExtensions` class.

```cs
public static class InputWindowExtensions
{
    public static IInputBackend CreateInputBackend(this NativeWindow window);
    public static IInputBackend CreateInputBackend(this INativeWindowSource window);
    public static InputContext CreateInput(this NativeWindow window);
    public static InputContext CreateInput(this INativeWindowSource window);
}
```

The `CreateInputBackend` will create an instance of the reference implementation for the given `NativeWindow`. The `INativeWindowSource` overloads just forward to the `NativeWindow` overload. This is because `ISurface` will implement `INativeWindowSource`, so the extension methods will be usable on an `ISurface` without having a hard reference between Windowing and Input.

The `CreateInput` methods simply return an `InputContext` preconfigured with the backend created by `CreateInputBackend` for ease of use.

**NOTE:** As part of this proposal, `INativeWindow` is renamed to `NativeWindow` and changed from an `interface` to a `readonly record struct`. The API is otherwise exactly the same.

# Devices, Backends, and Contexts

Input devices all inherit from a root interface.

```cs
public interface IInputDevice
{
    nint BackendId { get; }
    string Name { get; }
}
```

`BackendId` is an integral identifier for this device unique to this backend **only** - i.e. it is not globally unique, and if you have an input context with multiple backends there may be multiple devices with a particular `BackendId`. It may be a handle to memory, or it may be a generic integral index - this is implementation-defined.

`Name` is a rough description of the input device. Its value is not intrinsically meaningful.

All devices originate from a context.

```cs
public interface IInputBackend
{
    string Name { get; }
    nint Handle { get; }
    IReadOnlyList<IInputDevice> Devices { get; }
    void Update();
}
```

`Name` is a rough description of the input backend. Its value is not intrinsically meaningful.

`Handle` is a globally-unique handle to memory for this input backend. The memory this handle actually points to is implementation-defined.

`Devices` enumerates all of the **connected** devices available from this input backend. When a device is disconnected, its `IInputDevice` object should be discarded by all that consumed it, as it can not be relied upon for being reused by the input backend. An implementation is welcome to reuse old objects, but this is strictly implementation-defined. A device not being present in the `Devices` list is sufficient evidence that a device has been disconnected.

`Update` will update the state of all devices contained within this input backend. The value of the `State` properties on each device must not change until this method is called. This is a departure from 1.0's and 2.0's model of updating state as soon as new information is available, which has resulted in lots of inconsistencies in the past.

All of the `Devices` and `Update`s are aggregated and coordinated by a central input context object.

```cs
public partial class InputContext
{
    public Mice Mice { get; }
    public Keyboards Keyboards { get; }
    public Gamepads Gamepads { get; }
    public Joysticks Joysticks { get; }
    public IReadOnlyList<IInputDevice> Devices { get; }
    public List<IInputBackend> Backends { get; }
    public void Update();
}
```

The central input object acts as the main entry point into the Input API, and is responsible for comparing the state reported by the devices for differences between `Update` calls (raising events as necessary). 

`Mice`, `Keyboards`, `Gamepads`, and `Joysticks` are all custom `IReadOnlyList` types for enumerating the **state** (given that the actual input objects are thin, and the state contains a reference to the original device anyway). However, these custom types also contain the events. This is so we can "scope" the events, rather than putting them at the top-level and having to call the events `MouseButtonDown`, `JoystickButtonDown`, etc.

By virtue of the `State` properties not updating until `IInputBackend.Update` is called, the states enumerated by the lists will not change until `Update` is called.

`Update` will call `IInputBackend.Update` on each of the `Backends`, and retrieve the state for each device contained in each backend. As it is doing this, it updates the lists within the input context.

After the lists have been updated, the `Update` method compares the old state and the new state for that device and raises events accordingly. If there is no old state available for a device, the `ConnectionChanged` event (read on!) within each of the custom lists is called with a value of `true` signifying that a device has connected. Likewise, if there is no new state available for a device we have old state for, the `ConnectionChanged` event will be called with a value of `false` signifying that a device has been disconnected.

`Backends` is a mutable list of input backends. Changes to this list do not take effect until `Update` is called again. The `ConnectionChanged` rules above will still be respected e.g. when you remove a backend, all of its devices will have a disconnected event raised for them.

`Devices` contains all devices reported by all backends, including devices that do not necessarily fit into one of our more specialized wrapper lists. This means that if a backend has a device type we do not recognise, it will be accessible via this list.

## Custom List Types

These are relatively simple, though note that we explicitly implement the `IReadOnlyList` indexer in favour of one that returns a `ref readonly` type and a corresponding custom enumerator.

The actual type of the custom enumerator at this time the Silk.NET team would like to leave implementation defined, but with the following requirements:
- The `Next` method must return a `ref readonly` type.
- The type can be used as an operand in a `foreach` loop
- While it may not necessarily implement `IEnumerator<T>`, it must implement the surface API as if it does where `T` is a `ref readonly` type (which is forbidden in the language today).  

The Silk.NET team does **not** wish to reserve the right to breaking changes for custom enumerator types, so once this type has been defined by the implementation it will remain the same type throughout the entirety of 3.X's service life. 

All other details about the nature of the `IReadOnlyList` implementation (i.e. backing buffer) are implementation-defined.

```cs
public partial class Mice : IReadOnlyList<MouseState>
{
    public ref readonly MouseState this[int index] { get; }
    MouseState IReadOnlyList<MouseState>.this[int index] { get; }
    
    public <implementation defined> GetEnumerator();
    IEnumerator<MouseState> IEnumerable<MouseState>.GetEnumerator();
    
    public event Action<ButtonEvent<MouseState, MouseButton>>? ButtonDown;
    public event Action<ButtonEvent<MouseState, MouseButton>>? ButtonUp;
    public event Action<ClickEvent<MouseState, MouseButton>>? Click;
    public event Action<ClickEvent<MouseState, MouseButton>>? DoubleClick;
    public event Action<AxisEvent<MouseState, Vector2>>? CursorMove;
    public event Action<AxisEvent<MouseState, Vector2>>? Scroll;
}

public partial class Keyboards : IReadOnlyList<KeyboardState>
{
    public ref readonly KeyboardState this[int index] { get; }
    KeyboardState IReadOnlyList<KeyboardState>.this[int index] { get; }
    
    public <implementation defined> GetEnumerator();
    IEnumerator<KeyboardState> IEnumerable<KeyboardState>.GetEnumerator();

    public event Action<ButtonEvent<KeyboardState, Key>>? KeyDown;
    public event Action<ButtonEvent<KeyboardState, Key>>? KeyUp;
    public event Action<TextEvent<KeyboardState>>? TextInput;
}

public partial class Gamepads : IReadOnlyList<GamepadState>
{
    public ref readonly GamepadState this[int index] { get; }
    GamepadState IReadOnlyList<GamepadState>.this[int index] { get; }
    
    public <implementation defined> GetEnumerator();
    IEnumerator<GamepadState> IEnumerable<GamepadState>.GetEnumerator();
    
    public event Action<ButtonEvent<GamepadState, JoystickButton>>? ButtonDown;
    public event Action<ButtonEvent<GamepadState, JoystickButton>>? ButtonUp;
    public event Action<AxisEvent<GamepadState, Vector2>>? ThumbstickMove;
    public event Action<AxisEvent<GamepadState, float>>? TriggerMove;
}

public partial class Joysticks : IReadOnlyList<JoystickState>
{
    public ref readonly JoystickState this[int index] { get; }
    JoystickState IReadOnlyList<JoystickState>.this[int index] { get; }
    
    public <implementation defined> GetEnumerator();
    IEnumerator<JoystickState> IEnumerable<JoystickState>.GetEnumerator();

    public event Action<ButtonEvent<JoystickState, JoystickButton>>? ButtonDown;
    public event Action<ButtonEvent<JoystickState, JoystickButton>>? ButtonUp;
    public event Action<AxisEvent<JoystickState, float>>? AxisMove;
    public event Action<AxisEvent<JoystickState, Vector2>>? HatMove;
}
```

Unlike 1.0 and 2.0, this proposal uses `readonly record struct`s as their only argument for the event action. This allows us to provide more information to the event handlers without breaking in the future. These types are farily simple:

```cs
public readonly record struct ButtonEvent<TDevice, TButton>(in TDevice DeviceState, TButton Button);
public readonly record struct ClickEvent<TDevice, TButton>(in TDevice DeviceState, TButton Button, Vector2 Position);
public readonly record struct AxisEvent<TDevice, TAxis>(in TDevice DeviceState, int Index, TAxis OldValue, TAxis NewValue);
public readonly record struct TextEvent<TDevice>(in TDevice DeviceState, string? OldText, string? NewText);
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
    MouseState State { get; }
    ICursorConfiguration Cursor { get; }
    void SetPosition(Vector2 pos);
}
```

`State` is the device state as defined earlier.

`Cursor` contains the cursor configuration. This isn't actually state that the end user can change, and has been made an interface rather than a state struct accordingly.

`SetPosition` allows moving the mouse cursor without the end user physically moving their mouse.

The device state returned by `State` fills out the following structure:

```cs
public struct MouseState
{
    public IMouse Device { get; init; }
    public MouseButtonState Buttons { get; init; }
    public ICursorConfiguration Cursor { get; } // forwards to Device.Cursor
    public Vector2 Position { get; set; } // all sets after the first set forward to Device.SetPosition
    public Vector2 WheelPosition { get; init; }
}
```

For ease-of-use, all APIs on `Device` (other than state) are accessible via the state struct, as indicated in the comments in the API snippet.

`MouseButtonState` is defined as:
```cs
public struct MouseButtonState
{
    public bool this[MouseButton btn] { get; }
    public InputReadOnlyList<MouseButton> Down { get; init; }
    public InputReadOnlyList<MouseButton> Up { get; }
}
```

The indexer returns `true` if a particular button is pressed, false otherwise. If the developer wishes to enumerate the button state, they must explicitly enumerate through even the `Down` buttons or `Up` buttons.

`Up` and the indexer will be implemented in terms of `Down`, which is the only property that a backend will need to set.

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
    KeyboardState State { get; }
    void BeginInput();
    void EndInput();
    void SetClipboardText(string? clipboard);
}
```

`State` is the device state as defined earlier.

`BeginInput` starts recording textual input, bringing up the on-screen keyboard on platforms where this is needed (i.e. mobile). Unlike 2.0, this is now required given that textual input is now on a full-string basis rather than a per-char basis, and we don't want to record textual input unless the user asks us to.

For instance, instead of a `KeyChar` event being raised every time a character is pressed or repeated, a `TextInput` event is raised as the string is being built alleviating the need for developers to build the string themselves, given that the primary use of this event is for GUI input.

`SetClipboardText` allows setting the text on the user's clipboard so they can paste information from your application in others.

`KeyboardState` is defined as follows:

```cs
public struct KeyboardState
{
    public IKeyboard Device { get; init; }
    public string? ClipboardText { get; set; } // all sets after the first set forward to Device.SetClipboardText
    public string? Text { get; init; }
    public KeyState Keys { get; init; }
}
```

For ease-of-use, all APIs on `Device` (other than state) are accessible via the state struct, as indicated in the comments in the API snippet.

```cs
public readonly struct KeyState
{
    public bool this[KeyName btn] { get; }
    public bool this[int scancode] { get; }
    public InputReadOnlyList<Key> Down { get; init; }
    public InputReadOnlyList<Key> Up { get; }
}
```

The indexer returns `true` if a particular key is pressed, false otherwise. If the developer wishes to enumerate the key state, they must explicitly enumerate through even the `Down` buttons or `Up` buttons.

`Up` and the indexer will be implemented in terms of `Down`, which is the only property that a backend will need to set. Scancode-only keys will not be present in `Up`.

Note because not all keys are named, and because some developers may prefer to use scancodes instead, a `Key` struct is used instead of just having the list be a list of key names.

```cs
public readonly record struct Key(KeyName Name, int Scancode);
```

`KeyName` will be `Unknown` for scancode-only, unnamed keys.

## Enums

```cs
public enum KeyName
{
    Unknown,
    Space,
    Apostrophe /* ' */,
    Comma /* , */,
    Minus /* - */,
    Period /* . */,
    Slash /* / */,
    Number0,
    D0,
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
    World1 /* non-US #1 */,
    World2 /* non-US #2 */,
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
