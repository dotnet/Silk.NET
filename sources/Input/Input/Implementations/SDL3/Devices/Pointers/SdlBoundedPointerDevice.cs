// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3.Devices.Pointers;

/// <summary>
/// A base class for SDL input devices that operate in terms of a window's or DWMs bounds.
/// </summary>
internal abstract class SdlBoundedPointerDevice : SdlDevice, IPointerDevice
{
    protected SdlBoundedPointerDevice(SdlInputBackend backend, nint silkId,
        uint sdlDeviceId) : base(backend, silkId, sdlDeviceId)
    {
    }

    public abstract PointerState State { get; }

    public abstract IReadOnlyList<IPointerTarget> Targets { get; }

    /// <summary>
    /// Determines whether the <see cref="SdlBoundedPointerTarget"/> should interpret <see cref="PointerState.Points"/>
    /// as being bounded points. For all devices supported by this backend, only one target is supported at a time
    /// today.
    /// </summary>
    public bool IsBounded => true;
}
