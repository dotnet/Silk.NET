// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Contains properties pertaining to events a surface shall raise at predictable intervals.
/// </summary>
/// <param name="TargetDelta">
/// The target number of seconds for the surface between the start of the previous execution of the event, and the start
/// of the next execution.
/// </param>
/// <remarks>
/// Note that timed events are executed in terms of the surface's tick frequency. If <see cref="Surface.TickOptions" />
/// is set to run the <see cref="Surface.Tick" /> event at a lower frequency than is targeted by this event, it is
/// impossible to meet the <paramref name="TargetDelta" />.
/// </remarks>
public readonly record struct SurfaceTimingOptions(double TargetDelta);
