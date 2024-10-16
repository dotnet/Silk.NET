// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;

namespace Silk.NET.Windowing;

/// <summary>
/// Represents the reference implementation for <see cref="Surface"/>. This currently uses SDL.
/// </summary>
public class ReferenceImplementation : ISurfaceProvider
{
    /// <inheritdoc />
    public static ISurface Create<TConfig>(TConfig config)
        where TConfig : ITypeChain => throw new NotImplementedException();
}
