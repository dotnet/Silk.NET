// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;

namespace Silk.NET.Windowing.Hosting;

/// <summary>
/// Represents a strongly-typed handle to a surface hosted on a <see cref="ISurfaceHost"/>.
/// </summary>
/// <param name="Value">The underlying handle.</param>
public readonly record struct SurfaceHandle(nint Value) : ISurfaceOrRequestHandle;

/// <summary>
/// Represents a strongly-typed handle to a request for a surface hosted on a <see cref="ISurfaceHost"/>.
/// </summary>
/// <param name="Value">The underlying handle.</param>
public readonly record struct RequestHandle(nint Value) : ISurfaceOrRequestHandle;

/// <summary>
/// An interface assignable from either a <see cref="SurfaceHandle"/> or a <see cref="RequestHandle"/>. Any
/// implementation of this interface that isn't <see cref="RequestHandle"/> is treated as a <see cref="SurfaceHandle"/>.
/// </summary>
public interface ISurfaceOrRequestHandle
{
    /// <summary>
    /// The underlying handle.
    /// </summary>
    nint Value { get; }
}

/// <summary>
/// Represents a strongly-typed handle to an event pump for a surface hosted on a <see cref="ISurfaceHost"/>.
/// </summary>
/// <param name="Value">The underlying value.</param>
public readonly record struct EventPumpHandle(nint Value);
