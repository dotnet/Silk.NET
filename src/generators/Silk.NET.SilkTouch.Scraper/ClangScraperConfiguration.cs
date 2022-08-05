// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Scraper;

/// <summary>
/// Represents configuration values for <see cref="ClangScraper"/>
/// </summary>
public sealed class ClangScraperConfiguration
{
    /// <summary>
    /// The Xcode SDK version. Only used when resolving SDK path on OSX. Passed to xcrun as --sdk if present.
    /// </summary>
    public string? XcodeSdk { get; set; } = null;
}
