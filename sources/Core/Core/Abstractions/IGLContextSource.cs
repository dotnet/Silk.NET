// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// Represents a source of a <see cref="IGLContext" />
/// </summary>
// Same as in 1.X/2.X, just a different namespace.
public interface IGLContextSource
{
    /// <summary>
    /// The OpenGL context.
    /// </summary>
    IGLContext? GLContext { get; }
}
