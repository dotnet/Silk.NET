// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Contains properties pertaining to a surface changing to a different video mode.
/// </summary>
/// <param name="Surface">The surface changing to a different video mode.</param>
/// <param name="VideoMode">The video mode the surface has changed to.</param>
public readonly record struct VideoModeChangeEvent(Surface Surface, VideoMode VideoMode);
