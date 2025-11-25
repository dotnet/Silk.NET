// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Common utilities related to manipulating attributes.
/// </summary>
public static class AttributeUtils
{
    /// <summary>
    /// Determines (naively) whether the given attribute syntax represents the specified attribute.
    /// </summary>
    /// <param name="node">The attribute syntax.</param>
    /// <param name="fullNameWithoutSuffix">
    /// The fully-qualified attribute name including the namespace but without the <c>Attribute</c> suffix.
    /// </param>
    /// <returns>Whether it is probably the specified attribute.</returns>
    public static bool IsAttribute(this AttributeSyntax node, string fullNameWithoutSuffix)
    {
        var sep = node.Name.ToString().Split("::").Last();
        var name = fullNameWithoutSuffix.Split('.').Last();
        return sep == name
               || sep == $"{name}Attribute"
               || sep.EndsWith(fullNameWithoutSuffix)
               || sep.EndsWith($"{fullNameWithoutSuffix}Attribute");
    }

    /// <summary>
    /// Modifies the <see cref="DllImportAttribute"/>s the method may have to make them resistant to method identifier
    /// changes.
    /// </summary>
    /// <param name="node">The original method.</param>
    /// <returns>The modified method.</returns>
    public static MethodDeclarationSyntax WithRenameSafeAttributeLists(
        this MethodDeclarationSyntax node
    ) =>
        node.WithAttributeLists(
            List(
                node.AttributeLists.Select(x =>
                    x.WithAttributes(
                        SeparatedList(
                            x.Attributes.Select(y =>
                                y.IsAttribute("System.Runtime.InteropServices.DllImport")
                                && (
                                    y.ArgumentList?.Arguments.All(z =>
                                        z.NameEquals?.Name.ToString() != "EntryPoint"
                                    ) ?? true
                                )
                                    ? y.AddArgumentListArguments(
                                        AttributeArgument(
                                                LiteralExpression(
                                                    SyntaxKind.StringLiteralExpression,
                                                    Literal(node.Identifier.ToString())
                                                )
                                            )
                                            .WithNameEquals(NameEquals("EntryPoint"))
                                    )
                                    : y
                            )
                        )
                    )
                )
            )
        );

    /// <summary>
    /// Adds <see cref="MaxOpt"/> to the given <see cref="MethodDeclarationSyntax"/>'s attribute lists.
    /// </summary>
    /// <param name="meth">The method.</param>
    /// <returns>The modified method.</returns>
    public static MethodDeclarationSyntax AddMaxOpt(this MethodDeclarationSyntax meth) =>
        meth.AddAttributeLists(MaxOpt);

    /// <summary>
    /// Gets the library name and entry-point for the given attribute list, or returns false if this is not a native
    /// interop function.
    /// </summary>
    /// <param name="attrLists">The attribute lists.</param>
    /// <param name="libraryName">The library name.</param>
    /// <param name="entryPoint">The entry-point.</param>
    /// <param name="callConv">The calling convention (if any).</param>
    /// <returns>Whether the native function info was found.</returns>
    public static bool GetNativeFunctionInfo(
        this IEnumerable<AttributeListSyntax> attrLists,
        [NotNullWhen(true)] out string? libraryName,
        out string? entryPoint,
        out string? callConv
    )
    {
        foreach (
            var attr in from attrList in attrLists
            from attr in attrList.Attributes
            where
                attr.IsAttribute("System.Runtime.InteropServices.DllImport")
                || attr.IsAttribute("Silk.NET.Core.NativeFunction")
            select attr
        )
        {
            libraryName =
                (attr.ArgumentList?.Arguments.First().Expression as LiteralExpressionSyntax)
                    ?.Token
                    .ValueText
                ?? throw new InvalidOperationException("DllImport was found but was not valid");
            entryPoint = (
                attr.ArgumentList?.Arguments.FirstOrDefault(x =>
                    x.NameEquals is not null
                    && x.NameEquals.Name.ToString() == nameof(DllImportAttribute.EntryPoint)
                )?.Expression as LiteralExpressionSyntax
            )
                ?.Token
                .ValueText;
            callConv = (
                attr.ArgumentList?.Arguments.FirstOrDefault(x =>
                    x.NameEquals is not null
                    && x.NameEquals.Name.ToString() == nameof(DllImportAttribute.CallingConvention)
                )?.Expression as MemberAccessExpressionSyntax
            )?.Name.ToString();
            return true;
        }

        libraryName = entryPoint = callConv = null;
        return false;
    }

    /// <summary>
    /// Adds a NativeFunctionAttribute if a <see cref="DllImportAttribute"/> is present on the
    /// <paramref name="original"/>.
    /// </summary>
    /// <param name="meth">The method to modify.</param>
    /// <param name="original">The original method.</param>
    /// <returns>The (possibly) modified method.</returns>
    /// <exception cref="InvalidOperationException">If a DllImportAttribute was found but wasn't valid.</exception>
    public static MethodDeclarationSyntax AddNativeFunction(
        this MethodDeclarationSyntax meth,
        MethodDeclarationSyntax original
    )
    {
        if (
            original.AttributeLists.GetNativeFunctionInfo(
                out var libName,
                out var entryPoint,
                out _
            )
        )
        {
            return meth.AddAttributeLists(
                AttributeList(
                    SingletonSeparatedList(
                        Attribute(IdentifierName("NativeFunction"))
                            .WithArgumentList(
                                AttributeArgumentList(
                                    SeparatedList(
                                        new[]
                                        {
                                            AttributeArgument(
                                                LiteralExpression(
                                                    SyntaxKind.StringLiteralExpression,
                                                    Literal(libName)
                                                )
                                            ),
                                            AttributeArgument(
                                                    LiteralExpression(
                                                        SyntaxKind.StringLiteralExpression,
                                                        Literal(
                                                            entryPoint ?? meth.Identifier.ToString()
                                                        )
                                                    )
                                                )
                                                .WithNameEquals(NameEquals("EntryPoint")),
                                        }
                                    )
                                )
                            )
                    )
                )
            );
        }

        return meth;
    }

    /// <summary>
    /// Gets the value of the native name attribute from the given attribute list.
    /// </summary>
    public static bool TryGetNativeName(this IEnumerable<AttributeListSyntax> attributeLists, out string? nativeName)
    {
        var nativeNameAttribute = attributeLists.SelectMany(list => list.Attributes).FirstOrDefault(attribute => attribute.IsAttribute("Silk.NET.Core.NativeName"));
        if (nativeNameAttribute == null)
        {
            nativeName = null;
            return false;
        }

        nativeName = nativeNameAttribute.ArgumentList?.Arguments
            .Select(arg =>
                arg.IsKind(SyntaxKind.StringLiteralExpression)
                    ? (arg.Expression as LiteralExpressionSyntax)?.Token.Value
                    : null)
            .OfType<string>()
            .FirstOrDefault();

        return nativeName != null;
    }

    /// <summary>
    /// Sets or replaces the native name attribute in the given attribute list.
    /// </summary>
    public static SyntaxList<AttributeListSyntax> WithNativeName(this IEnumerable<AttributeListSyntax> attributeLists, string nativeName)
    {
        var nativeNameAttribute = AttributeList([
            Attribute(
                IdentifierName("NativeName"),
                AttributeArgumentList([
                    AttributeArgument(LiteralExpression(SyntaxKind.StringLiteralExpression, Literal($"\"{nativeName}\"", nativeName))),
                ])),
        ]);

        return List(attributeLists.Select(list => {
                var attributes = list.Attributes;
                attributes = [..attributes.Where(attribute => !attribute.IsAttribute("Silk.NET.Core.NativeName"))];

                return attributes.Count == 0 ? null : list.WithAttributes(attributes);
            })
            .Where(list => list != null)
            .Cast<AttributeListSyntax>()
            .Prepend(nativeNameAttribute));
    }

    /// <summary>
    /// Retrieves the native type name within the given attribute list.
    /// </summary>
    /// <param name="attrs">The attributes.</param>
    /// <param name="requireContext">The required attribute target/context.</param>
    /// <returns>The native type name.</returns>
    public static string? GetNativeTypeName(
        this IEnumerable<AttributeListSyntax> attrs,
        SyntaxKind? requireContext = null
    ) =>
        attrs
            .SelectMany(x =>
                (x.Target is null && requireContext is null)
                || (requireContext is { } rc && (x.Target?.Identifier.IsKind(rc) ?? false))
                    ? x.Attributes
                    : Enumerable.Empty<AttributeSyntax>()
            )
            .FirstOrDefault(x => x.IsAttribute("Silk.NET.Core.NativeTypeName"))
            ?.ArgumentList?.Arguments.Select(x =>
                x.Expression.IsKind(SyntaxKind.StringLiteralExpression)
                    ? (x.Expression as LiteralExpressionSyntax)?.Token.Value
                    : null
            )
            .OfType<string>()
            .FirstOrDefault();

    /// <summary>
    /// Gets the native element type name indicated by the given attributes.
    /// </summary>
    /// <param name="attrs">The attributes.</param>
    /// <param name="info">The parsed native type info. Invalid if this method returns false.</param>
    /// <returns>Whether the type name was successfully parsed.</returns>
    /// <remarks>
    /// This does not handle all of the possible cases.
    /// </remarks>
    public static bool TryParseNativeTypeName(
        this IEnumerable<AttributeListSyntax> attrs,
        out NativeTypeNameInfo info
    )
    {
        var nativeTypeNameString = attrs.GetNativeTypeName();
        var nativeTypeName = nativeTypeNameString.AsSpan();
        if (nativeTypeName.Length == 0)
        {
            // Name does not exist
            info = default;
            return false;
        }

        switch (nativeTypeName)
        {
            // Handle case: "#define NAME VALUE"
            case {} when nativeTypeName.StartsWith("#define "):
            {
                // Trim off the #define
                var nativeTypeSpan = nativeTypeName["#define ".Length..].Trim();

                var indexOfFirstSpace = nativeTypeSpan.IndexOf(' ');
                if (indexOfFirstSpace < 0)
                {
                    info = new NativeTypeNameInfo()
                    {
                        Name = nativeTypeName.ToString(),
                        Value = null,
                        IndirectionLevels = 0,
                        IsDefine = true,
                        IsConst = true,
                    };

                    return true;
                }

                var name = nativeTypeSpan[..indexOfFirstSpace];
                var value = nativeTypeSpan[indexOfFirstSpace..];

                info = new NativeTypeNameInfo()
                {
                    Name = name.ToString(),
                    Value = value.ToString(),
                    IndirectionLevels = 0,
                    IsDefine = true,
                    IsConst = true,
                };

                return true;
            }

            // Handle cases: "const NAME **", "NAME **"
            case {}:
            {
                // Trim off the const
                var isConst = false;
                if (nativeTypeName.StartsWith("const "))
                {
                    nativeTypeName = nativeTypeName["const ".Length..].Trim();
                    isConst = true;
                }

                // Isolate the name
                var indirectionLevels = nativeTypeName.Count('*');
                if (nativeTypeName.IndexOf('*') is not -1 and var idx)
                {
                    nativeTypeName = nativeTypeName[..idx];
                }
                nativeTypeName = nativeTypeName.Trim();

                if (nativeTypeName.ContainsAnyExcept(NameUtils.IdentifierChars))
                {
                    // Unsupported format
                    // Eg: const uint32_t[8]
                    info = default;
                    return false;
                }

                info = new NativeTypeNameInfo()
                {
                    Name = nativeTypeName.ToString(),
                    Value = null,
                    IndirectionLevels = indirectionLevels,
                    IsDefine = false,
                    IsConst = isConst,
                };

                return true;
            }
        }
    }

    /// <summary>
    /// Gets a native type name for a parameter.
    /// </summary>
    /// <param name="syntax">The parameter.</param>
    /// <returns>The native type name.</returns>
    public static string? GetNativeTypeName(this ParameterSyntax syntax) =>
        syntax.AttributeLists.GetNativeTypeName();

    /// <summary>
    /// Gets a native type name for the return type of a method.
    /// </summary>
    /// <param name="syntax">The method.</param>
    /// <returns>The native type name.</returns>
    public static string? GetNativeReturnTypeName(this BaseMethodDeclarationSyntax syntax) =>
        syntax.AttributeLists.GetNativeTypeName(SyntaxKind.ReturnKeyword);

    /// <summary>
    /// Gets an attribute list representing a <see cref="System.Runtime.CompilerServices.MethodImplAttribute"/> with
    /// <see cref="System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining"/> and
    /// <see cref="System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization"/> set.
    /// </summary>
    public static readonly AttributeListSyntax MaxOpt = AttributeList(
        SingletonSeparatedList(
            Attribute(IdentifierName("MethodImpl"))
                .WithArgumentList(
                    AttributeArgumentList(
                        SingletonSeparatedList(
                            AttributeArgument(
                                BinaryExpression(
                                    SyntaxKind.BitwiseOrExpression,
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("MethodImplOptions"),
                                        IdentifierName("AggressiveInlining")
                                    ),
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("MethodImplOptions"),
                                        IdentifierName("AggressiveOptimization")
                                    )
                                )
                            )
                        )
                    )
                )
        )
    );
}
