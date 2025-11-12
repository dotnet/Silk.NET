// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.Core;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Metadata;

/// <summary>
/// Utilities for dealing with metadata.
/// </summary>
public static class MetadataUtils
{
    /// <summary>
    /// Gets the number of indirection levels in the given C representation of a pointer type.
    /// </summary>
    /// <param name="cType">The C type or parameter string.</param>
    /// <returns>The indirection levels.</returns>
    public static int GetIndirectionLevels(this ReadOnlySpan<char> cType) =>
        cType.Count('*') + (cType.Contains('[') ? 1 : 0);

    /// <summary>
    /// Gets the mutability and type-specified length (if applicable) for each indirection level (and its element type)
    /// </summary>
    /// <param name="cType">The C type or parameter string.</param>
    /// <param name="mutability">The mutabilities for each indirection level.</param>
    /// <param name="outerCount">
    /// If the type had an array specifier, this specifies the count of the outermost indirection level. Will be zero
    /// if this is not the case.
    /// </param>
    /// <remarks>
    /// The outermost element type will appear first in the mutability span.
    /// </remarks>
    public static void GetTypeDetails(
        this ReadOnlySpan<char> cType,
        Span<bool> mutability,
        out int outerCount
    )
    {
        outerCount = 0;
        var i = 0;
        while (cType.IndexOfAny('*', '[') is not -1 and var idx)
        {
            if (cType[idx] == '[')
            {
                do
                {
                    var num = cType[(idx + 1)..];
                    if (num.IndexOf(']') is not -1 and var j)
                    {
                        num = num[..j];
                        idx += num.Length + 2; // + 1 for [, + 1 again for ]
                    }
                    else
                    {
                        idx += num.Length;
                    }

                    if (num.Length == 0)
                    {
                        break;
                    }

                    // MD array bounds will be complete, so once we've encountered one array bound with a number we'll
                    // have a number for all of them.
                    if (outerCount == 0)
                    {
                        outerCount = 1;
                    }

                    outerCount *= int.Parse(num);
                } while (idx < cType.Length && cType[idx] == '[');
                idx = cType.LastIndexOf(']');
            }

            var prevSpan = cType[..idx];
            mutability[^++i] =
                !prevSpan.StartsWith("const ")
                && !prevSpan.Contains(" const ", StringComparison.Ordinal)
                && !prevSpan.EndsWith(" const");
            cType = cType[(idx + 1)..];
        }

        mutability[^++i] =
            !cType.StartsWith("const ")
            && !cType.Contains(" const ", StringComparison.Ordinal)
            && !cType.EndsWith(" const");
    }

    /// <summary>
    /// Gets the first matching metadata item for a specific symbol.
    /// </summary>
    /// <param name="metadataProviders">The metadata providers.</param>
    /// <param name="jobKey">The current job key.</param>
    /// <param name="parentSymbol">
    /// The parent symbol, optionally containing the symbol identified by <paramref name="childSymbol"/> if provided.
    /// Used as input to <see cref="IApiMetadataProvider{T}.TryGetChildSymbolMetadata"/> if
    /// <paramref name="childSymbol"/> is not <c>null</c>, <see cref="IApiMetadataProvider{T}.TryGetSymbolMetadata"/>
    /// otherwise.
    /// </param>
    /// <param name="childSymbol">
    /// The target symbol to get metadata for. If <c>null</c>, <paramref name="parentSymbol"/> represents the target
    /// symbol. Otherwise, this is used as input to <see cref="IApiMetadataProvider{T}.TryGetChildSymbolMetadata"/>.
    /// </param>
    /// <param name="filter">
    /// Filters the resolved metadata. If <c>null</c>, the first matching metadata item shall be used.
    /// </param>
    /// <param name="defaultValue">The value to return if no matching metadata was found.</param>
    /// <typeparam name="T">The type of the metadata.</typeparam>
    /// <returns>The metadata item.</returns>
    [return: NotNullIfNotNull(nameof(defaultValue))]
    public static T? GetMetadata<T>(
        this IEnumerable<IApiMetadataProvider<IEnumerable<T>>> metadataProviders,
        string? jobKey,
        string? parentSymbol = null,
        string? childSymbol = null,
        Predicate<T>? filter = default,
        T? defaultValue = default
    ) =>
        GetAllMetadata(metadataProviders, jobKey, parentSymbol, childSymbol, filter)
            .FirstOrDefault(defaultValue);

    /// <summary>
    /// Gets all matching metadata items for a specific symbol.
    /// </summary>
    /// <param name="metadataProviders">The metadata providers.</param>
    /// <param name="jobKey">The current job key.</param>
    /// <param name="parentSymbol">
    /// The parent symbol, optionally containing the symbol identified by <paramref name="childSymbol"/> if provided.
    /// Used as input to <see cref="IApiMetadataProvider{T}.TryGetChildSymbolMetadata"/> if
    /// <paramref name="childSymbol"/> is not <c>null</c>, <see cref="IApiMetadataProvider{T}.TryGetSymbolMetadata"/>
    /// otherwise.
    /// </param>
    /// <param name="childSymbol">
    /// The target symbol to get metadata for. If <c>null</c>, <paramref name="parentSymbol"/> represents the target
    /// symbol. Otherwise, this is used as input to <see cref="IApiMetadataProvider{T}.TryGetChildSymbolMetadata"/>.
    /// </param>
    /// <param name="filter">
    /// Filters the resolved metadata. If <c>null</c>, the first matching metadata item shall be used.
    /// </param>
    /// <typeparam name="T">The type of the metadata.</typeparam>
    /// <returns>The metadata item.</returns>
    public static IEnumerable<T?> GetAllMetadata<T>(
        this IEnumerable<IApiMetadataProvider<IEnumerable<T>>> metadataProviders,
        string? jobKey,
        string? parentSymbol = null,
        string? childSymbol = null,
        Predicate<T>? filter = default
    )
    {
        if (parentSymbol is null)
        {
            yield break;
        }

        filter ??= static _ => true;

        if (childSymbol is not null)
        {
            foreach (var provider in metadataProviders)
            {
                if (provider.TryGetChildSymbolMetadata(jobKey, parentSymbol, childSymbol, out var childMetadata))
                {
                    foreach (var child in childMetadata.Where(x => filter.Invoke(x)))
                    {
                        yield return child;
                    }
                }
            }
        }

        foreach (var provider in metadataProviders)
        {
            // parentMetadata.FirstOrDefault(x => x.Profile == Profile.Profile) ?? parent
            if (provider.TryGetSymbolMetadata(jobKey, parentSymbol, out var parentMetadata))
            {
                foreach (var parent in parentMetadata.Where(x => filter.Invoke(x)))
                {
                    yield return parent;
                }
            }
        }
    }

    /// <summary>
    /// Sets <paramref name="parentSymbol"/> to indicate that the type indicated by
    /// <paramref name="innerParentSymbol" /> is being recursed into. If <paramref name="parentSymbol" /> indicates that
    /// this is itself being done as part of a recursion (i.e. this is nested type symbol), the returned value shall
    /// denote that type qualification.
    /// </summary>
    /// <remarks>
    /// This is mostly just a helper method to reduce code duplication for the metadata symbol identifier format of
    /// <c>OuterClass.InnerClass</c> should ever it change in the future. It's very doubtful that'd happen, nonetheless
    /// this should be used if nothing else for code cleanliness.
    /// </remarks>
    /// <param name="parentSymbol">The current parent symbol identifier value.</param>
    /// <param name="innerParentSymbol">The parent symbol being recursed into.</param>
    /// <param name="oldValue">
    /// The old value, to restore as soon as <paramref name="innerParentSymbol"/> has been recursed into.
    /// </param>
    /// <returns>The new value for <paramref name="parentSymbol"/>.</returns>
    public static string? PushParentSymbolIdentifier(
        this string? parentSymbol,
        string innerParentSymbol,
        out string? oldValue
    ) =>
        (oldValue = parentSymbol) is not null
            ? $"{parentSymbol}.{innerParentSymbol}"
            : innerParentSymbol;

    /// <summary>
    /// Creates symbol constraints based on the given length and mutability data. No other properties are set.
    /// </summary>
    /// <param name="lengths">
    /// The lengths for each pointer indirection level. The last element is the innermost element type.
    /// </param>
    /// <param name="mutability">
    /// The mutability for each pointer indirection level. The last element is the innermost element type.
    /// </param>
    /// <param name="compSize">
    /// Whether the <paramref name="lengths"/> parameter is actually a list of names from which the size is computed,
    /// rather than being a length for each indirection level.
    /// </param>
    /// <param name="optional">Whether the parameter is optional.</param>
    /// <param name="outerCount">The static count of the outermost pointer dimension.</param>
    /// <returns>The symbol constraints.</returns>
    public static SymbolConstraints CreateBasicSymbolConstraints(
        ReadOnlySpan<string> lengths,
        ReadOnlySpan<bool> mutability,
        bool compSize,
        bool optional,
        int outerCount
    ) =>
        new(
            Usage:
            [
                new LogicalAnnotation<UsageConstraints>(
                    LogicalRequirement.Always,
                    null,
                    null,
                    null,
                    new UsageConstraints(
                        IsOptional: optional,
                        StaticCount: outerCount != 0
                        || (lengths.Length > 0 && int.TryParse(lengths[0], out outerCount))
                            ? outerCount
                            : 0,
                        CountExpression: outerCount == 0
                        && lengths.Length > 0
                        && lengths[0] != "null-terminated"
                            ? lengths[0]
                            : null,
                        IsNullTerminated: outerCount == 0
                            && lengths.Length > 0
                            && lengths[0] == "null-terminated"
                    )
                ),
            ],
            IsMutable: mutability[0],
            ComputedFromNames: compSize ? [.. lengths] : [],
            ElementTypeConstraints: mutability.Length > 1
                ? CreateBasicSymbolConstraints(
                    !compSize && lengths.Length > 1 ? lengths[1..] : [],
                    mutability[1..],
                    false,
                    false,
                    0
                )
                : null
        );

    /// <summary>
    /// Enumerates the symbol constraints for each parameter.
    /// </summary>
    /// <param name="decl">The method with the parameters to enumerate.</param>
    /// <param name="providers">The metadata providers.</param>
    /// <param name="entryPoint"></param>
    /// <param name="jobKey"></param>
    /// <returns></returns>
    public static IEnumerable<(
        ParameterSyntax Param,
        int ParamIdx,
        SymbolConstraints? ParamConstraints
    )> EnumerateSymbolConstraints(
        this MethodDeclarationSyntax decl,
        IEnumerable<IApiMetadataProvider<SymbolConstraints>> providers,
        string? entryPoint = null,
        string? jobKey = null
    )
    {
        if (entryPoint is null)
        {
            decl.AttributeLists.GetNativeFunctionInfo(out _, out entryPoint, out _);
            entryPoint ??= decl.Identifier.ToString();
        }
        return decl
            .ParameterList.Parameters.Select((y, j) => (PtrParam: y, PtrParamIdx: j))
            .Select(y =>
                (
                    y.PtrParam,
                    y.PtrParamIdx,
                    PtrParamConstraints: providers
                        .Select(z =>
                            z.TryGetChildSymbolMetadata(
                                jobKey,
                                entryPoint,
                                y.PtrParam.Identifier.ToString().TrimStart('@'),
                                out var md
                            )
                                ? md
                                : null
                        )
                        .FirstOrDefault()
                )
            );
    }

    /// <summary>
    /// Enumerates over each parameter in the given method declaration and gets the other parameters for which the
    /// parameter determines the element count.
    /// </summary>
    /// <param name="decl">The method declaration.</param>
    /// <param name="providers">The metadata providers.</param>
    /// <param name="entryPoint">The entry point. Determined from the declaration if not provided.</param>
    /// <param name="jobKey">The job key to use when looking up metadata.</param>
    /// <returns>
    /// An enumerable over the declaration's parameters, where the parameter syntax and indices are given along with an
    /// enumerable of the other parameter syntaxes (along with the indices and constraints) for which the parameter
    /// provides the element count.
    /// </returns>
    public static IEnumerable<(
        ParameterSyntax CountParam,
        int CountParamIdx,
        IEnumerable<(
            ParameterSyntax PtrParam,
            int PtrParamIdx,
            SymbolConstraints? PtrParamConstraints
        )> ParamsForCount
    )> EnumerateCountParameterInfo(
        this MethodDeclarationSyntax decl,
        IEnumerable<IApiMetadataProvider<SymbolConstraints>> providers,
        string? entryPoint = null,
        string? jobKey = null
    ) =>
        decl.ParameterList.Parameters.Select(
            (x, i) =>
                (
                    CountParam: x,
                    CountParamIdx: i,
                    ParamsForCount: decl.EnumerateSymbolConstraints(providers, entryPoint, jobKey)
                        .Where(y =>
                            y.ParamConstraints?.CommonUsage?.CountExpression.AsSpan()
                                .TrimStart('@')
                                .SequenceEqual(x.Identifier.ToString().AsSpan().TrimStart('@'))
                            ?? false
                        )
                )
        );

    internal static IEnumerable<AttributeArgumentSyntax> GetSupportedApiProfileAttributeArgs(
        this SupportedApiProfileAttribute args
    )
    {
        yield return AttributeArgument(
            LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(args.Profile))
        );

        if (args.ApiSets is not null)
        {
            yield return AttributeArgument(
                CollectionExpression(
                    SeparatedList<CollectionElementSyntax>(
                        args.ApiSets.Order()
                            .Select(x =>
                                ExpressionElement(
                                    LiteralExpression(
                                        SyntaxKind.StringLiteralExpression,
                                        Literal(x)
                                    )
                                )
                            )
                    )
                )
            );
        }

        if (args.MinVersion is not null)
        {
            yield return AttributeArgument(
                NameEquals(IdentifierName(nameof(args.MinVersion))),
                null,
                LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(args.MinVersion))
            );
        }

        if (args.MaxVersion is not null)
        {
            yield return AttributeArgument(
                NameEquals(IdentifierName(nameof(args.MaxVersion))),
                null,
                LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(args.MaxVersion))
            );
        }

        if (args.ImpliesSets is { Length: > 0 })
        {
            yield return AttributeArgument(
                NameEquals(IdentifierName(nameof(args.ImpliesSets))),
                null,
                CollectionExpression(
                    SeparatedList<CollectionElementSyntax>(
                        args.ImpliesSets.Order()
                            .Select(x =>
                                ExpressionElement(
                                    LiteralExpression(
                                        SyntaxKind.StringLiteralExpression,
                                        Literal(x)
                                    )
                                )
                            )
                    )
                )
            );
        }

        if (args.RequireAll)
        {
            yield return AttributeArgument(
                NameEquals(IdentifierName(nameof(args.RequireAll))),
                null,
                LiteralExpression(SyntaxKind.TrueLiteralExpression)
            );
        }
    }

    internal static AttributeSyntax GetSupportedApiProfileAttribute(
        this SupportedApiProfileAttribute args
    ) =>
        Attribute(
            IdentifierName("SupportedApiProfile"),
            AttributeArgumentList(SeparatedList(args.GetSupportedApiProfileAttributeArgs()))
        );
}
