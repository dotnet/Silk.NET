// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3;

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
        if (pointer is not SdlUnboundedMouse mouse)
        {
            return 0;
        }

        if (mouse.Backend != backend)
        {
            return mouse.Backend.UnboundedPointerTarget.GetPointCount(pointer);
        }

        return (mouse.Backend.Mode & CursorModes.Unbounded) != 0 ? 1 : 0;
    }

    public TargetPoint GetPoint(IPointerDevice pointer, int point) =>
        throw new NotImplementedException();
}
