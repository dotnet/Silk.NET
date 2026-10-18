// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
    /// The path to resolve relative paths from.
    /// </summary>
    public string WorkingDirectory { get; }

    /// <summary>
    /// The current compilation for the generation outputs.
    /// </summary>
    public Project? SourceProject { get; set; }

    /// <summary>
    /// The current compilation for the test outputs.
    /// </summary>
    public Project? TestProject { get; set; }

    /// <summary>
    /// Whether generation should continue.
    /// </summary>
    public bool ContinueGeneration { get; set; }

    /// <summary>
    /// Output the bindings to the output location represented by this mod context.
    /// </summary>
    public Task OutputBindingsAsync();
}
