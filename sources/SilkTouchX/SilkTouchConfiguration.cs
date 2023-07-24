using System.Collections.Generic;

namespace SilkTouchX;

/// <summary>
/// Represents the configuration for a single generation job in SilkTouch.
/// </summary>
public class SilkTouchConfiguration
{
    /// <summary>
    /// The response files to read.
    /// </summary>
    public required string[] ClangSharpResponseFiles { get; set; }

    /// <summary>
    /// Manual overrides for ClangSharp outputs (i.e. manual tweaks of generated output) that should still flow through
    /// the SilkTouch pipeline as if it came from ClangSharp.
    /// </summary>
    public Dictionary<string, string>? ManualOverrides { get; set; }

    /// <summary>
    /// The solution in which the given source and test roots are contained.
    /// </summary>
    public required string Solution { get; set; }

    /// <summary>
    /// The root output directory as defined in the response files.
    /// </summary>
    public string? InputSourceRoot { get; set; }

    /// <summary>
    /// The test output directory as defined in the response files.
    /// </summary>
    public string? InputTestRoot { get; set; }

    /// <summary>
    /// The root output directory when writing the modded bindings.
    /// </summary>
    public string? OutputSourceRoot { get; set; }

    /// <summary>
    /// The test output directory when writing the modded tests.
    /// </summary>
    public string? OutputTestRoot { get; set; }

    /// <summary>
    /// The mods to load for generation. If there are no mods, this tool is basically equivalent to running
    /// ClangSharpPInvokeGenerator directly.
    /// </summary>
    public string[]? Mods { get; set; }
}
