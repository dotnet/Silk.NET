// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceWindow
{
    public Rectangle<float> Bounds
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public Rectangle<float> ClientArea
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public event Action<WindowCoordinatesEvent>? CoordinatesChanged;

    public bool IsCloseRequested
    {
        get;
        set
        {
            var prev = field;
            field = value;
            if (!prev && value)
            {
                CloseRequested?.Invoke(new WindowToggleEvent(surface, true));
            }
        }
    }

    public bool IsVisible
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public event Action<WindowToggleEvent>? CloseRequested;

    public bool IsFocused
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public event Action<WindowToggleEvent>? FocusChanged;

    public string Title
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public WindowState State
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public event Action<WindowStateEvent>? StateChanged;

    public WindowBorder Border
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public bool IsTopMost
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public event Action<WindowFileEvent>? FileDrop;

    public bool TrySetIcon(WindowIconVariants icon) => throw new NotImplementedException();

    private void InitializeWindow(uint props) { }
}
