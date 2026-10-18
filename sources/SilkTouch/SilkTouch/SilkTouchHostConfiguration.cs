// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Clang;

namespace Silk.NET.SilkTouch;

/// <summary>
/// Represents the configuration for the <see cref="SilkTouchHost"/> shared by multiple bindings generation jobs.
/// </summary>
public record SilkTouchHostConfiguration
{
    /// <summary>
    /// Limits the generator to only using the cache.
    /// </summary>
    /// <remarks>
    /// Currently only affects <see cref="ClangScraper"/>.
    /// </remarks>
    public required bool UseCacheOnly { get; init; }

    /// <summary>
    /// Limits the generator to only generating the cache.
    /// </summary>
    /// <remarks>
    /// Currently only affects <see cref="ClangScraper"/>.
    /// </remarks>
    public required bool GenerateCacheOnly { get; init; }
}
