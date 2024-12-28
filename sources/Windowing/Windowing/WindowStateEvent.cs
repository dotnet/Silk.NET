// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Contains properties pertaining to a change in window state.
/// </summary>
/// <param name="Surface">The surface that owns the window to which the event pertains.</param>
/// <param name="OldState">The previous value of <see cref="ISurfaceWindow.State" />.</param>
/// <param name="NewState">The new value of <see cref="ISurfaceWindow.State" />.</param>
public readonly record struct WindowStateEvent(
    Surface Surface,
    WindowState OldState,
    WindowState NewState
);
