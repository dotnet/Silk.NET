# Summary
Proposal API for backend-agnostic, refactored Input via keyboards, mice, and controllers.

# Contributors
- Dylan Perks (@Perksey)
- Dom Portera (@domportera)

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
public interface IInputDevice : IEquatable<IInputDevice>
{
    nint Id { get; }
    string Name { get; }
}
```

`Id` is an globally-unique integral identifier for this device.

`Name` is a rough description of the input device. Its value is not intrinsically meaningful.

All devices originate from a backend.

An `IInputDevice` object shall be equatable to any such object retrieved from the same backend where `Id` is equal.

`IInputDevice` objects must not store any managed state, and if there is a requirement for this in a future extension of
this API then this **must** be defined in such a way that the state storage and lifetime is user-controlled. While
`IInputDevice` objects are equatable based on `Id`s, if a physical device disconnects and reconnects the `IInputBackend`
does not provide a guarantee that the same object will be returned (primarily because doing so would require the
`IInputBackend` to keep track of every object it's ever created), rather a "compatible" one that acts identically to
the original object. This is completely benign if the object is nothing but a wrapper to the backend anyway. If there is
unmanaged state (e.g. a handle to a device that must be explicitly closed upon disconnection), then it is expected that
even in the event of reconnection, old objects (e.g. created with a now-disposed handle) **shall** still work for the
newly-reconnected device. A common way this could be implemented is storing the handles in the `IInputBackend`
implementation instead in the form of a mapping of physical device IDs (`Id`) to those handles. This solves the object
lifetime problem while also not adding undue complications to user code. 

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

`Devices` enumerates all of the **connected** devices available from this input backend. When a device is disconnected,
its `IInputDevice` **shall** no longer function and will not be enumerated by this list. When a device is connected, an
`IInputDevice` with that physical device ID **shall** be added to this list. In addition, upon connection any past
`IInputDevice` objects previously enumerated by this list on this `IInputBackend` instance **shall** also regain
function the device being added to this list shares the same physical device ID as those previous instances. All such
previous instances **shall** be equatable to one another and to the `IInputDevice` instance added to this list. An
implementation is welcome to reuse old objects, but this is strictly implementation-defined. A device not being present
in the `Devices` (checked using `IInputDevice`'s `IEquatable<IInputDevice>` implementation) list is sufficient evidence
that a device has been disconnected.

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
1. The backend has a queued "pointer down" event for a mouse, for example.
2. The backend updates the `State` of the relevant `IPointerDevice` for that button press.
3. The backend calls `HandleButtonChanged` with `IsDown` set to `true` on the `IPointerInputHandler` (if applicable).
4. The backend has a queued "pointer up" event on that mouse.
5. The backend updates the `State` of the relevant `IPointerDevice` for that button release.
6. The backend calls `HandleButtonChanged` with `IsDown` set to `false` on the `IPointerInputHandler` (if applicable).

This allows the actor to work with the whole device state with the device state being representative of the time that the original event occurred.

More actors will be defined later in the proposal.

All of the `Devices` and `Update`s are aggregated and coordinated by a central input context object.

# Contexts

```cs
public partial class InputContext
{
    public Pointers Pointers { get; }
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

`Pointers`, `Keyboards`, `Gamepads`, and `Joysticks` are all custom `IReadOnlyList` types for enumerating the devices. However, these custom types also contain the events. This is so we can "scope" the events, rather than putting them at the top-level and having to call the events `PointerButtonChanged`, `JoystickButtonChanged`, etc.

By virtue of the `State` properties not updating until `IInputBackend.Update` is called, the states of the devices enumerated by the lists will not change until `Update` is called.

`Update` will call `IInputBackend.Update` on each of the `Backends`, passing in a handler which implements `IInputHandler`, `IPointerInputHandler`, `IKeyboardInputHandler`, `IGamepadInputHandler`, and `IJoystickInputHandler` with each of the methods invoking a matching event defined in "Custom List Types" or on the input context itself (such as `ConnectionChanged`).

`Backends` is a mutable list of input backends. Until `Update` is called again, no device lists, state, etc on the context will be updated. The `ConnectionChanged` rules above will still be respected e.g. when you remove a backend, all of its devices will have a disconnected event raised for them.

`Devices` contains all devices reported by all backends, including devices that do not necessarily fit into one of our more specialized wrapper lists. This means that if a backend has a device type we do not recognise, it will be accessible via this list.

## Custom List Types

These are relatively simple list wrappers with the events fired when state changes.

```cs
public partial class Pointers : IReadOnlyList<IPointerDevice>
{
    public PointerClickConfiguration ClickConfiguration { get; set; }
    public event Action<ButtonChangedEvent<PointerButton>>? ButtonChanged;
    public event Action<PointerClickEvent>? Click;
    public event Action<PointerClickEvent>? DoubleClick;
    public event Action<PointChangedEvent>? PointChanged;
    public event Action<MouseScrollEvent>? MouseScroll;
}

public partial class Keyboards : IReadOnlyList<IKeyboard>
{
    public event Action<KeyChangedEvent>? KeyChanged;
    public event Action<KeyCharEvent>? KeyChar;
}

public partial class Gamepads : IReadOnlyList<IGamepad>
{
    public event Action<ButtonChangedEvent<JoystickButton>>? ButtonChanged;
    public event Action<GamepadThumbstickMoveEvent>? ThumbstickMove;
    public event Action<GamepadTriggerMoveEvent>? TriggerMove;
}

public partial class Joysticks : IReadOnlyList<IJoystick>
{
    public event Action<ButtonChangedEvent<JoystickButton>>? ButtonChanged;
    public event Action<JoystickAxisMoveEvent>? AxisMove;
    public event Action<JoystickHatMoveEvent>? HatMove;
}
```

All events will be raised when their matching handler methods are called, with the exception of `Click` and `DoubleClick` which are implemented on top of `ButtonChanged` (as in 2.X).

`DoubleClick` will be raised if `Pointers.ButtonChanged` is raised two consecutive times with `IsDown` set to true within `MouseClickConfiguration.DoubleClickTime` milliseconds, and the `MouseState.Position`'s `X` or `Y` did not change more than `MouseClickConfiguration.DoubleClickRange` between the two events. If these conditions are not met, `Click` is raised instead. For the avoidance of doubt, the behaviour of the click implementation here is exactly as it is in 2.X.

**INFORMATIVE TEXT:** The click implementation may also even be exactly the same implementation as it is 2.X copied and pasted into 3.0, given a lot of research and effort went into this by the community contributor that implemented it.

`MouseClickConfiguration` is defined as follows:

```cs
public record struct MouseClickConfiguration(int DoubleClickTime, float DoubleClickRange);
```

This will be configurable on `Mice` (i.e. via `InputContext.Mice.ClickConfiguration`). The Silk.NET team wishes to reserve the right to define the initial values set on `Mice.ClickConfiguration`, but these will most likely be the same as in 2.X.

Unlike 1.0 and 2.0, this proposal uses `readonly record struct`s as their only argument for the event action. This allows us to provide more information to the event handlers without breaking in the future. These types are farily simple:

```cs
public readonly record struct ConnectionEvent(IInputDevice Device, long Timestamp, bool IsConnected);
public readonly record struct KeyChangedEvent(IKeyboard Keyboard, long Timestamp, Button<KeyName> Key, Button<KeyName> Previous, bool IsRepeat, KeyModifiers Modifiers);
public readonly record struct KeyCharEvent(IKeyboard Keyboard, long Timestamp, char? Character);
public readonly record struct ButtonChangedEvent<T>(IButtonDevice<T> Device, long Timestamp, Button<T> Button, Button<T> Previous) where T : struct, Enum;
public readonly record struct PointChangedEvent(IPointerDevice Pointer, long Timestamp, TargetPoint? OldPoint, TargetPoint? NewPoint);
public readonly record struct PointerGripChangedEvent(IPointerDevice Pointer, long Timestamp, float GripPressure, float Delta);
public readonly record struct PointerTargetChangedEvent(IPointerDevice Pointer, long Timestamp, IPointerTarget Target, bool IsAdded, Box3F<float> OldBounds, Box3F<float> NewBounds);
public readonly record struct MouseScrollEvent(IMouse Mouse, long Timestamp, TargetPoint Point, Vector2 WheelPosition, Vector2 Delta);
public readonly record struct PointerClickEvent(IPointerDevice Pointer, long Timestamp, TargetPoint Point, MouseButton Button);
public readonly record struct JoystickHatMoveEvent(IJoystick Joystick, long Timestamp, Vector2 Value, Vector2 Delta);
public readonly record struct JoystickAxisMoveEvent(IJoystick Joystick, long Timestamp, int Axis, float Value, float Delta);
public readonly record struct GamepadThumbstickMoveEvent(IGamepad Gamepad, long Timestamp, Vector2 Value, Vector2 Delta);
public readonly record struct GamepadTriggerMoveEvent(IGamepad Gamepad, long Timestamp, int Axis, float Value, float Delta);
```

`Timestamp` shall be the `Stopwatch.GetTimestamp()` at which the event was raised. This allows the user to get the
precise time of the event's occurrence, which is not otherwise possible given the requirement for state changes to be
enacted only upon a call to `Update`. 

This is the part of this proposal that incorporates the ideas in Enhanced Input Events, and is why this proposal supersedes that one.

One final point to note is that throughout the rest of the proposal the following types will be used:

```cs
public struct InputReadOnlyList<T> : IReadOnlyList<T>
{
    public InputReadOnlyList(IReadOnlyList<T> other);
}

public struct ButtonReadOnlyList<T> : IReadOnlyList<Button<T>> where T : struct, Enum
{
    public ButtonReadOnlyList(IReadOnlyList<Button<T>> other);
    public Button<T> this[T name] { get; }
}
```

The Silk.NET team wishes to reserve the right to add more constructors to this type as it sees fit.

This exists so that, should the Silk.NET choose to, we can optimize the lookup of elements while ensuring things like indexers are inlined and don't result in a virtual call if our implementation allows us to do so.

**INFORMATIVE TEXT:** For example, for joystick and mouse buttons we could use a fixed-sized bit buffer where each bit represents an individual button: 1 for pressed, 0 for unpressed. But for something like keyboard input where there are a large amount of keys, we can't do that and will likely use `Memory<T>` instead.

# Devices with Buttons

We have decided to converge functionality relating to button presses given that these are common to most device types.

```cs
public readonly record struct Button<T>(T Name, bool IsDown, float Pressure) where T : struct, Enum
{
    public static implicit operator bool(Button<T> state) => state.IsDown;
}

public interface IButtonDevice<T> : IInputDevice
{
    ButtonReadOnlyList<T> State { get; }
}
```

A common input handler will be exposed for these types:
```cs
public interface IButtonInputHandler<T> where T : struct, Enum
{
    void HandleButtonChanged(ButtonChangedEvent<T> @event);
}
```

`HandleButtonChanged` must be called when any of the `Button<T>` properties are changed.

# Pointer Input

As discussed earlier, the interface will be very simple.

```cs
public interface IPointerDevice : IButtonDevice<T>
{
    PointerState State { get; }
    ButtonReadOnlyList<T> IButtonDevice<T>.State => State.Buttons;
    IReadOnlyList<IPointerTarget> Targets { get; }
}
```

`State` is the device state as defined earlier.

`Targets` defines the targets this pointer device can naturally point to. For a touch screen, this could be a list of
displays. For a mouse, this will contain a target for the windowed cursor mode and a target for the "raw mouse input"
mode. 

A "pointer" is an abstraction over any mechanism by which a user can point to specific coordinates on a "target".
For instance, a user could use a mouse cursor to point to a target representing the window bounds. Alternatively, that
mouse could be used to point to an arbitrary place in an infinitely large ("unbounded" herein) target (this is "raw
mouse input"). Other examples of this abstraction's application are fingers being used to point to a specific place on a
touch surface, or pens pointing to a specific place on a surface. The base abstraction is deliberately extremely vague
to meet the need of "getting a position within certain bounds," which is all people really want in most cases for a
"cursor" anyway.

A target is defined as follows:
```cs
public interface IPointerTarget
{
    /// <summary>
    /// The boundary in which positions of points on this target shall fall. For <see cref="Box3F{T}.Min" />,
    /// <see cref="float.NegativeInfinity" /> shall represent the lack of a lower bound on a particular axis. For
    /// For <see cref="Box3F{T}.Max" />, <see cref="float.PositiveInfinity" /> shall represent the lack of a lower bound
    /// on a particular axis. <c>0</c> represents an unused axis that axis is <c>0</c> on both
    /// <see cref="Box3F{T}.Min" /> and <see cref="Box3F{T}.Max" />.
    /// </summary>
    Box3F<float> Bounds { get; }

    /// <summary>
    /// Gets the number of points with which the given pointer is pointing at this target.
    /// </summary>
    /// <returns>The number of points.</returns>
    /// <remarks>
    /// A single "logical" pointer device may have many points, and can optionally represent multiple physical pointers
    /// as a single logical device - this is the case where a backend supports multiple mice to control an
    /// <see cref="ICursor" /> on its "raw mouse input" target, but combines these all to a single point on its
    /// "windowed" target. This is also true for touch input - a touch screen is represented as a single touch device,
    /// where each finger is its own point.
    /// </remarks>
    int GetPointCount(IPointerDevice pointer);

    /// <summary>
    /// Gets a point with which the given pointer is pointing at this target.
    /// </summary>
    /// <param name="pointer">The pointer device.</param>
    /// <param name="point">
    /// The index of the point, between <c>0</c> and the number sourced from <see cref="GetPointCount" />.
    /// </param>
    /// <returns>The point at the given index with which the given pointer device is pointing at the target.</returns>
    TargetPoint GetPoint(IPointerDevice pointer, int point);
}
```

**FUTURE IMPROVEMENT:** This interface could be expanded to provide rotation of the target itself as well, representing
a full `Transform` structure for the space. At this time, this was not deemed necessary for inclusion, but should be a
trivial extension to add in the future.

**INFORMATIVE TEXT**: Furthermore, it is our eventual goal to be able to support considering VR hands as pointer devices
through raycasting. Such a future proposal will involve a way to create a child target within the bounds of this target
a `IPointerTarget` from that which represents the 3D world (i.e. the entire VR world is a target, and the point
representing the hand is _within_ that target - with the `TargetPoint` being populated using ``XrPosef values), where
calculation of points on those child targets are calculated using raycasting from that position.

The functionality of these APIs are described in the XML documentation inline.

A point shall be defined as follows:
```cs
/// <summary>
/// Flags describing a <see cref="TargetPoint" /> state.
/// </summary>
[Flags]
public enum TargetPointFlags
{
    /// <summary>
    /// No flags are set, indicating that the point is not being pointed at and therefore may not be valid.
    /// </summary>
    NotPointingAtTarget = 0,

    /// <summary>
    /// Indicates that the point has been resolved as a valid point at which the pointer is pointing.
    /// </summary>
    PointingAtTarget = 1 << 0
}

/// <summary>
/// Represents a point on a target at which a pointer is pointing.
/// </summary>
/// <param name="Id">
/// An integral identifier for the point. This point must be the only point for the device currently pointing at a
/// target with this identifier at any given time. If this point ceases to point at the target, then the identifier
/// becomes free for another device point. This means that this identifier can just be an index, but may be globally
/// unique depending on the backend's capabilities.
/// </param> 
/// <param name="Flags">Flags describing the state of the point.</param>
/// <param name="Position">The absolute position on the target at which the pointer is pointing.</param>
/// <param name="NormalizedPosition">
/// The normalized position on the target at which the pointer is pointing, if applicable. If this is not available
/// (e.g. due to the target being infinitely large a.k.a. "unbounded"), then this property shall have a value of
/// <c>default</c>.
/// </param>
/// <param name="Pointer">
/// A ray representing the distance and angle at which the pointer is pointing at the point on the target. A ray with an
/// orientation equivalent to an identity quaternion shall be interpreted as the point directly perpendicular to and
/// facing towards the target, with this being the default value should this information be unavailable. If distance
/// information is unavailable, this shall be equivalent to a <c>default</c> vector.
/// </param>
/// <param name="Pressure">
/// The pressure applied to the point on the target by the pointer, between <c>0.0</c> representing the minimum amount
/// of pressure and <c>1.0</c> representing the maximum amount of pressure. This shall be <c>1.0</c> if such data is
/// unavailable but the point is otherwise valid.
/// </param>
/// <param name="Target">The pointer being pointed at.</param>
public readonly record struct TargetPoint(
    int Id,
    TargetPointFlags Flags,
    Vector3 Position,
    Vector3 NormalizedPosition,
    Ray3F<float> Pointer,
    float Pressure,
    IPointerTarget Target
) {
    public bool IsValid => (Flags & Flags.PointingAtTarget) != Flags.NotPointingAtTarget;
}
```

The `PointerState` shall be defined as follows:
```cs
public class PointerState
{
    public ButtonReadOnlyList<PointerButton> Buttons { get; }
    public InputReadOnlyList<TargetPoint> Points { get; }
    public float GripPressure { get; }
}
```

`Points` represents the `TargetPoint`s this pointer is pointing at on its "native targets" i.e. that which is enumerated
by `IPointerDevice.Targets`.

`GripPressure` represents the amount of pressure the user is applying to the device itself (e.g. the pen barrel) between
`0.0` and `1.0`. This shall be `1.0` if unavailable.

Additional APIs to construct `PointerState` will be added as appropriate.

Changes to `PointerState` also have matching handler methods which are subject to the handler method rules i.e. the backend should call them in the order in which the backend received the events where possible etc (read the Input Handlers section). For the avoidance of doubt, this implies that `Timestamp` in ascending order.

The handler for pointer inputs shall be defined as follows:
```cs
public interface IPointerInputHandler : IButtonInputHandler<PointerButton>
{
    void HandleTargetChanged(PointerTargetChangedEvent @event);
    void HandlePointChanged(PointChangedEvent @event);
    void HandleGripChanged(PointerGripChangedEvent @event);
}
```

`HandleTargetChanged` must be called when properties on an `IPointerTarget` within `IPointerDevice.Targets` changes, or when
an `IPointerTarget` is added or removed to/from `IPointerDevice.Targets`. `IsAdded` shall be `true` if it has been added,
`false` if it has been removed.

`HandlePointChanged` must be called when a point within `PointerState.Points` changes.

`HandleGripChanged` must be called when `PointerState.GripPressure` changes.

These device interfaces and related APIs are designed to mirror physical hardware that the user uses to point at a
target. 

**FUTURE IMPROVEMENT:** There are many cases where applications would work better with an abstraction that creates
"virtual pointers" for each point, rather that the points being spread across many logical devices. These can be added
as non-breaking extensions to the `Pointers` class in the future, as the input context is intended to be the aggregator
of device inputs.

**FUTURE IMPROVEMENT:** The `Pointers` class is also expected to be the site of gesture recognition when proposed in the
future.

`PointerButton` shall be defined as follows:
```cs
public enum PointerButton
{
    Primary,
    Secondary,
    Button3,
    MiddleButton = Button3,
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
    EraserTip = Button30,
    Button31,
    Button32
}
```

There will be derived types for different types of pointers.

## Mouse Input

```cs
public interface IMouse : IPointerDevice
{
    MouseState State { get; }
    PointerState IPointerDevice.State => State;
    ICursorConfiguration Cursor { get; }
    bool TrySetPosition(Vector2 position);
}
```

`Cursor` contains the cursor configuration. This isn't actually state that the end user can change, and has been made an interface rather than a state struct accordingly.

`TrySetPosition` allows moving the mouse cursor without the end user physically moving their mouse. Please note that this does not immediately update `State` with the new value - the changes will be reflected next time `IInputBackend.Update` is called.

The device state returned by `State` fills out the following structure:

```cs
public class MouseState : PointerState
{
    public Vector2 WheelPosition { get; }
}
```

`WheelPosition` represents the number of times the scroll wheel (e.g. ratchets) has scrolled in a particular direction
between the previous and latest times the input was captured by the backend.

Additional APIs to construct `MouseState` will be added as appropriate.

Changes to `MouseState` also have matching handler methods which are subject to the handler method rules i.e. the backend should call them in the order in which the backend received the events where possible etc (read the Input Handlers section). For the avoidance of doubt, this implies that `Timestamp` in ascending order.

```cs
public interface IMouseInputHandler : IButtonInputHandler<PointerButton>
{
    void HandleScroll(MouseScrollEvent @event);
}
```

`HandleScroll` must be called when `MouseState.WheelPosition` changes.

Note that the click events, just as in 2.X, are not implemented by the backend and instead implemented by the input context because it is not a requirement that backends can record clicks. **INFORMATIVE TEXT:** The original reason for this requirement in 2.X is because GLFW doesn't actually send click and double click events.

## Cursor Configuration

`ICursorConfiguration` is defined as:

```cs
public readonly ref struct CustomCursor
{
    public int Width { get; init; }
    public int Height { get; init; }
    public ReadOnlySpan<int> Data { get; init; } // Rgba32 
}

public interface ICursorConfiguration
{
    CursorModes SupportedModes { get; }
    CursorModes Mode { get; set; }
    CursorStyles SupportedStyles { get; }
    CursorStyles Style { get; set; }
    CustomCursor Image { get; set; }
}
```

Please note that the `Hotspot` properties present in 1.X and 2.0 have been removed given that they didn't do anything, only providing a place for the developer to store that information and use it if they want to. If the developer wants this, they should use their own variables instead.

`SupportedModes` is a bitmask containing all of the cursor modes that are supported by this backend. This must be queried before setting `Mode` - the currently active cursor mode. An exception should be thrown if an attempt is made to set `Mode` to an unsupported mode or multiple modes (i.e. multiple bits set).

`SupportedStyles` is a bitmask containing all of the cursor styles that are supported by this backend. This must be queried before setting `Style` - the currently active cursor style. An exception should be thrown if an attempt is made to set `Style` to an unsupported style or multiple styles (i.e. multiple bits set).

`Image` when set to a non-`default` value implicitly sets `Style` to custom. As such, you must query `SupportedStyles` before using this property as well. Setting `Image` to `default` will set `Style` back to a standard cursor style, defined by the implementation. It is therefore recommended you set `Style` explicitly when disabling a custom cursor. Note that setting `Style` to a non-`Custom` value will also implicitly set this property to `default`. Setting `Mode` **to** `Custom` explicitly is undefined behaviour, as `Image` won't be set at the time of setting `Mode`.

`SupportedFlags` is a bitmask containing other supported options for the cursor which can be mixed and matched if supported. This must be queried before setting `Flags` - the currently active options. An exception should be thrown if an attempt is made to set an unsupported flag on `Flags`. Unlike the other properties, `Flags` can have multiple bits set.

`Flags` replaces `IsConfined`, which was undefined behaviour on platforms where it was not supported in 2.X - now with `SupportedFlags` you can query its support before setting it.

### Enums

```cs
[Flags]
public enum CursorModes
{
    Normal = 1 << 0,
    Confined = 1 << 1,
    Unbounded = 1 << 2,
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
    Hidden = 1 << 6,
    Custom = 1 << 7,
}
```

# Keyboard Input

Once again, the interface is very simple.

```cs
public interface IKeyboard : IButtonDevice<KeyName>
{
    KeyboardState State { get; }
    string? ClipboardText { get; set; }
    bool TryGetKeyName(KeyName key, [NotNullWhen(true)] out string? name);
    void BeginInput();
    void EndInput();
}
```

`State` is the device state as defined earlier.

`BeginInput` starts recording textual input, bringing up the on-screen keyboard on platforms where this is needed (i.e. mobile). The `State.Text` property will not be populated until after this is called.

`ClipboardText` allows getting and setting the text on the user's clipboard so they can paste information to/from your application in others.

`KeyboardState` is defined as follows:

```cs
public class KeyboardState
{
    public InputReadOnlyList<char>? Text { get; }
    public ButtonReadOnlyList<KeyName> Keys { get; }
    public KeyModifiers Modifiers { get; }
}
```

`Text` contains the characters typed on the keyboard since `IKeyboard.BeginInput`, and accounts for backspaces. This is cleared (set to `null`) when `IKeyboard.EndInput` is called, and will not be non-`null` again until another `IKeyboard.BeginInput` call. Given that `KeyChar` events are raised one character at a time, this property will update one character at a time to keep the state consistent with the event.

**INFORMATIVE TEXT:** This is something we can optimize in `InputList` to not be allocatey, rest assured it is not acceptable to the Silk.NET team to allocate a new list for every character.

Changes to `KeyboardState` also have matching handler methods which are subject to the handler method rules i.e. the backend should call them in the order in which the backend received the events where possible etc (read the Input Handlers section). For the avoidance of doubt, this implies that `Timestamp` in ascending order.

```cs
public interface IKeyboardInputHandler : IButtonInputHandler<KeyName>
{
    void HandleKeyChanged(KeyChangedEvent @event);
    void HandleKeyChar(KeyCharEvent @event);
}
```

`HandleKeyChanged` must be called in the same circumstances as `IButtonInputHandler<KeyName>.HandleButtonChanged`. The
purpose of this event duplication is to provide more keyboard-specific information if the handler has a use for it.

`HandleKeyChar` must be called when a character is added to `KeyboardState.Text`.

## Enums

```cs
public enum KeyName
{
    // These values are from usage page 0x07 (USB keyboard page).
    Unknown = 0,
    A = 4,
    B = 5,
    C = 6,
    D = 7,
    E = 8,
    F = 9,
    G = 10,
    H = 11,
    I = 12,
    J = 13,
    K = 14,
    L = 15,
    M = 16,
    N = 17,
    O = 18,
    P = 19,
    Q = 20,
    R = 21,
    S = 22,
    T = 23,
    U = 24,
    V = 25,
    W = 26,
    X = 27,
    Y = 28,
    Z = 29,
    Number1 = 30,
    Number2 = 31,
    Number3 = 32,
    Number4 = 33,
    Number5 = 34,
    Number6 = 35,
    Number7 = 36,
    Number8 = 37,
    Number9 = 38,
    Number0 = 39,
    Return = 40,
    Escape = 41,
    Backspace = 42,
    Tab = 43,
    Space = 44,
    Minus = 45,
    Equals = 46,
    LeftBracket = 47,
    RightBracket = 48,
    Backslash = 49,
    NonUs1 = 50, // US: \| Belg: µ`£ FrCa: <}> Dan:’* Dutch: <> Fren:*µ Ger: #’ Ital: ù§ LatAm: }`] Nor:,* Span: }Ç Swed: , * Swiss: $£ UK: #~.
    Semicolon = 51,
    Apostrophe = 52,
    Grave = 53,
    Comma = 54,
    Period = 55,
    Slash = 56,
    CapsLock = 57,
    F1 = 58,
    F2 = 59,
    F3 = 60,
    F4 = 61,
    F5 = 62,
    F6 = 63,
    F7 = 64,
    F8 = 65,
    F9 = 66,
    F10 = 67,
    F11 = 68,
    F12 = 69,
    PrintScreen = 70,
    ScrollLock = 71,
    Pause = 72,
    Insert = 73,
    Home = 74,
    PageUp = 75,
    Delete = 76,
    End = 77,
    PageDown = 78,
    Right = 79,
    Left = 80,
    Down = 81,
    Up = 82,
    NumLockClear = 83,
    KeypadDivide = 84,
    KeypadMultiply = 85,
    KeypadMinus = 86,
    KeypadPlus = 87,
    KeypadEnter = 88,
    Keypad1 = 89,
    Keypad2 = 90,
    Keypad3 = 91,
    Keypad4 = 92,
    Keypad5 = 93,
    Keypad6 = 94,
    Keypad7 = 95,
    Keypad8 = 96,
    Keypad9 = 97,
    Keypad0 = 98,
    KeypadPeriod = 99,
    NonUs2 = 100, // Belg:<\> FrCa:«°» Dan:<\> Dutch:]|[ Fren:<> Ger:<|> Ital:<> LatAm:<> Nor:<> Span:<> Swed:<|> Swiss:<\> UK:\| Brazil: \|. Typically near the Left-Shift key in AT-102 implementations.
    Application = 101,
    Power = 102,
    KeypadEquals = 103,
    F13 = 104,
    F14 = 105,
    F15 = 106,
    F16 = 107,
    F17 = 108,
    F18 = 109,
    F19 = 110,
    F20 = 111,
    F21 = 112,
    F22 = 113,
    F23 = 114,
    F24 = 115,
    Execute = 116,
    Help = 117,
    Menu = 118,
    Select = 119,
    Stop = 120,
    Again = 121,
    Undo = 122,
    Cut = 123,
    Copy = 124,
    Paste = 125,
    Find = 126,
    Mute = 127,
    VolumeUp = 128,
    VolumeDown = 129,
    KeypadComma = 133,
    OtherKeypadEquals = 134, // Equals sign typically used on AS-400 keyboards.
    International1 = 135,
    International2 = 136,
    International3 = 137,
    International4 = 138,
    International5 = 139,
    International6 = 140,
    International7 = 141,
    International8 = 142,
    International9 = 143,
    Lang1 = 144,
    Lang2 = 145,
    Lang3 = 146,
    Lang4 = 147,
    Lang5 = 148,
    Lang6 = 149,
    Lang7 = 150,
    Lang8 = 151,
    Lang9 = 152,
    AlternativeErase = 153, // Example, Erase-Eaze™ key.
    SystemRequest = 154,
    Cancel = 155,
    Clear = 156,
    Prior = 157,
    Return2 = 158,
    Separator = 159,
    Out = 160,
    Oper = 161,
    ClearAgain = 162,
    // For more information on these two consult IBM's "3174 Establishment Controller - Terminal User's Reference for
    // Expanded Functions" (GA23-03320-02, May 1989)
    CursorSelect = 163,
    ExtendSelect = 164,
    Keypad00 = 176,
    Keypad000 = 177,
    ThousandsSeparator = 178,
    DecimalSeparator = 179,
    CurrencyUnit = 180,
    CurrencySubunit = 181,
    KeypadLeftParenthesis = 182,
    KeypadRightParenthesis = 183,
    KeypadLeftBrace = 184,
    KeypadRightBrace = 185,
    KeypadTab = 186,
    KeypadBackspace = 187,
    KeypadA = 188,
    KeypadB = 189,
    KeypadC = 190,
    KeypadD = 191,
    KeypadE = 192,
    KeypadF = 193,
    KeypadXor = 194,
    KeypadPower = 195,
    KeypadPercent = 196,
    KeypadLess = 197,
    KeypadGreater = 198,
    KeypadAmpersand = 199,
    KeypadDoubleAmpersand = 200,
    KeypadVerticalBar = 201,
    KeypadDoubleVerticalBar = 202,
    KeypadColon = 203,
    KeypadHash = 204,
    KeypadSpace = 205,
    KeypadAt = 206,
    KeypadExclamation = 207,
    KeypadMemoryStore = 208,
    KeypadMemoryRecall = 209,
    KeypadMemoryClear = 210,
    KeypadMemoryAdd = 211,
    KeypadMemorySubtract = 212,
    KeypadMemoryMultiply = 213,
    KeypadMemoryDivide = 214,
    KeypadPlusMinus = 215,
    KeypadClear = 216,
    KeypadClearEntry = 217,
    KeypadBinary = 218,
    KeypadOctal = 219,
    KeypadDecimal = 220,
    KeypadHexadecimal = 221,
    ControlLeft = 224,
    ShiftLeft = 225,
    AltLeft = 226,
    SuperLeft = 227,
    ControlRight = 228,
    ShiftRight = 229,
    AltRight = 230,
    SuperRight = 231,
    Mode = 257,
    // These values are mapped from usage page 0x0C (USB consumer page).
    Sleep = 258,
    Wake = 259,
    ChannelIncrement = 260,
    ChannelDecrement = 261,
    MediaPlay = 262,
    MediaPause = 263,
    MediaRecord = 264,
    MediaFastForward = 265,
    MediaRewind = 266,
    MediaNextTrack = 267,
    MediaPreviousTrack = 268,
    MediaStop = 269,
    MediaEject = 270,
    MediaPlayPause = 271,
    MediaSelect = 272,
    ApplicationNew = 273,
    ApplicationOpen = 274,
    ApplicationClose = 275,
    ApplicationExit = 276,
    ApplicationSave = 277,
    ApplicationPrint = 278,
    ApplicationProperties = 279,
    ApplicationSearch = 280,
    ApplicationHome = 281,
    ApplicationBack = 282,
    ApplicationForward = 283,
    ApplicationStop = 284,
    ApplicationRefresh = 285,
    ApplicationBookmarks = 286,
    // 501-512 is reserved for non-standard (i.e. not from an industry-standard HID page) keys.
    SoftLeft = 501, // Left button on mobile phones
    SoftRight = 502, // Right button on mobile phones
    Call = 503,
    EndCall = 504,
}
```

```cs
[Flags]
public enum KeyModifiers
{
    None = 0,
    ShiftLeft = 1 << 0,
    ShiftRight = 1 << 1,
    ControlLeft = 1 << 2,
    ControlRight = 1 << 3,
    AltLeft = 1 << 4,
    AltRight = 1 << 5,
    SuperLeft = 1 << 6,
    SuperRight = 1 << 7,
    NumLock = 1 << 8,
    CapsLock = 1 << 9
}
```

The `KeyName` enumerates standard USB HID usage IDs where possible - mappings to PS/2 are not included and should be
done manually based on a translation table. A `KeyName` value **must** always map to a _physical_ scancode and not be
layout-specific. In theory, no key will be missing from this enum. However, the backend **may** cast an integer value
between 1-500 to this enum in the case that there is a standard USB HID page/usage ID that hasn't been accounted for by
`KeyName` yet. The Silk.NET team reserves the right to update `KeyName` to reflect latest specifications as it sees fit,
and to add non-standard keys as deemed applicable for the userbase.

**INFORMATIVE TEXT**: There has been lots of discussion about our localization approach. We remain of the opinion that
any such approaches should be scancode-oriented, as these are effectively immutable and standardised across every
keyboard. The intention with the `KeyName` enum is to reflect a set of scancodes that would be recognizable to an
English developer, such that they could map to what is WASD using this enum, and have that automatically translated to
the keys in the same physical location on the end user's keyboard regardless of keyboard layout in use. This is also why
`IKeyboard` exposes `GetKeyName`, as this will localize this QWERTY-biased enum to whatever the equivalent key is in the
same physical position for the end user (e.g. for configuration UIs). We believe this presents a natural approach for
both the developer and the end user.

**FUTURE IMPROVEMENT**: We obviously acknowledge that this does not account for non-English developers, for which we
could investigate adding more `KeyName` enums for different keyboard layouts in the future i.e. so those developers can
develop their application in terms of their native layout.

**INFORMATIVE TEXT**: There has been some questions on whether we should expose options to generalise keyboard input
even further to common key bindings or common use cases. Such ideas have included providing a way to consider a
`IKeyboard`/`IPointerDevice` combination as an `IGamepad` implicitly, or having a `KeyName`-like enum that has more generic
names that are more closely aligned with the user's use case e.g. instead of `W` we have `Forward`. Both ideas are
shelved for now, but we believe we will explore the former in future proposals (namely Axis-Based Input and/or Input Actions).

# Gamepad Input

```cs
public interface IGamepad : IButtonDevice<JoystickButton>
{
    GamepadState State { get; }
    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => State.Buttons;
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
public class GamepadState
{
    public ButtonReadOnlyList<JoystickButton> Buttons { get; }
    public DualReadOnlyList<Vector2> Thumbsticks { get; }
    public DualReadOnlyList<float> Triggers { get; }
}
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

Changes to `GamepadState` also have matching handler methods which are subject to the handler method rules i.e. the backend should call them in the order in which the backend received the events where possible etc (read the Input Handlers section). For the avoidance of doubt, this implies that `Timestamp` in ascending order.

```cs
public interface IGamepadInputHandler : IButtonInputHandler<JoystickButton>
{
    void HandleThumbstickMove(GamepadThumbstickMoveEvent @event);
    void HandleTriggerMove(GamepadTriggerMoveEvent @event);
}
```

`HandleThumbstickMove` must be called when any value of `GamepadState.Thumbsticks` changes.

`HandleTriggerMove` must be called when any value of `GamepadState.Triggers` changes.

# Joystick Input

This is the polyglot interface for any other human input device that roughly meets the description of being "joystick".

```cs
public interface IJoystick : IButtonDevice<JoystickButton>
{
    JoystickState State { get; }
    ButtonReadOnlyList<JoystickButton> IButtonDevice<JoystickButton>.State => State.Buttons;
}
```
```cs
public class JoystickState
{
    public InputReadOnlyList<float> Axes { get; }
    public ButtonReadOnlyList<JoystickButton> Buttons { get; }
    public InputReadOnlyList<Vector2> Hats { get; }
}
```

This is pretty closely modeled as in 2.X: `Axes` containing the individual axes that can be represented by this joystick, `Buttons` containing the buttons which can be pressed, and `Hats` containing the hats.

**INFORMATIVE TEXT:** The only difference is `Hats` is now a `Vector2` instead of a `Position2D`. It is still intended that the X and Y values are only ever `0` or `1`, but this is not a requirement for more exotic backends.

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

Changes to `JoystickState` also have matching handler methods which are subject to the handler method rules i.e. the backend should call them in the order in which the backend received the events where possible etc (read the Input Handlers section). For the avoidance of doubt, this implies that `Timestamp` in ascending order.

```cs
public interface IJoystickInputHandler : IButtonInputHandler<JoystickButton>
{
    void HandleAxisMove(JoystickAxisMoveEvent @event);
    void HandleHatMove(JoystickHatMoveEvent @event);
}
```

`HandleAxisMove` must be called when any value of `JoystickState.Axes` changes.

`HandleHatMove` must be called when any value of `JoystickState.Hats` changes.

# Meeting Notes

## 26/01/2025

[Video](https://www.youtube.com/live/jNIAH2raTMY?feature=shared&t=4635)

- Approved, with changes...
- `IPointer` should be renamed to `IPointerDevice` 
- `CursorFlags` remove - unused

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
