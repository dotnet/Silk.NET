// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
    /// A path to the license header to use if one wasn't added by other means (e.g. a license header specified in a
    /// response file)
    /// </summary>
    public string? DefaultLicenseHeader { get; init; }

    /// <summary>
    /// The default namespace to be used by generated documents.
    /// </summary>
    public string? DefaultNamespace { get; init; }
}
