// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

internal sealed class SdlWindowTarget : SdlBoundedPointerTarget, ISdlBoundedPointerTarget<SdlWindowTarget, WindowHandle>
{
    private SdlWindowTarget(SdlInputBackend backend, uint id, WindowHandle handle) : base(backend)
    {
        Id = id;
        Handle = handle;
    }

    protected override Box3D<float> CalculateBounds()
    {
        var bounds2d = SdlBoundedPointerTarget.CalculateWindowBounds(Backend.Sdl, Handle);
        return new Box3D<float>(bounds2d.Min.X, bounds2d.Min.Y, 0, bounds2d.Max.X, bounds2d.Max.Y, 1);
    }

    public uint Id { get; }
    public WindowHandle Handle { get; }
    public static SdlWindowTarget? Create(SdlInputBackend backend, uint id, WindowHandle handle) => new(backend, id, handle);
}
