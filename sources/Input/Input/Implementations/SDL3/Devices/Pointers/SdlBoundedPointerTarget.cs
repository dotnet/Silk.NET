// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlBoundedPointerTarget(SdlInputBackend backend) : IPointerTarget
{
    internal SdlInputBackend Backend { get; } = backend;
    private Box2D<float> Bounds2D { get; set; }

    public Box3D<float> Bounds =>
        new(new Vector3D<float>(Bounds2D.Min, 0), new Vector3D<float>(Bounds2D.Max, 1));

    public static Box2D<float> CalculateBounds(ISdl sdl)
    {
        var minX = float.PositiveInfinity;
        var minY = float.PositiveInfinity;
        var maxX = float.NegativeInfinity;
        var maxY = float.NegativeInfinity;
        var displayCount = 0;
        var displays = sdl.GetDisplays(displayCount.AsRef());
        if (displays == nullptr)
        {
            // Looks like we can't support windowed mouse input.
            sdl.ClearError();
            return default;
        }

        if (displayCount == 0) // ???
        {
            sdl.Free((Ref)displays);
            return default;
        }

        for (var i = 0; i < displayCount; i++)
        {
            Rect rect = default;
            if (!sdl.GetDisplayBounds(displays[(nuint)i], rect.AsRef()))
            {
                return default;
            }

            minX = float.Min(minX, rect.X);
            minY = float.Min(minY, rect.Y);
            maxX = float.Max(maxX, rect.X + rect.W);
            maxY = float.Max(maxY, rect.Y + rect.H);
        }

        sdl.Free((Ref)displays);
        if (minX <= maxX && minY <= maxY)
        {
            return new Box2D<float>(minX, minY, maxX, maxY);
        }

        return default;
    }

    public int GetPointCount(IPointerDevice pointer)
    {
        if (pointer is not SdlBoundedPointerDevice { IsBounded: true } device)
        {
            return 0;
        }

        if (device.Backend == Backend)
        {
            //return Bounds != default ? device.BoundedPoints.List.Count : 0;
        }

        throw new NotImplementedException();
        //return device.Backend.BoundedPointerTarget.GetPointCount(pointer);
    }

    public TargetPoint GetPoint(IPointerDevice pointer, int point)
    {
        if (
            pointer is not SdlBoundedPointerDevice { IsBounded: true } device
            || point < 0
                //|| point >= device.BoundedPoints.List.Count
        )
        {
            return default;
        }

        if (device.Backend != Backend)
        {
       //     return device.Backend.BoundedPointerTarget.GetPoint(pointer, point);
        }

        throw new NotImplementedException();
     //   return Bounds != default ? device.BoundedPoints.List[point] : default;
    }
}
