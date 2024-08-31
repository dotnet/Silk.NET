// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;
using Silk.NET.Windowing.Hosting;

namespace Silk.NET.Windowing;

/// <summary>
/// Encapsulates surface configuration while providing a fluent API as per the builder pattern.
/// </summary>
/// <param name="ExtraConfiguration">Extra configuration for components of the surface.</param>
/// <typeparam name="TExtra">The type of the extra configuration.</typeparam>
/// <typeparam name="TImpl">The source of the implementation of the surface's components.</typeparam>
public readonly record struct SurfaceBuilder<TExtra, TImpl>(TExtra ExtraConfiguration)
    where TExtra : IConfigureHost
    where TImpl : ISurfaceHost
{
    /// <summary>
    /// Creates a surface using the configuration encapsulated in this surface builder.
    /// </summary>
    /// <returns>The built surface.</returns>
    public Surface Build() => Surface.Create<TExtra, TImpl>(ExtraConfiguration);
}
