// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceScale
{
    public float ContentScale =>
        IsSurfaceInitialized
            ? Sdl.GetDisplayContentScale(Sdl.GetDisplayForWindow(Handle))
            : default;

    public float DrawScale => IsSurfaceInitialized ? Sdl.GetWindowDisplayScale(Handle) : default;

    public float PixelDensity => IsSurfaceInitialized ? Sdl.GetWindowPixelDensity(Handle) : default;

    public Vector2 DrawableSize
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return default;
            }

            var w = 0;
            var h = 0;
            Sdl.GetWindowSizeInPixels(Handle, w.AsRef(), h.AsRef());
            return new Vector2(w, h);
        }
    }
}
