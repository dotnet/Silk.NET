// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Event arguments for events raised by a change in surface state. If the state change is parameterised,
/// <see cref="SurfaceStateEventArgs{T}"/> should be used instead. This struct is empty to allow for the non-breaking
/// addition of event arguments should the need arise in the future.
/// </summary>
public readonly record struct SurfaceStateEventArgs;
