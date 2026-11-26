// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

internal sealed class SdlWindowTarget : SdlBoundedPointerTarget
{
    public uint Id { get; }
    private readonly WindowHandle _handle;

    private SdlWindowTarget(ISdl backend, uint id, WindowHandle handle) : base(backend)
    {
        Id = id;
        _handle = handle;
    }

    protected override bool TryCalculateBounds(out Box3D<float> bounds)
    {
        var maybeBounds2D = CalculateWindowBoundsFromSdl(NativeBackend, _handle);
        if (maybeBounds2D is not { } bounds2D)
        {
            bounds = default;
            return false;
        }

        bounds = new Box3D<float>(
            new Vector3D<float>(bounds2D.Min.X, bounds2D.Min.Y, 0),
            new Vector3D<float>(bounds2D.Max.X, bounds2D.Max.Y, 0));

        return true;
    }

    internal static SdlWindowTarget Create(ISdl backend, uint id, WindowHandle handle) =>
        new(backend, id, handle);

    /// <summary>Returns the window bounds, or <c>null</c> when SDL cannot report them.</summary>
    private static unsafe Box2D<float>? CalculateWindowBoundsFromSdl(ISdl sdl, WindowHandle window)
    {
        Vector2D<int> windowSize = default;
        var gotSize = sdl.GetWindowSize(window, &windowSize.X, &windowSize.Y);
        if (gotSize == 0)
        {
            SdlLog.Error("Failed to get window size for window.");
            return null;
        }

        Vector2D<int> windowPosition = default;
        var gotPos = sdl.GetWindowPosition(window, &windowPosition.X, &windowPosition.Y);
        if (gotPos == 0)
        {
            windowPosition = Vector2D<int>.Zero;
            SdlLog.Debug("Failed to get window position for window.");
        }

        var windowEndPos = windowPosition + windowSize;
        return new Box2D<float>(windowPosition.X, windowPosition.Y, windowEndPos.X, windowEndPos.Y);
    }
}
