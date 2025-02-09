// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Contains parameters for events executed at predictable intervals by a <see cref="Surface" />.
/// </summary>
/// <param name="Surface">The surface to which the event pertains.</param>
/// <param name="DeltaTime">The number of seconds that have elapsed since the last execution of this event.</param>
public readonly record struct SurfaceTimingEvent(Surface Surface, double DeltaTime);
