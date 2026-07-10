// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

internal class SdlUnboundedPointerTarget(SdlInputBackend backend) : IPointerTarget
{
    private static readonly Box3D<float> _bounds = new(
        float.MinValue,
        float.MinValue,
        float.MinValue,
        float.MaxValue,
        float.MaxValue,
        float.MaxValue
    );

    public Box3D<float> Bounds => _bounds;

    public int GetPointCount(IPointerDevice pointer) => PointerTargetExtensions.GetPointCount(this, pointer);

    public TargetPoint GetPoint(IPointerDevice pointer, int pointIdx) => PointerTargetExtensions.GetPoint(this, pointer, pointIdx);
}
