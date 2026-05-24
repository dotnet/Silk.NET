// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Microsoft.CodeAnalysis;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Data for mod execution.
/// </summary>
public interface IModContext : IAsyncDisposable
{
    /// <summary>
    /// A unique string identifier for this generation job.
    /// </summary>
    public string JobKey { get; }

    /// <summary>
    /// Gets the directory in which the configuration file is contained. May be null if I/O is banned in the current
    /// generator form factor (e.g. the SilkTouch framework is running as a source generator).
    /// </summary>
    public string? ConfigurationDirectory { get; }

    /// <summary>
    /// The current compilation for the generation outputs.
    /// </summary>
    public Project? SourceProject { get; set; }

    /// <summary>
    /// The current compilation for the test outputs.
    /// </summary>
    public Project? TestProject { get; set; }
}
