// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

internal sealed class SdlDisplayTarget : SdlBoundedPointerTarget, ISdlBoundedPointerTarget<SdlDisplayTarget, SilkSdlDisplayHandle>
{
    private SdlDisplayTarget(SdlInputBackend backend, SilkSdlDisplayHandle id) : base(backend)
    {
        Id = id.Id;
        Handle = id;
    }

    protected override Box3D<float> CalculateBounds()
    {
        var bounds2d = CalculateDisplayBounds(Backend.Sdl, Id);
        return new Box3D<float>(bounds2d.Min.X, bounds2d.Min.Y, 0, bounds2d.Max.X, bounds2d.Max.Y, 1);
    }

    public uint Id { get; }
    public SilkSdlDisplayHandle Handle { get; }
    public static SdlDisplayTarget? Create(SdlInputBackend backend, uint id, SilkSdlDisplayHandle handle) => new(backend, handle);
}
