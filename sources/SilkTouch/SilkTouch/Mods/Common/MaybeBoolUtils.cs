// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Utilities related to working with the <see cref="MaybeBool{T}"/> type.
/// </summary>
public static class MaybeBoolUtils
{
    /// <summary>
    /// Creates a generic name syntax representing the <see cref="MaybeBool{T}"/> type
    /// using the provided generic arguments.
    /// </summary>
    /// <param name="type">The underlying type used by the <see cref="MaybeBool{T}"/> type.</param>
    /// <param name="scheme">The scheme used to determine the underlying value.</param>
    public static GenericNameSyntax MaybeBoolType(TypeSyntax type, string? scheme) =>
        string.IsNullOrWhiteSpace(scheme)
            ? GenericName(Identifier("MaybeBool"), TypeArgumentList([type]))
            : GenericName(
                Identifier("MaybeBool"),
                TypeArgumentList([type, IdentifierName(scheme)])
            );
}
