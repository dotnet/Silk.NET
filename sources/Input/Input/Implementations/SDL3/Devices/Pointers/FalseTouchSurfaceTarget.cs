// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input.SDL3.Devices.Pointers.Targets;
using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class FalseTouchSurfaceTarget : SdlBoundedPointerTarget
{
    public FalseTouchSurfaceTarget(SdlInputBackend backend) : base(backend)
    {
    }

    public void SetBounds(in Box3D<float> bounds) => _bounds = bounds;

    private Box3D<float> _bounds;


    protected override Box3D<float> CalculateBounds() => _bounds;
}
