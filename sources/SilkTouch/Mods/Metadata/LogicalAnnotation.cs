// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Mods.Metadata;

/// <summary>
/// Represents an annotation that only applies in specific circumstances.
/// </summary>
/// <param name="Requirement">The circumstances in which the annotation applies.</param>
/// <param name="RequirementExpression">An expression that determines when the annotation applies.</param>
/// <param name="AppliesAtExpression">An expression that gets the address at which the annotation applies.</param>
/// <param name="AppliesForLengthExpression">
/// An expression that determines the offset from the <paramref name="AppliesAtExpression"/> at which the requirement
/// stops applying.
/// </param>
/// <param name="Value">The value of the annotation.</param>
/// <typeparam name="T">The type of the value.</typeparam>
/// <seealso href="https://learn.microsoft.com/en-us/cpp/code-quality/specifying-when-and-where-an-annotation-applies">
/// Microsoft SAL: Specifying When and Where an Annotation Applies
/// </seealso>
public readonly record struct LogicalAnnotation<T>(
    LogicalRequirement Requirement,
    string? RequirementExpression,
    string? AppliesAtExpression,
    string? AppliesForLengthExpression,
    T Value
);
