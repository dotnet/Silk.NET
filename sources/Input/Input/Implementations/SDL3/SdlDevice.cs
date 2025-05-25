// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3;

internal abstract class SdlDevice(SdlInputBackend backend) : IInputDevice
{
    public bool Equals(IInputDevice? other) =>
        other?.GetType() == GetType()
        && other.Id == Id
        && other is SdlBoundedPointerDevice dev
        && dev.Backend.Sdl == Backend.Sdl;

    public abstract IntPtr Id { get; }
    public abstract string Name { get; }
    public SdlInputBackend Backend { get; } = backend;
}
