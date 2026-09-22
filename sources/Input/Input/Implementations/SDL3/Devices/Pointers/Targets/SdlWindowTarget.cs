// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

internal sealed class SdlWindowTarget : SdlBoundedPointerTarget, ISdlBoundedPointerTarget<SdlWindowTarget, WindowHandle>
{
    private SdlWindowTarget(ISdl backend, uint id, WindowHandle handle) : base(backend)
    {
        Id = id;
        Handle = handle;
    }

    protected override Box3D<float> CalculateBounds()
    {
        var bounds2D = CalculateWindowBoundsFromSdl(NativeBackend, Handle);
        return new Box3D<float>(
            new Vector3D<float>(bounds2D.Min.X, bounds2D.Min.Y, 0),
            new Vector3D<float>(bounds2D.Max.X, bounds2D.Max.Y, 0));
    }

    public uint Id { get; }
    public WindowHandle Handle { get; }

    public static SdlWindowTarget Create(ISdl backend, uint id, WindowHandle handle) =>
        new(backend, id, handle);

    private static unsafe Box2D<float> CalculateWindowBoundsFromSdl(ISdl sdl, WindowHandle window)
    {
        Vector2D<int> windowSize = default;
        var gotSize = sdl.GetWindowSize(window, &windowSize.X, &windowSize.Y);
        if (gotSize == 0)
        {
            SdlLog.Error("Failed to get window size for window.");
            return default;
        }

        Vector2D<int> windowPosition = default;
        var gotPos = sdl.GetWindowPosition(window, &windowPosition.X, &windowPosition.Y);
        if (gotPos == 0)
        {
            SdlLog.Error("Failed to get window position for window.");
            return default;
        }

        var windowEndPos = windowPosition + windowSize;
        return new Box2D<float>(windowPosition.X, windowPosition.Y, windowEndPos.X, windowEndPos.Y);
    }
}
