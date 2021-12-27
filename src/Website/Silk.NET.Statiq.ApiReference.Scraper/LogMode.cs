// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Statiq.ApiReference.Scraper;

/// <summary>
/// The level of logging to use during generation.
/// </summary>
public enum LogMode
{
    /// <summary>
    /// Standard logging. Contains info throughout the generation process and warnings produced.
    /// </summary>
    Standard,
        
    /// <summary>
    /// Silent logging. Only logs if there's an error and suppresses the "logo".
    /// </summary>
    Silent,
        
    /// <summary>
    /// Verbose logging. Contains trace logs including suppressed diagnostics. Spammier.
    /// </summary>
    Verbose,
        
    /// <summary>
    /// Very verbose logging. Contains every log message ever possibly conceived.
    /// Spammiest, far too spammy for most uses.
    /// </summary>
    VVerbose
}