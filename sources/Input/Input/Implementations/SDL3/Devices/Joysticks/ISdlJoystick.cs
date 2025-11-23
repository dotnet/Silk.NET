// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

/// <summary>
/// An interface for implementing different joystick types
///
/// Currently, only Gamepad is explicitly supported, however this interface leaves room
/// for extensions such as those seen in <see cref="JoystickType"/>.
/// </summary>
internal interface ISdlJoystick : IOrderedDevice
{
    public SdlJoystick Joystick { get; }
    /// <summary>
    /// Raw joystick axis input events are forwarded here
    /// </summary>
    /// <param name="axis">Input axis (which axis)</param>
    /// <param name="joystickInput">Input axis value</param>
    public void UpdateFromJoyAxis(int axis, short joystickInput);

    /// <summary>
    /// Raw joystick hat input events are forwarded here
    /// </summary>
    /// <param name="hatIdx">Input hat (which hat)</param>
    /// <param name="hatState">Input hat value</param>
    public void UpdateFromJoyHat(int hatIdx, SdlJoystick.HatState hatState);

    /// <summary>
    /// Raw joystick button input events are forwarded here
    /// </summary>
    /// <param name="buttonIdx">Input button (which button)</param>
    /// <param name="down">Button state</param>
    public void UpdateFromJoyButton(int buttonIdx, bool down);
}
