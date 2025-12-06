// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

internal interface ISdlBoundedPointerTarget<out T, THandle>
    where T : SdlBoundedPointerTarget
    where THandle : unmanaged
{
    uint Id { get; }
    THandle Handle { get; }

    public static abstract T? Create(SdlInputBackend backend, uint id, THandle handle);
    public void UpdateBounds();
}

internal abstract class SdlBoundedPointerTarget : IPointerTarget
{
    protected SdlBoundedPointerTarget(SdlInputBackend backend)
    {
        Backend = backend;
    }

    internal SdlInputBackend Backend { get; }
    private Box2D<float> Bounds2D
    {
        get
        {
            var bounds = Bounds;
            return new Box2D<float>(bounds.Min.X, bounds.Min.Y, bounds.Max.X, bounds.Max.Y);
        }
    }

    public Box3D<float> Bounds { get; private set; }

    public void UpdateBounds() => Bounds = CalculateBounds();
    protected abstract Box3D<float> CalculateBounds();

    /// <inheritdoc />
    public int GetPointCount(IPointerDevice pointer) => PointerTargetExtensions.GetPointCount(this, pointer);

    /// <inheritdoc />
    public TargetPoint GetPoint(IPointerDevice pointer, int point) => PointerTargetExtensions.GetPoint(this, pointer, point);

    public static unsafe Box2D<float> CalculateAllDisplayBounds(ISdl sdl)
    {
        var displayCount = 0;
        var displays = sdl.GetDisplays(&displayCount);
        if (displays == nullptr)
        {
            // Looks like we can't support windowed mouse input.
            sdl.ClearError();
            return default;
        }

        if (displayCount == 0) // ???
        {
            sdl.Free(displays);
            return default;
        }

        var bounds = new Box2D<float>(float.MaxValue, float.MaxValue, float.MinValue, float.MinValue);

        for (var i = 0; i < displayCount; i++)
        {
            var b = CalculateDisplayBounds(sdl, displays[i]);
            bounds = bounds.ExtendBy(b);
        }

        sdl.Free(displays);
        return default;
    }

    public static unsafe Box2D<float> CalculateDisplayBounds(ISdl sdl, uint sdlDisplayId)
    {
        if (sdlDisplayId == 0)
        {
            // https://wiki.libsdl.org/SDL3/SDL_DisplayID
            return default;
        }

        Rect rect = default;
        var gotDisplayBounds = sdl.GetDisplayBounds(sdlDisplayId, &rect);
        if (gotDisplayBounds == 0)
        {
            SdlLog.Error($"Failed to get display from ID {sdlDisplayId}.");
            return default;
        }

        return new Box2D<float>(rect.X, rect.Y, rect.X + rect.W, rect.Y + rect.H);
    }

    public static unsafe Box2D<float> CalculateWindowBounds(ISdl sdl, WindowHandle window)
    {
        Vector2D<int> windowSize = default;
        var gotSize = sdl.GetWindowSize(window, &windowSize.X, &windowSize.Y);;
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

    public static Box2D<float> CalculateWindowBounds(ISdl sdl, uint windowId)
    {
        var window = sdl.GetWindowFromID(windowId);
        if (window == nullptr)
        {
            SdlLog.Error($"Failed to get window from ID {windowId}.");
            return default;
        }

        return CalculateWindowBounds(sdl, window);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
