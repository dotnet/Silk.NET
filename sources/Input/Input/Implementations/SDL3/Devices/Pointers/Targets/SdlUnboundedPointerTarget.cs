// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Extensions;
using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

// todo - test that "unbounded" behavior is correct
internal class SdlUnboundedPointerTarget(SdlInputBackend backend) : IPointerTarget
{
    public Box3D<float> Bounds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new(
            new Vector3D<float>(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity),
            new Vector3D<float>(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int GetPointCount(IPointerDevice pointer) => PointerTargetExtensions.GetPointCount(this, pointer);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public TargetPoint GetPoint(IPointerDevice pointer, int pointIdx) =>
        PointerTargetExtensions.GetPoint(this, pointer, pointIdx);
}
