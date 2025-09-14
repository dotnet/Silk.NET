// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3;

/// <summary>
/// An interface defining a generic constructor for managed SDL devices.
/// </summary>
/// <typeparam name="T"></typeparam>
internal interface ISdlDevice<out T> : IInputDevice where T : SdlDevice
{
    public static abstract T? CreateDevice(uint sdlDeviceId, SdlInputBackend backend);

}
