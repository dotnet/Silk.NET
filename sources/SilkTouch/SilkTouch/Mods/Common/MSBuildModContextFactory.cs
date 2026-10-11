// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Logging;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A <see cref="IModContextFactory"/> that creates mod contexts that use an MSBuild workspace.
/// </summary>
public class MSBuildModContextFactory(ILogger<MSBuildModContextFactory> logger) : IModContextFactory
{
    /// <inheritdoc />
    public async Task<IModContext> CreateContextAsync(
        string key,
        SilkTouchConfiguration config,
        CancellationToken ct = default
    )
    {
        var ret = new MSBuildModContext(key, config, logger);
        await ret.InitializeAsync();
        return ret;
    }
}
