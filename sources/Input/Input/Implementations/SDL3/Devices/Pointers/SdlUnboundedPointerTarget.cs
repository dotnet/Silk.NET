// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Pointers;

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

    public int GetPointCount(IPointerDevice pointer)
    {
        if (pointer is not SdlDevice device)
        {
            return 0;
        }

        if (pointer.State.Points.Count == 0)
        {
            return 0;
        }

        if (device.Backend != backend)
        {
            return device.Backend.UnboundedPointerTarget.GetPointCount(pointer);
        }

        return (device.Backend.Mode & CursorModes.Unbounded) != 0 ? 1 : 0;
    }

    public TargetPoint GetPoint(IPointerDevice pointer, int point) =>
        throw new NotImplementedException();
}
