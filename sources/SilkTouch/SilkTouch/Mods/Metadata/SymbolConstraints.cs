// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;

namespace Silk.NET.SilkTouch.Mods.Metadata;

/// <summary>
/// Represents the usage constraints for a function (and its return type) or a parameter. This data structure is
/// generally modelled after
/// <see href="https://learn.microsoft.com/en-us/cpp/code-quality/annotating-function-parameters-and-return-values">
/// Microsoft's Source Annotation Language
/// </see>.
/// </summary>
/// <param name="Usage">The usage constraints for each logical requirement set.</param>
/// <param name="IsMutable">
/// Whether the type is mutable in C terms. That is, <c>const int*</c> will have <see cref="IsMutable"/> as <c>true</c>
/// but its <see cref="ElementTypeConstraints"/> will have <see cref="IsMutable"/> as <c>false</c>.
/// </param>
/// <param name="ComputedFromNames">
/// A list of symbol (parameters usually) names from which the symbol's element count is arbitrarily computed.
/// </param>
/// <param name="SuccessExpression">An expression determining whether the function's execution was successful.</param>
/// <param name="HasComSemantics">Whether the parameter has COM semantics.</param>
/// <param name="ElementTypeConstraints">The constraints applied to the element type.</param>
/// <param name="PostExecutionConstraints">The constraints that apply after the function's execution.</param>
public record SymbolConstraints(
    IReadOnlyList<LogicalAnnotation<UsageConstraints>> Usage,
    bool IsMutable = false,
    IReadOnlyList<string>? ComputedFromNames = null,
    string? SuccessExpression = null,
    bool HasComSemantics = false,
    SymbolConstraints? ElementTypeConstraints = null,
    SymbolConstraints? PostExecutionConstraints = null
)
{
    private UsageConstraints? _commonUsage;

    /// <summary>
    /// Gets the common usage constraints i.e. the usage constraints that always apply for the caller.
    /// </summary>
    public UsageConstraints? CommonUsage =>
        _commonUsage ??= Usage
            .Select(x => (LogicalAnnotation<UsageConstraints>?)x)
            .FirstOrDefault(x =>
                x!.Value.Requirement == LogicalRequirement.Always
                && x.Value.AppliesForLengthExpression is null
                && x.Value.AppliesAtExpression is null
            )
            ?.Value;

    /// <summary>
    /// Gets a value indicating whether the count is computed from other parameters.
    /// </summary>
    public bool IsComputed => ComputedFromNames?.Count > 0;

    /// <summary>
    /// Gets a value indicating whether the count is computed from a C# expression.
    /// </summary>
    public bool IsExpression => CommonUsage?.CountExpression is not null;

    /// <summary>
    /// Gets a value indicating whether the count is a static count.
    /// </summary>
    public bool IsStatic => !(IsComputed || CommonUsage?.CountExpression is not null);

    /// <summary>
    /// Gets a value indicating whether this count represents a count which is likely more than one.
    /// </summary>
    public bool IsMultiple =>
        (IsStatic && CommonUsage?.StaticCount > 1) || CommonUsage?.CountExpression is not null;
}
