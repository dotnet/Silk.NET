// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlPointerTarget(SdlInputBackend backend, bool rawMouseMotion) : IPointerTarget
{
    private static readonly Box3D<float> _infinity = new(
        new Vector3D<float>(float.NegativeInfinity),
        new Vector3D<float>(float.PositiveInfinity)
    );

    public Box3D<float> Bounds
    {
        get
        {
            if (rawMouseMotion)
            {
                return _infinity;
            }

            int w = 0,
                h = 0,
                x = 0,
                y = 0;
            if (
                !backend.Sdl.GetWindowSize(backend.Info.Window, w.AsRef(), h.AsRef())
                || !backend.Sdl.GetWindowPosition(backend.Info.Window, x.AsRef(), y.AsRef())
            )
            {
                backend.Sdl.ThrowError();
            }

            return new Box3D<float>(
                new Vector3D<float>(x, y, 0),
                new Vector3D<float>(x + w, y + h, 0)
            );
        }
    }

    public int GetPointCount(IPointerDevice pointer) => throw new NotImplementedException();

    public TargetPoint GetPoint(IPointerDevice pointer, int point) =>
        throw new NotImplementedException();
}
