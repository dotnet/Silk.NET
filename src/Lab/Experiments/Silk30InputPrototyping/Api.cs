// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Numerics;
using Silk.NET.Maths;

namespace Silk.NET.Input;

// ---
// ADDED: Enums from MouseButton
// RENAMED: MouseButton.Left to ButtonName.LeftMouseButton
// RENAMED: MouseButton.Right to ButtonName.RightMouseButton
// RENAMED: MouseButton.Middle to ButtonName.MiddleMouseButton
// RENAMED: MouseButton.Button4 to ButtonName.MouseButton4
// RENAMED: MouseButton.Button5 to ButtonName.MouseButton5
// RENAMED: MouseButton.Button6 to ButtonName.MouseButton6
// RENAMED: MouseButton.Button7 to ButtonName.MouseButton7
// RENAMED: MouseButton.Button8 to ButtonName.MouseButton8
// RENAMED: MouseButton.Button9 to ButtonName.MouseButton9
// RENAMED: MouseButton.Button10 to ButtonName.MouseButton10
// RENAMED: MouseButton.Button11 to ButtonName.MouseButton11
// RENAMED: MouseButton.Button12 to ButtonName.MouseButton12
// ADDED: ButtonName.MouseButton13 through ButtonName.MouseButton31
// ---
public enum ButtonName
{
    Unknown = -1,
    LeftMouseButton = 0,
    RightMouseButton,
    MiddleMouseButton,
    MouseButton4,
    MouseButton5,
    MouseButton6,
    MouseButton7,
    MouseButton8,
    MouseButton9,
    MouseButton10,
    MouseButton11,
    MouseButton12,
    MouseButton13,
    MouseButton14,
    MouseButton15,
    MouseButton16,
    MouseButton17,
    MouseButton18,
    MouseButton19,
    MouseButton20,
    MouseButton21,
    MouseButton22,
    MouseButton23,
    MouseButton24,
    MouseButton25,
    MouseButton26,
    MouseButton27,
    MouseButton28,
    MouseButton29,
    MouseButton30,
    MouseButton31,
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
public readonly record struct ButtonState(ButtonName Name, int Index, bool Pressed);

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
// ---
public readonly partial record struct MouseState
(
    IInputDevice Device,
    ReadOnlyMemory<ButtonState> Buttons,
    ReadOnlyMemory<Vector2> ScrollWheels,
    CursorState Cursor
)
{
    public partial bool IsButtonPressed(ButtonName btn);
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

public interface IInputDevice
{
    bool TryGet<T>(out T config);
    bool TrySet<T>(in T config, out string error);
}

public interface IMouse : IInputDevice
{
    // For IInputDevice.TryGet accepts Ts: MouseState, CursorState, MouseConfiguration, CursorConfiguration
    // For IInputDevice.TrySet accepts Ts: MouseConfiguration, CursorConfiguration, CursorState
    MouseState State { get; }
    MouseConfiguration Configuration { get; } 
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