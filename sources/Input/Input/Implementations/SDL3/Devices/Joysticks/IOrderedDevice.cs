// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

/// <summary>
/// For devices such as gamepads and joysticks, their SDL IDs are likely to change when other devices
/// are removed.
/// </summary>
internal interface IOrderedDevice
{
    public void RefreshSdlId();
}
