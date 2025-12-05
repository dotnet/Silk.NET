// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

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
    /*
    {
        var point = pointer.State.Points[pointIdx];
        var valid = IsValidDevice(pointer);
        return new TargetPoint(
            Id: point.Id, // todo : follow spec with unique ids
            Flags: valid ? TargetPointFlags.PointingAtTarget : TargetPointFlags.NotPointingAtTarget,
            Position: point.Position, // in this case, should the position be provided at all?
            NormalizedPosition: default,
            Pointer: new Ray3D<float>(),
            Pressure: point.Pressure < 0 ? 0 : point.Pressure > 1 ? 1 : point.Pressure,
            Target: this
        );
    }
    */

    // todo - do we really want to limit this to SDL devices? or to our specific sdl backend?
    // i dont think so, but.... technically...
    private bool IsValidDevice(IPointerDevice pointer) =>
        pointer is SdlDevice device && device.Backend == backend &&
        (device.Backend.CursorConfiguration.Mode & CursorModes.Unbounded) != 0;
}
