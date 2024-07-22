// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;

namespace Silk.NET.Windowing;

/// <summary>
/// Shorthand for creating a <see cref="SurfaceBuilder{TExtra, TImpl}"/> using <see cref="Default"/> configuration and
/// the <see cref="ReferenceImplementation"/>.
/// </summary>
public static class SurfaceBuilder
{
    /// <summary>
    /// Creates a <see cref="SurfaceBuilder{TExtra, TImpl}"/> using <see cref="Default"/> configuration and
    /// the <see cref="ReferenceImplementation"/>.
    /// </summary>
    /// <returns>The surface builder.</returns>
    public static SurfaceBuilder<Default, ReferenceImplementation> Create() => new(default);
}
