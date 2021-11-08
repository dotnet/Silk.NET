// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Numerics;
using Silk.NET.Maths;

namespace Silk.NET.Input;

// ---
// RENAMED: from ButtonName
// ---
public enum JoystickButton
{
    Unknown = -1,
    A,
    B,
    X,
    Y,
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

// ---
// ADDED: Button13 through Button31
// ---
public enum MouseButton
{
    Unknown = -1,
    LeftButton = 0,
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
    Button31,
}

// ---
// Unchanged
// ---
public enum DeadzoneMethod
{
    Traditional,
    AdaptiveGradient
}

// ---
// Unchanged
// ---
[Flags]
public enum Position2D
{
    Centered = 0,
    Up = 1,
    Down = 2,
    Left = 4,
    Right = 8,
    UpLeft = Up | Left,
    UpRight = Up | Right,
    DownLeft = Down | Left,
    DownRight = Down | Right
}

// ---
// Unchanged
// ---
public enum StandardCursor
{
    Default,
    Arrow,
    Crosshair,
    Hand,
    HResize,
    VResize
}

// ---
// Unchanged
// ---
public readonly record struct Axis(int Index, float Position);

// ---
// RENAMED: from Button
// ---
public readonly record struct ButtonState<T>(T Name, int Index, bool Pressed);

// ---
// Unchanged
// ---
public readonly record struct Deadzone(DeadzoneMethod Method, float Value);

// ---
// RENAMED: from Hat
// ---
public readonly record struct HatState(int Index, Position2D Position);

// ---
// REMOVED: ScrollWheel (replaced with Vector2)
// ---

// ---
// RENAMED: from Thumstick
// REMOVED: ThumbstickState.X/Y
// ADDED: ThumbstickState.Position (replaces X/Y)
// RENAMED: Thumbstick.Position to Thumbstick.Extent
// ---
public readonly record struct ThumbstickState(int Index, Vector2 Position)
{
    //public float Extent { get; }
    //public float Direction { get; }
}

public readonly record struct CursorState(Vector2 Position);

// ---
// REMOVED: Trigger (replaced with Axis)
// ---

// ---
// REFACTOR: IMouse to MouseState - getters moved out to be a immutable record
// REMOVED: Support for multiple scroll wheels (it wasn't properly plumbed in anyway)
// ---
public readonly partial record struct MouseState
(
    IInputDevice Device,
    ReadOnlyMemory<ButtonState<MouseButton>> Buttons,
    Vector2 ScrollWheel,
    CursorState Cursor
)
{
    public partial bool IsButtonPressed(MouseButton btn);
}

// ---
// REFACTOR: ICursor to CursorConfiguration - getters moved out to be a immutable record
// ---
public readonly record struct CursorConfiguration
(
    StandardCursor? StandardImage = null,
    ReadOnlyMemory<byte>? CustomImage = null,
    bool? IsConfined = null,
    Vector2D<int>? Hotspot = null
);

// ---
// REFACTOR: IMouse to MouseConfiguration - settings which aren't state moved out
// ---
public readonly record struct MouseConfiguration
(
    int? DoubleClickTime = null,
    int? DoubleClickRange = null,
    CursorConfiguration? Cursor = null
);

public readonly record struct DeviceInfo
(
    IInputBackend Backend,
    int BackendSpecificIndex,
    string Name,
    bool IsConnected
);

public readonly record struct MouseButtonEvent(IMouse Mouse, IReadOnlyList<ButtonState> Buttons);
public readonly record struct MouseClickEvent(IMouse Mouse, ButtonName Button, Vector2 Position, Vector2 Hotspot);
public readonly record struct MouseMoveEvent(IMouse Mouse, Vector2 Position, Vector2 Previous);

public interface IInputDevice
{
    ref readonly DeviceInfo Info { get; }
    bool TryGet<T>(out T config);
    bool TrySet<T>(in T config, out string error);
}

public interface IInputBackend
{
    IReadOnlyList<IInputDevice> Devices { get; }
    event Action<IReadOnlyList<IInputDevice>>? DevicesAdded;
    event Action<IReadOnlyList<IInputDevice>>? DevicesRemoved;
}

public interface IMouse : IInputDevice
{
    // For IInputDevice.TryGet accepts Ts: MouseState, CursorState, MouseConfiguration, CursorConfiguration
    // For IInputDevice.TrySet accepts Ts: MouseConfiguration, CursorConfiguration, CursorState
    MouseState State { get; }
    ref readonly MouseConfiguration Configuration { get; }
    event Action<MouseButtonEvent> MouseDown;
    event Action<MouseButtonEvent> MouseUp;
    event Action<MouseClickEvent> Click;
    event Action<MouseClickEvent> DoubleClick;
    event Action<MouseMoveEvent> MouseMove;
    event Action<MouseMoveEvent> Scroll;
}

public static partial class MouseExtensions
{
    public static partial bool TrySetConfiguration(this IMouse mouse, in MouseConfiguration config, out string error);
    public static partial bool TrySetConfiguration(this IMouse mouse, in CursorConfiguration config, out string error);
    public static partial bool TrySetState(this IMouse mouse, in CursorState state, out string error);
    public static partial bool TrySetPosition(this IMouse mouse, Vector2 pos);
    public static partial bool TrySetStandardImage(this IMouse mouse, StandardCursor value);
    public static partial bool TrySetCustomImage(this IMouse mouse, ReadOnlyMemory<byte> value);
    public static partial bool TrySetIsConfined(this IMouse mouse, bool value);
    public static partial bool TrySetHotspot(this IMouse mouse, Vector2D<int> value);
    public static partial bool TrySetDoubleClickTime(this IMouse mouse, int value);
    public static partial bool TrySetDoubleClickRange(this IMouse mouse, int value);
    public static partial bool TrySetCursor(this IMouse mouse, CursorConfiguration value);
    public static partial IMouse SetConfiguration(this IMouse mouse, in MouseConfiguration config);
    public static partial IMouse SetConfiguration(this IMouse mouse, in CursorConfiguration config);
    public static partial IMouse SetState(this IMouse mouse, in CursorState state);
    public static partial IMouse SetPosition(this IMouse mouse, Vector2 pos);
    public static partial IMouse SetStandardImage(this IMouse mouse, StandardCursor value);
    public static partial IMouse SetCustomImage(this IMouse mouse, ReadOnlyMemory<byte> value);
    public static partial IMouse SetIsConfined(this IMouse mouse, bool value);
    public static partial IMouse SetHotspot(this IMouse mouse, Vector2D<int> value);
    public static partial IMouse SetDoubleClickTime(this IMouse mouse, int value);
    public static partial IMouse SetDoubleClickRange(this IMouse mouse, int value);
    public static partial IMouse SetCursor(this IMouse mouse, CursorConfiguration value);
}

public readonly record struct KeyboardState
(
    
);

public interface IKeyboard : IInputDevice
{
    IReadOnlyList<Key> SupportedKeys { get; }
    bool IsKeyPressed(Key key);
    event Action<IKeyboard, Key, int>? KeyDown;
    event Action<IKeyboard, Key, int>? KeyUp;
    event Action<IKeyboard, char>? KeyChar;
    void BeginInput();
    void EndInput();
}