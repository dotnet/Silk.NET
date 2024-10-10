using System.Collections.Generic;

namespace Silk.NET.SilkTouch;

/// <summary>
/// Represents the configuration for a single generation job in SilkTouch.
/// </summary>
public record SilkTouchConfiguration
{
    /// <summary>
    /// The solution in which the given source and test roots are contained.
    /// </summary>
    public required string Solution { get; init; }

    /// <summary>
    /// The source output csproj path, the directory of which used when writing the modded bindings.
    /// </summary>
    public string? SourceProject { get; init; }

    /// <summary>
    /// The test output csproj path, the directory of which used when writing the modded tests.
    /// </summary>
    public string? TestProject { get; init; }

    /// <summary>
    /// The mods to load for generation. If there are no mods, this tool is basically equivalent to running
    /// ClangSharpPInvokeGenerator directly.
    /// </summary>
    public string[]? Mods { get; init; }

    /// <summary>
    /// A path to the license header to use if one wasn't added by other means (e.g. a license header specified in a
    /// response file)
    /// </summary>
    public string? DefaultLicenseHeader { get; init; }
}
