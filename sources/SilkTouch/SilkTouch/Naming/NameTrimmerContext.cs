// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// State made available to <see cref="INameTrimmer"/> implementations when determining a trimmed name.
/// </summary>
public readonly struct NameTrimmerContext
{
    /// <summary>
    /// Gets the name of the "container" (e.g. a type name) of the APIs in <see cref="Names"/>.
    /// </summary>
    public string? Container { get; init; }

    /// <summary>
    /// Gets the identifier for the current generation job, unique across the current
    /// <see cref="SilkTouchGenerator"/> instance.
    /// </summary>
    public string? JobKey { get; init; }

    /// <summary>
    /// Gets a dictionary mapping the original API name to a primary candidate name to rename that API to. The previous
    /// names or other names that are otherwise less preferred to the primary name are listed in the optional secondary
    /// list (in order of preference).
    /// </summary>
    public required Dictionary<string, CandidateNames>? Names { get; init; }

    /// <summary>
    /// Gets the current configuration for the <see cref="PrettifyNames"/> mod.
    /// </summary>
    public PrettifyNames.Configuration Configuration { get; init; }

    /// <summary>
    /// Gets a set of original API names (i.e. key sto <see cref="Names"/>) that have been marked with
    /// the <c>Transformed</c> attribute.
    /// </summary>
    public HashSet<string> NonDeterminant { get; init; }
}

/// <summary>
/// TODO
/// </summary>
/// <param name="Primary"></param>
/// <param name="Secondary"></param>
public record struct CandidateNames(string Primary, List<string>? Secondary);

/// <summary>
/// TODO
/// </summary>
/// <param name="Primary"></param>
/// <param name="Secondary"></param>
/// <param name="Original"></param>
public record struct CandidateNamesWithOriginal(string Primary, List<string>? Secondary, string Original);
