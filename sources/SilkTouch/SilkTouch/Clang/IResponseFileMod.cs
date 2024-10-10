// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Represents a mod that modifies <see cref="ResponseFile"/>s before they are used by <see cref="ClangScraper"/> to
/// scrape raw bindings from ClangSharp.
/// </summary>
public interface IResponseFileMod
{
    /// <summary>
    /// Runs before SilkTouch invokes ClangSharp with the given parsed response files. Gives each mod an opportunity to
    /// modify the generator configuration.
    /// </summary>
    /// <param name="key">The job name (corresponds to the configuration key for mod configs).</param>
    /// <param name="rsps">The read response files.</param>
    /// <returns>
    /// The modified response files to be passed into either the next mod or ClangSharp if this is the last mod.
    /// </returns>
    Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps);
}
