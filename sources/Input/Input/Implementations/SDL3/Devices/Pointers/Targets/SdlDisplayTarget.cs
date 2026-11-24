// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

internal sealed class SdlDisplayTarget : SdlBoundedPointerTarget, ISdlBoundedPointerTarget<SdlDisplayTarget, SilkSdlDisplayHandle>
{
    private SdlDisplayTarget(ISdl backend, SilkSdlDisplayHandle id) : base(backend)
    {
        Id = id.Id;
        Handle = id;
    }

    protected override bool TryCalculateBounds(out Box3D<float> bounds)
    {
        if(!TryCalculateDisplayBounds(NativeBackend, Id, out var bounds2D))
        {
            bounds = default;
            return false;
        }

        bounds = new Box3D<float>(bounds2D.Min.X, bounds2D.Min.Y, 0, bounds2D.Max.X, bounds2D.Max.Y, 0);
        return true;
    }

    public uint Id { get; }
    public SilkSdlDisplayHandle Handle { get; }
    public static SdlDisplayTarget Create(ISdl backend, uint id, SilkSdlDisplayHandle handle) =>
        new(backend, handle);
}
