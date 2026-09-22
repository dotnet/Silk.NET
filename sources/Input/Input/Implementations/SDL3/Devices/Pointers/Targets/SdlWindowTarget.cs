// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

internal sealed class SdlWindowTarget : SdlBoundedPointerTarget, ISdlBoundedPointerTarget<SdlWindowTarget, WindowHandle>
{
    private SdlWindowTarget(ISdl backend, uint id, WindowHandle handle) : base(backend)
    {
        Id = id;
        Handle = handle;
    }

    protected override Box3D<float> CalculateBounds()
    {
        var bounds2D = CalculateWindowBounds(NativeBackend, Handle);
        return new Box3D<float>(
            new Vector3D<float>(bounds2D.Min.X, bounds2D.Min.Y, 0),
            new Vector3D<float>(bounds2D.Max.X, bounds2D.Max.Y, 0));
    }

    public uint Id { get; }
    public WindowHandle Handle { get; }

    public static SdlWindowTarget Create(ISdl backend, uint id, WindowHandle handle) =>
        new(backend, id, handle);

}
