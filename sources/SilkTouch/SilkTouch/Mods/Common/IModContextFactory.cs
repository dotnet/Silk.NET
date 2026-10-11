// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Creates <see cref="IModContext"/> for use throughout a job.
/// </summary>
public interface IModContextFactory
{
    /// <summary>
    /// Creates a new mod context.
    /// </summary>
    /// <param name="key">The job key.</param>
    /// <param name="config">The generator configuration.</param>
    /// <param name="ct">The cancellation token.</param>
    /// <returns>The mod context.</returns>
    public Task<IModContext> CreateContextAsync(
        string key,
        SilkTouchConfiguration config,
        CancellationToken ct = default
    );
}
