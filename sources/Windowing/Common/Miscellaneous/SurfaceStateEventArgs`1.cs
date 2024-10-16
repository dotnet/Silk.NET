// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Event arguments for events raised in response to a surface state change.
/// </summary>
/// <param name="Value">The new value of the state to which the event pertains.</param>
/// <typeparam name="T">The type of <paramref name="Value"/>.</typeparam>
public readonly record struct SurfaceStateEventArgs<T>(T Value);
