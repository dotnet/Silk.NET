// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// A handler for an event raised by a <see cref="Surface"/>.
/// </summary>
/// <typeparam name="T">The event arguments.</typeparam>
public delegate void SurfaceEventHandler<T>(Surface sender, T args);
