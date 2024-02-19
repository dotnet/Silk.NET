using System.Collections.Generic;

namespace Silk.NET.SilkTouch;

/// <summary>
/// Represents the configuration for a single generation job in SilkTouch.
/// </summary>
public record SilkTouchConfiguration
{
    /// <summary>
    /// The response files to read.
    /// </summary>
    public required string[] ClangSharpResponseFiles { get; init; }

    /// <summary>
    /// Manual overrides for ClangSharp outputs (i.e. manual tweaks of generated output) that should still flow through
    /// the SilkTouch pipeline as if it came from ClangSharp.
    /// </summary>
    public Dictionary<string, string>? ManualOverrides { get; init; }

    /// <summary>
    /// The solution in which the given source and test roots are contained.
    /// </summary>
    public required string Solution { get; init; }

    /// <summary>
    /// The root output directory as defined in the response files.
    /// </summary>
    public string? InputSourceRoot { get; init; }

    /// <summary>
    /// The test output directory as defined in the response files.
    /// </summary>
    public string? InputTestRoot { get; init; }

    /// <summary>
    /// The root output directory when writing the modded bindings.
    /// </summary>
    public string? OutputSourceRoot { get; init; }

    /// <summary>
    /// The test output directory when writing the modded tests.
    /// </summary>
    public string? OutputTestRoot { get; init; }

    /// <summary>
    /// The mods to load for generation. If there are no mods, this tool is basically equivalent to running
    /// ClangSharpPInvokeGenerator directly.
    /// </summary>
    public string[]? Mods { get; init; }

    /// <summary>
    /// Skips generation if any of the given strings are in the <see cref="SilkTouchGenerator.ApplicableSkipIfs"/> set.
    /// </summary>
    public string[]? SkipScrapeIf { get; init; }
}
