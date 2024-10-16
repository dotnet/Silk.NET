// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;

namespace Silk.NET.Windowing;

/// <summary>
/// Represents a windowing backend that can provide surfaces.
/// </summary>
public interface ISurfaceProvider
{
    /// <summary>
    /// Creates a surface with the given configuration.
    /// </summary>
    /// <param name="config">The configuration for the surface.</param>
    /// <typeparam name="TConfig">The type of the configuration for the surface.</typeparam>
    /// <returns>The surface.</returns>
    static abstract ISurface Create<TConfig>(TConfig config)
        where TConfig : ITypeChain;
}
