// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing.SDL3;

/// <summary>
/// Enumerates the properties of an SDL surface. These can be used as bitflags to enable diffing scenarios.
/// </summary>
// TODO if ever we make SdlSurface thread-safe, I'd imagine we'd use flags like these to determine what changes need to
// be done before next tick and what events we need to raise next time the child thread ticks
[Flags]
internal enum SdlSurfaceProperties
{
    // Changeable by end user and developer
    WindowSize = 1 << 0,
    WindowPosition = 1 << 1,
    BorderSize = 1 << 2,
    IsCloseRequested = 1 << 3,
    IsFocused = 1 << 4,
    State = 1 << 5,
    CurrentDisplay = 1 << 6,
    VideoMode = 1 << 7,
}
