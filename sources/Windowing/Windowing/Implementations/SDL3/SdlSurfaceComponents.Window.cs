// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceWindow
{
    Rectangle<float> ISurfaceWindow.Bounds
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    Rectangle<float> ISurfaceWindow.ClientArea
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    event Action<WindowCoordinatesEvent>? ISurfaceWindow.CoordinatesChanged
    {
        add => throw new NotImplementedException();
        remove => throw new NotImplementedException();
    }

    bool ISurfaceWindow.IsCloseRequested
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    bool ISurfaceWindow.IsVisible
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    event Action<WindowToggleEvent>? ISurfaceWindow.CloseRequested
    {
        add => throw new NotImplementedException();
        remove => throw new NotImplementedException();
    }

    bool ISurfaceWindow.IsFocused
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    event Action<WindowToggleEvent>? ISurfaceWindow.FocusChanged
    {
        add => throw new NotImplementedException();
        remove => throw new NotImplementedException();
    }

    string ISurfaceWindow.Title
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    WindowState ISurfaceWindow.State
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    event Action<WindowStateEvent>? ISurfaceWindow.StateChanged
    {
        add => throw new NotImplementedException();
        remove => throw new NotImplementedException();
    }

    WindowBorder ISurfaceWindow.Border
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    bool ISurfaceWindow.IsTopMost
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    event Action<WindowFileEvent>? ISurfaceWindow.FileDrop
    {
        add => throw new NotImplementedException();
        remove => throw new NotImplementedException();
    }

    bool ISurfaceWindow.TrySetIcon(WindowIconVariants icon) => throw new NotImplementedException();
}
