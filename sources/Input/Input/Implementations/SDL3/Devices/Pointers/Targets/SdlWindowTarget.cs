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

    protected override bool TryCalculateBounds(out Box3D<float> bounds)
    {
        var bounds2D = CalculateWindowBoundsFromSdl(NativeBackend, Handle);
        if (bounds2D == null)
        {
            bounds = default;
            return false;
        }

        bounds = new Box3D<float>(
            new Vector3D<float>(bounds2D.Value.Min.X, bounds2D.Value.Min.Y, 0),
            new Vector3D<float>(bounds2D.Value.Max.X, bounds2D.Value.Max.Y, 0));

        return true;
    }

    public uint Id { get; }
    public WindowHandle Handle { get; }

    public static SdlWindowTarget Create(ISdl backend, uint id, WindowHandle handle) =>
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
