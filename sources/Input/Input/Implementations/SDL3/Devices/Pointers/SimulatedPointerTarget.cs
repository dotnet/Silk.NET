// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input.SDL3.Devices.Pointers.Targets;
using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal sealed class SimulatedPointerTarget : SdlBoundedPointerTarget, ISimulatedPointerTarget
{
    public SimulatedPointerTarget(SdlInputBackend backend) : base(backend)
    {
    }

    public void SetBounds(in Box3D<float> bounds) => _bounds = bounds;

    private Box3D<float> _bounds;


    protected override Box3D<float> CalculateBounds() => _bounds;
}

internal interface ISimulatedPointerTarget : IPointerTarget
{
    void SetBounds(in Box3D<float> bounds);
}
