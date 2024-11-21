// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

using System.Numerics;

/// <summary>
/// Represents the properties of a surface whose rendering is intrinsically linked to the composition of a specific
/// display. In most cases, this translates to "the surface is rendering in fullscreen mode".
/// </summary>
/// <param name="Resolution">
/// The resolution the surface is rendering on its display at, if known. If <c>null</c>, it is highly likely that the
/// surface is not rendering in fullscreen mode or otherwise has its rendering intrinsically linked to the composition
/// of a specific display.
/// </param>
/// <param name="RefreshRate">
/// The rate (per second) at which the physical display will receive new renders from the surface, if known. If
/// <c>null</c>, the platform may not expose the refresh rate to surfaces or it is highly likely that the
/// surface is not rendering in fullscreen mode or otherwise has its rendering intrinsically linked to the composition
/// of a specific display.
/// </param>
/// <remarks>
/// If a <c>default</c> video mode is encountered, it is highly likely the surface is not rendering in fullscreen mode.
/// If an individual property is <c>null</c>, it is highly likely that property is not controllable programmatically.
/// </remarks>
public readonly record struct VideoMode(Vector2? Resolution, int? RefreshRate);
