// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Event arguments for events raised on a regular schedule.
/// </summary>
/// <param name="DeltaSeconds">The time since the last time this event was raised.</param>
public readonly record struct TimedEventArgs(double DeltaSeconds);
