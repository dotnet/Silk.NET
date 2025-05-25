// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Input;

/// <summary>
/// Enumerates types of events raised by Silk.NET.Input.
/// </summary>
/// <remarks>
/// This type is not intended for public consumption and has no API/ABI stability guarantees.
/// </remarks>
[Experimental(
    "ST0005",
    UrlFormat = "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/diagnostics/{0}"
)]
internal enum InputEventType : byte
{
    /// <summary><see cref="Input.ButtonChangedEvent{T}" /> where <c>T</c> is <see cref="PointerButton"/>.</summary>
    PointerButtonChangedEvent,

    /// <summary><see cref="Input.ButtonChangedEvent{T}" /> where <c>T</c> is <see cref="KeyName"/>.</summary>
    KeyButtonChangedEvent,

    /// <summary><see cref="Input.ButtonChangedEvent{T}" /> where <c>T</c> is <see cref="JoystickButton"/>.</summary>
    JoystickButtonChangedEvent,

    /// <summary><see cref="Input.ConnectionEvent" />.</summary>
    ConnectionEvent,

    /// <summary><see cref="Input.GamepadThumbstickMoveEvent" />.</summary>
    GamepadThumbstickMoveEvent,

    /// <summary><see cref="Input.GamepadTriggerMoveEvent" />.</summary>
    GamepadTriggerMoveEvent,

    /// <summary><see cref="Input.JoystickAxisMoveEvent" />.</summary>
    JoystickAxisMoveEvent,

    /// <summary><see cref="Input.JoystickHatMoveEvent" />.</summary>
    JoystickHatMoveEvent,

    /// <summary><see cref="Input.KeyChangedEvent" />.</summary>
    KeyChangedEvent,

    /// <summary><see cref="Input.KeyCharEvent" />.</summary>
    KeyCharEvent,

    /// <summary><see cref="Input.MouseScrollEvent" />.</summary>
    MouseScrollEvent,

    /// <summary><see cref="Input.PointChangedEvent" />.</summary>
    PointChangedEvent,

    // Does not have a matching actor method.
    // /// <summary><see cref="Input.PointerClickEvent" />.</summary>
    // PointerClickEvent,

    /// <summary><see cref="Input.PointerGripChangedEvent" />.</summary>
    PointerGripChangedEvent,

    /// <summary><see cref="Input.PointerTargetChangedEvent" />.</summary>
    PointerTargetChangedEvent,
}
