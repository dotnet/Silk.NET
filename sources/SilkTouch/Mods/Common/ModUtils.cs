using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Common utilities useful to mods.
/// </summary>
public static class ModUtils
{
    /// <summary>
    /// Converts a namespace string into an <see cref="NameSyntax"/>.
    /// </summary>
    /// <param name="ns">The namespace string.</param>
    /// <returns>The <see cref="NameSyntax"/> representing this namespace.</returns>
    public static NameSyntax NamespaceIntoIdentifierName(ReadOnlySpan<char> ns)
    {
        var idx = ns.LastIndexOf('.');
        if (idx == -1)
        {
            return IdentifierName(ns.ToString());
        }

        return QualifiedName(
            NamespaceIntoIdentifierName(ns[..idx]),
            IdentifierName(ns[(idx + 1)..].ToString())
        );
    }

    /// <summary>
    /// Gets the namespace in which a syntax node is contained. This is transitive, so nested namespace declarations
    /// will be accounted for.
    /// </summary>
    /// <param name="node">The syntax node.</param>
    /// <returns>The namespace.</returns>
    public static string NamespaceFromSyntaxNode(this SyntaxNode node) =>
        string.Join(
            '.',
            node.Ancestors()
                .OfType<BaseNamespaceDeclarationSyntax>()
                .Reverse()
                .Select(x => x.Name.ToString())
        );

    /// <summary>
    /// Matches a potential replacement candidate against the given list of regex-replacement mappings and, if a regex
    /// matches, performs a group substitution on the replacement to replace the match.
    /// </summary>
    /// <param name="mappings">
    /// Regex-to-replacement mappings. The replacements can have group references that will get substituted in (e.g.
    /// <c>"Silk.NET.$1</c>)
    /// </param>
    /// <param name="candidate">The string to run the replacement on.</param>
    /// <returns>The replaced string. It may not have been modified at all.</returns>
    public static string GroupedRegexReplace(
        IEnumerable<(Regex Regex, string Replacement)> mappings,
        string candidate
    )
    {
        foreach (var (regex, replacement) in mappings)
        {
            var match = regex.Match(candidate);
            if (!match.Success)
            {
                continue;
            }

            candidate = replacement;
            for (var i = 0; i < match.Groups.Count; i++)
            {
                candidate = candidate.Replace($"${i}", match.Groups[i].Value);
            }
        }

        return candidate;
    }

    /// <summary>
    /// Gets a string that can be used to discriminate a type for baking purposes.
    /// </summary>
    /// <param name="toks">Tokens e.g. ref, in, out.</param>
    /// <param name="type">The type syntax.</param>
    /// <returns>The discriminator string.</returns>
    public static string DiscrimStr(SyntaxTokenList toks, TypeSyntax? type) =>
        toks.Any(x =>
            x.Kind() is SyntaxKind.RefKeyword or SyntaxKind.InKeyword or SyntaxKind.OutKeyword
        )
            ? $"{type}&"
            : type?.ToString() ?? string.Empty;

    /// <summary>
    /// Gets a string that can be used to discriminate a function-like element for baking purposes.
    /// </summary>
    /// <param name="modifiers">The modifiers on the function.</param>
    /// <param name="tParams">The type parameters.</param>
    /// <param name="identifier">The name of the function.</param>
    /// <param name="params">The parameters of the function.</param>
    /// <param name="returnType">The return type of the function.</param>
    /// <returns>The discriminator string.</returns>
    public static string DiscrimStr(
        SyntaxTokenList modifiers,
        TypeParameterListSyntax? tParams,
        string identifier,
        ParameterListSyntax? @params,
        TypeSyntax? returnType
    ) =>
        (modifiers.Any(SyntaxKind.StaticKeyword) ? "static " : string.Empty)
        + $"{DiscrimStr(modifiers, returnType)} {identifier}{tParams}"
        + $"({string.Join(", ", @params?.Parameters.Select(DiscrimStr) ?? Enumerable.Empty<string>())})";

    /// <summary>
    /// Gets a string that can be used to discriminate a single parameter.
    /// </summary>
    /// <param name="param">The parameter.</param>
    /// <returns>The discriminator string.</returns>
    public static string DiscrimStr(ParameterSyntax param) =>
        DiscrimStr(param.Modifiers, param.Type);

    /// <summary>
    /// Changes the identifier of a method while taking into account any <see cref="DllImportAttribute"/>s the method
    /// may have.
    /// </summary>
    /// <param name="node">The original method.</param>
    /// <param name="newIdentifier">The new identifier.</param>
    /// <returns>The modified method.</returns>
    public static MethodDeclarationSyntax WithIdentifierForImport(
        this MethodDeclarationSyntax node,
        SyntaxToken newIdentifier
    ) =>
        node.WithIdentifier(newIdentifier)
            .WithAttributeLists(
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
    /// Gets the "effective name" of a given file name. That is, the path without its extension but with any dot
    /// suffixes that begin with a capital letter and therefore are conceivably part of the effective file name.
    /// </summary>
    /// <param name="fullKey">The full path.</param>
    /// <param name="effectiveName">The effective name within <paramref name="fullKey"/>.</param>
    /// <param name="directory">The directory within <paramref name="fullKey"/>.</param>
    /// <param name="remainder">The trailing characters after <paramref name="effectiveName"/>.</param>
    public static void GetEffectiveName(
        this ReadOnlySpan<char> fullKey,
        out ReadOnlySpan<char> effectiveName,
        out ReadOnlySpan<char> directory,
        out ReadOnlySpan<char> remainder
    )
    {
        directory = Path.GetDirectoryName(fullKey);
        effectiveName = fullKey[directory.Length..];
        while (effectiveName[0] is '/' or '\\')
        {
            directory = fullKey[..(directory.Length + 1)];
            effectiveName = effectiveName[1..];
        }

        // effective name of GL.gen.cs is GL but effective name of something like GL.Manual.cs or GL.Interfaces.gen.cs
        // is GL.Manual or GL.Interfaces respectively
        remainder = default;
        while (effectiveName.LastIndexOf('.') is not -1 and var lastIdx)
        {
            if (char.IsUpper(effectiveName[lastIdx + 1]))
            {
                break;
            }

            remainder = fullKey[(directory.Length + lastIdx)..];
            effectiveName = effectiveName[..lastIdx];
        }
    }

    /// <summary>
    /// Gets the "effective name" of a given file name. That is, the path without its extension but with any dot
    /// suffixes that begin with a capital letter and therefore are conceivably part of the effective file name.
    /// </summary>
    /// <param name="fullKey">The full path.</param>
    /// <returns>The effective name.</returns>
    public static ReadOnlySpan<char> GetEffectiveName(this ReadOnlySpan<char> fullKey)
    {
        fullKey.GetEffectiveName(out var ret, out _, out _);
        return ret;
    }

    /// <summary>
    /// Adds a suffix to the effective name contained within the given path, and returns the full path with the suffix
    /// added.
    /// </summary>
    /// <param name="fullKey">The full path.</param>
    /// <param name="suffix">The suffix.</param>
    /// <returns></returns>
    public static string AddEffectiveSuffix(
        this ReadOnlySpan<char> fullKey,
        ReadOnlySpan<char> suffix
    )
    {
        fullKey.GetEffectiveName(out var effectiveName, out var directory, out var remainder);
        return $"{directory}{effectiveName}.{suffix}{remainder}";
    }

    /// <summary>
    /// Reconstructs the <see cref="PInvokeGeneratorConfigurationOptions"/> from the given
    /// <see cref="PInvokeGeneratorConfiguration"/> because this is a PITA to do manually.
    /// </summary>
    /// <param name="cfg">The ClangSharp config.</param>
    /// <returns>The options contained within.</returns>
    public static PInvokeGeneratorConfigurationOptions ReconstructOptions(
        this PInvokeGeneratorConfiguration cfg
    )
    {
        var options = PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.DontUseUsingStaticsForEnums
            ? PInvokeGeneratorConfigurationOptions.DontUseUsingStaticsForEnums
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeAnonymousFieldHelpers
            ? PInvokeGeneratorConfigurationOptions.ExcludeAnonymousFieldHelpers
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeComProxies
            ? PInvokeGeneratorConfigurationOptions.ExcludeComProxies
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeEmptyRecords
            ? PInvokeGeneratorConfigurationOptions.ExcludeEmptyRecords
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeEnumOperators
            ? PInvokeGeneratorConfigurationOptions.ExcludeEnumOperators
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeFnptrCodegen
            ? PInvokeGeneratorConfigurationOptions.ExcludeFnptrCodegen
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeFunctionsWithBody
            ? PInvokeGeneratorConfigurationOptions.ExcludeFunctionsWithBody
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeNIntCodegen
            ? PInvokeGeneratorConfigurationOptions.ExcludeNIntCodegen
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateAggressiveInlining
            ? PInvokeGeneratorConfigurationOptions.GenerateAggressiveInlining
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateCompatibleCode
            ? PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateCppAttributes
            ? PInvokeGeneratorConfigurationOptions.GenerateCppAttributes
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateDocIncludes
            ? PInvokeGeneratorConfigurationOptions.GenerateDocIncludes
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateExplicitVtbls
            ? PInvokeGeneratorConfigurationOptions.GenerateExplicitVtbls
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateFileScopedNamespaces
            ? PInvokeGeneratorConfigurationOptions.GenerateFileScopedNamespaces
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateGuidMember
            ? PInvokeGeneratorConfigurationOptions.GenerateGuidMember
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateHelperTypes
            ? PInvokeGeneratorConfigurationOptions.GenerateHelperTypes
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateLatestCode
            ? PInvokeGeneratorConfigurationOptions.GenerateLatestCode
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateMacroBindings
            ? PInvokeGeneratorConfigurationOptions.GenerateMacroBindings
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateMarkerInterfaces
            ? PInvokeGeneratorConfigurationOptions.GenerateMarkerInterfaces
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateMultipleFiles
            ? PInvokeGeneratorConfigurationOptions.GenerateMultipleFiles
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateNativeBitfieldAttribute
            ? PInvokeGeneratorConfigurationOptions.GenerateNativeBitfieldAttribute
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateNativeInheritanceAttribute
            ? PInvokeGeneratorConfigurationOptions.GenerateNativeInheritanceAttribute
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GeneratePreviewCode
            ? PInvokeGeneratorConfigurationOptions.GeneratePreviewCode
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateSetsLastSystemErrorAttribute
            ? PInvokeGeneratorConfigurationOptions.GenerateSetsLastSystemErrorAttribute
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateSourceLocationAttribute
            ? PInvokeGeneratorConfigurationOptions.GenerateSourceLocationAttribute
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateTemplateBindings
            ? PInvokeGeneratorConfigurationOptions.GenerateTemplateBindings
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateTestsNUnit
            ? PInvokeGeneratorConfigurationOptions.GenerateTestsNUnit
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateTestsXUnit
            ? PInvokeGeneratorConfigurationOptions.GenerateTestsXUnit
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateTrimmableVtbls
            ? PInvokeGeneratorConfigurationOptions.GenerateTrimmableVtbls
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateUnixTypes
            ? PInvokeGeneratorConfigurationOptions.GenerateUnixTypes
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateUnmanagedConstants
            ? PInvokeGeneratorConfigurationOptions.GenerateUnmanagedConstants
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateVtblIndexAttribute
            ? PInvokeGeneratorConfigurationOptions.GenerateVtblIndexAttribute
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.LogExclusions
            ? PInvokeGeneratorConfigurationOptions.LogExclusions
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.LogPotentialTypedefRemappings
            ? PInvokeGeneratorConfigurationOptions.LogPotentialTypedefRemappings
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.LogVisitedFiles
            ? PInvokeGeneratorConfigurationOptions.LogVisitedFiles
            : PInvokeGeneratorConfigurationOptions.None;
        if ((options & PInvokeGeneratorConfigurationOptions.GeneratePreviewCode) != 0)
        {
            options &= ~PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
            options &= ~PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
        }
        if ((options & PInvokeGeneratorConfigurationOptions.GenerateLatestCode) != 0)
        {
            options &= ~PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
            options &= ~PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
        }
        if ((options & PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode) != 0)
        {
            options &= ~PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
            options &= ~PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
        }
        return options;
    }

    /// <summary>
    /// Determines (naively) whether the given attribute syntax represents a <see cref="DllImportAttribute"/>.
    /// </summary>
    /// <param name="node">The attribute syntax.</param>
    /// <param name="fullNameWithoutSuffix">
    /// The fully-qualified attribute name including the namespace but without the <c>Attribute</c> suffix.
    /// </param>
    /// <returns>Whether it is probably a DllImport.</returns>
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
                                                .WithNameEquals(NameEquals("EntryPoint"))
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
