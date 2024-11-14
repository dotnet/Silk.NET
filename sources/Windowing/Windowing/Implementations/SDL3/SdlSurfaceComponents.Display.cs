// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceDisplay
{
    IDisplay ISurfaceDisplay.Current
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    IReadOnlyList<IDisplay> ISurfaceDisplay.Available => throw new NotImplementedException();

    VideoMode ISurfaceDisplay.VideoMode
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    IReadOnlyList<VideoMode> ISurfaceDisplay.AvailableVideoModes =>
        throw new NotImplementedException();

    event Action<DisplayChangeEvent>? ISurfaceDisplay.CurrentDisplayChanged
    {
        add => throw new NotImplementedException();
        remove => throw new NotImplementedException();
    }

    event Action<DisplayAvailabilityChangeEvent>? ISurfaceDisplay.AvailableChanged
    {
        add => throw new NotImplementedException();
        remove => throw new NotImplementedException();
    }

    event Action<DisplayVideoModeAvailabilityChangeEvent>? ISurfaceDisplay.AvailableVideoModesChanged
    {
        add => throw new NotImplementedException();
        remove => throw new NotImplementedException();
    }
}
