// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Silk.NET.Input;

/// <summary>
/// A union over input events.
/// </summary>
/// <remarks>
/// This type is not intended for public consumption and has no API/ABI stability guarantees.
/// </remarks>
[Experimental(
    "ST0005",
    UrlFormat = "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/diagnostics/{0}"
)]
[StructLayout(LayoutKind.Explicit)]
internal struct InputEventUnion
{
    /// <summary><see cref="ButtonChangedEvent{T}" /> where <c>T</c> is <see cref="PointerButton"/>.</summary>
    [FieldOffset(0)]
    public ButtonChangedEvent<PointerButton> PointerButtonChanged;

    /// <summary><see cref="ButtonChangedEvent{T}" /> where <c>T</c> is <see cref="KeyName"/>.</summary>
    [FieldOffset(0)]
    public ButtonChangedEvent<KeyName> KeyButtonChanged;

    /// <summary><see cref="ButtonChangedEvent{T}" /> where <c>T</c> is <see cref="JoystickButton"/>.</summary>
    [FieldOffset(0)]
    public ButtonChangedEvent<JoystickButton> JoystickButtonChanged;

    /// <summary><see cref="ConnectionEvent" />.</summary>
    [FieldOffset(0)]
    public ConnectionEvent Connection;

    /// <summary><see cref="GamepadThumbstickMoveEvent" />.</summary>
    [FieldOffset(0)]
    public GamepadThumbstickMoveEvent GamepadThumbstickMove;

    /// <summary><see cref="GamepadTriggerMoveEvent" />.</summary>
    [FieldOffset(0)]
    public GamepadTriggerMoveEvent GamepadTriggerMove;

    /// <summary><see cref="JoystickAxisMoveEvent" />.</summary>
    [FieldOffset(0)]
    public JoystickAxisMoveEvent JoystickAxisMove;

    /// <summary><see cref="JoystickHatMoveEvent" />.</summary>
    [FieldOffset(0)]
    public JoystickHatMoveEvent JoystickHatMove;

    /// <summary><see cref="KeyChangedEvent" />.</summary>
    [FieldOffset(0)]
    public KeyChangedEvent KeyChanged;

    /// <summary><see cref="KeyCharEvent" />.</summary>
    [FieldOffset(0)]
    public KeyCharEvent KeyChar;

    /// <summary><see cref="MouseScrollEvent" />.</summary>
    [FieldOffset(0)]
    public MouseScrollEvent MouseScroll;

    /// <summary><see cref="PointChangedEvent" />.</summary>
    [FieldOffset(0)]
    public PointChangedEvent PointChanged;

    /// <summary><see cref="PointerClickEvent" />.</summary>
    [FieldOffset(0)]
    public PointerClickEvent PointerClick;

    /// <summary><see cref="PointerGripChangedEvent" />.</summary>
    [FieldOffset(0)]
    public PointerGripChangedEvent PointerGripChanged;

    /// <summary><see cref="PointerTargetChangedEvent" />.</summary>
    [FieldOffset(0)]
    public PointerTargetChangedEvent PointerTargetChanged;
}
