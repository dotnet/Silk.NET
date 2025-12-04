// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Represents the set of primary and secondary options for the trimmed version of a name.
/// Also includes the original, unmodified name.
/// </summary>
/// <param name="Primary">The preferred version of the trimmed name.</param>
/// <param name="Secondary">The fallback versions of the trimmed name in case the primary does not work.</param>
/// <param name="Original">The original, unmodified name.</param>
public record struct CandidateNamesWithOriginal(string Primary, List<string>? Secondary, string Original)
{
    /// <summary>
    /// Formats this instance as a string.
    /// </summary>
    public override string ToString() =>
        $"(Original={Original}, Primary={Primary}, Secondary=[{string.Join(", ", Secondary ?? [])}])";
}
