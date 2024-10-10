// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;
using Silk.NET.Windowing.Hosting;

namespace Silk.NET.Windowing;

/// <summary>
/// Shorthand for creating a new <see cref="SurfaceBuilder{TExtra,TImpl}"/> with <see cref="Default"/> configuration.
/// </summary>
/// <typeparam name="TImpl">The implementation source of the surface components.</typeparam>
public static class SurfaceBuilder<TImpl>
    where TImpl : ISurfaceHost
{
    /// <summary>
    /// Creates a new <see cref="SurfaceBuilder{TExtra,TImpl}"/> with the default configuration, implemented by
    /// <typeparamref name="TImpl"/>.
    /// </summary>
    /// <returns>The surface builder.</returns>
    public static SurfaceBuilder<IConfigureHost.Null, TImpl> Create() => new(default);
}
