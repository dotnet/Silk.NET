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

    public int GetPointCount(IPointerDevice pointer) => IsValidDevice(pointer) ? pointer.State.Points.Count : 0;

    public TargetPoint GetPoint(IPointerDevice pointer, int pointIdx)
    {
        var point = pointer.State.Points[pointIdx];
        var valid = IsValidDevice(pointer);
        return new TargetPoint(
            Id: point.Id, // todo : follow spec with unique ids
            Flags: valid ? TargetPointFlags.PointingAtTarget : TargetPointFlags.NotPointingAtTarget,
            Position: point.Position,
            NormalizedPosition: default,
            Pointer: new Ray3D<float>(),
            Pressure: point.Pressure is > 1 or < 0
                ? point.Pressure is 0
                    ? 0
                    : 1
                : point.Pressure,
            Target: this
        );
    }

    private bool IsValidDevice(IPointerDevice pointer)
    {
        // todo - do we really want to limit this to SDL devices? or to our specific sdl backend?
        // i dont think so, but.... technically...

        var device = pointer as SdlDevice;
        return device is not null && device.Backend == backend && (device.Backend.Mode & CursorModes.Unbounded) != 0;
    }
}
