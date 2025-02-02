// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceScale
{
    private float _contentScale,
        _drawScale,
        _pixelDensity;
    public float Content =>
        IsSurfaceInitialized
            ? _contentScale = Sdl.GetDisplayContentScale(Sdl.GetDisplayForWindow(Handle))
            : default;

    public float Draw =>
        IsSurfaceInitialized ? _drawScale = Sdl.GetWindowDisplayScale(Handle) : default;

    public float PixelDensity =>
        IsSurfaceInitialized ? _pixelDensity = Sdl.GetWindowPixelDensity(Handle) : default;

    event Action<ScaleChangedEvent>? ISurfaceScale.Changed
    {
        add
        {
            if (ScaleChanged is null)
            {
                _contentScale = Content;
                _drawScale = Draw;
                _pixelDensity = PixelDensity;
            }

            ScaleChanged += value;
        }
        remove => ScaleChanged -= value;
    }

    private event Action<ScaleChangedEvent>? ScaleChanged;

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
            if (!Sdl.GetWindowSizeInPixels(Handle, w.AsRef(), h.AsRef()))
            {
                Sdl.ThrowError();
            }
            return new Vector2(w, h);
        }
    }

    public void OnPotentialScaleChanges()
    {
        if (ScaleChanged is null)
        {
            // User doesn't care.
            return;
        }

        var oldContent = _contentScale;
        var newContent = _contentScale;
        var oldDraw = _drawScale;
        var newDraw = Draw;
        var oldPixelDensity = _pixelDensity;
        var newPixelDensity = PixelDensity;
        if (
            MathF.Abs(oldContent - newContent) > float.Epsilon
            || MathF.Abs(oldDraw - newDraw) > float.Epsilon
            || MathF.Abs(oldPixelDensity - newPixelDensity) > float.Epsilon
        )
        {
            DebugPrint("Raising ScaleChanged...");
            ScaleChanged?.Invoke(
                new ScaleChangedEvent(
                    surface,
                    oldContent,
                    newContent,
                    oldDraw,
                    newDraw,
                    oldPixelDensity,
                    newPixelDensity
                )
            );
        }
    }

    private void InitializeScale(uint createProps)
    {
        if (!Sdl.SetBooleanProperty(createProps, Sdl.PropWindowCreateHighPixelDensityBoolean, true))
        {
            Sdl.ThrowError();
        }
    }

    private void PostInitializeScale() => OnPotentialScaleChanges();
}
