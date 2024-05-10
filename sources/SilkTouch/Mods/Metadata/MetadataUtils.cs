// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
                outerCount = 1;
                do
                {
                    var num = cType[(idx + 1)..];
                    if (cType[(idx + 1)..].IndexOf(']') is not -1 and var j)
                    {
                        idx++;
                        num = num[..j];
                    }

                    idx += num.Length;
                    outerCount *= num.Length == 0 ? 0 : int.Parse(num);
                } while (cType[idx] == '[');
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
                )
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
        IEnumerable<IApiMetadataProvider> providers,
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
                            z.TryGetParameterMetadata(
                                jobKey,
                                entryPoint,
                                y.PtrParam.Identifier.ToString(),
                                out SymbolConstraints? md
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
        IEnumerable<IApiMetadataProvider> providers,
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
                            y.ParamConstraints?.CommonUsage?.CountExpression
                            == x.Identifier.ToString()
                        )
                )
        );
}
