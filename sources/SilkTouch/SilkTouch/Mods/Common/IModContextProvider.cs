// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Creates <see cref="IModContext"/> for use throughout a job.
/// </summary>
public interface IModContextProvider
{
    /// <summary>
    /// Creates a new mod context.
    /// </summary>
    /// <param name="key">The job key.</param>
    /// <param name="cfg">The generator configuration.</param>
    /// <param name="ct">The cancellation token.</param>
    /// <returns>The mod context.</returns>
    Task<IModContext> GetContextAsync(
        string key,
        IConfigurationSection cfg,
        CancellationToken ct = default
    );
}
