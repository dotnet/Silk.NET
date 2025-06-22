// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3;

internal abstract unsafe class SdlDevice : IInputDevice
{
    public bool Equals(IInputDevice? other) =>
        other?.GetType() == GetType()
        && other.Id == Id
        && other is SdlBoundedPointerDevice dev
        && dev.Backend.Sdl == Backend.Sdl;

    public nint Id => Backend.AsSilkId(DeviceId);
    public required uint DeviceId { get; init; }
    public required SdlInputBackend Backend { get; init; }
    public required void* DeviceHandle { get; init; }
    public abstract string Name { get; }

    public abstract void Initialize();
}
