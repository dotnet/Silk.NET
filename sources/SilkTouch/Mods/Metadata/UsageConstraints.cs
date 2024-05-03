// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Mods.Metadata;

/// <summary>
/// Represents the <see cref="SymbolConstraints"/> that are conditionally applied through a
/// <see cref="LogicalAnnotation{T}"/>.
/// </summary>
/// <param name="IsIn">
/// Whether this is an input parameter where, in the case of a pointer, the pointee is read but never written to.
/// This also implies that <see cref="SymbolConstraints.ElementTypeConstraints"/> has
/// <see cref="SymbolConstraints.IsMutable"/> set to <c>false</c>.
/// </param>
/// <param name="IsOut">
/// Whether this is an output parameter where, in the case of a pointer, the pointee is written to but never read.
/// This also implies that <see cref="SymbolConstraints.ElementTypeConstraints"/> has
/// <see cref="SymbolConstraints.IsMutable"/> set to <c>true</c>.
/// This should imply that the initial value of the pointee should be <c>default</c>.
/// </param>
/// <param name="IsOptional">Whether the parameter can be set to its <c>default</c> value.</param>
/// <param name="IsNullTerminated">Whether the buffer used by this parameter or return type is null-terminated.</param>
/// <param name="MinValueExpression">
/// An expression representing the minimum acceptable value within the range of the acceptable values.
/// </param>
/// <param name="MaxValueExpression">
/// An expression representing the maximum (exclusive) acceptable value within the range of acceptable values.
/// </param>
/// <param name="StaticCount">
/// A constant representing the number of elements to be read from the pointer.
/// Supersedes <see cref="CountExpression"/>.
/// </param>
/// <param name="CountExpression">
/// An expression evaluating to the number of elements to be read from the pointer.
/// </param>
/// <param name="IsCountBytes">Whether the count represented by either <see cref="StaticCount"/> or
/// <see cref="CountExpression"/> is in terms of bytes rather than the element type's size.</param>
/// <param name="RaisesSehException">Whether the symbol raises a Structured Exception Handling (SEH) exception.</param>
/// <param name="MustUseResult">Whether the result must not be discarded.</param>
/// <param name="FunctionClass">An arbitrary string determining the class/category into which a function falls.</param>
/// <param name="SatisfiesExpression">The given expression must evaluate to true.</param>
public readonly record struct UsageConstraints(
    bool IsIn = false,
    bool IsOut = false,
    bool IsOptional = false,
    bool IsNullTerminated = false,
    int StaticCount = 0,
    string? CountExpression = null,
    bool IsCountBytes = false,
    string? MinValueExpression = null,
    string? MaxValueExpression = null,
    VariableConstraint RaisesSehException = VariableConstraint.False,
    bool MustUseResult = false,
    string? FunctionClass = null,
    string? SatisfiesExpression = null
)
{
    /// <summary>
    /// Whether the parameter is neither an input or an output (impossible). Bidirectional parameters have both set.
    /// </summary>
    public bool IsIndeterminateFlow => !IsIn && !IsOut;
}
