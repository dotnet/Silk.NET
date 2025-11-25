using System.Diagnostics;
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
    /// Gets the namespace in which a symbol is contained.
    /// </summary>
    /// <param name="symbol">The symbol.</param>
    /// <returns>The namespace.</returns>
    public static string NamespaceFromSymbol(this ISymbol? symbol) =>
        symbol is INamespaceSymbol
            ? NamespaceFromSymbol(symbol.ContainingNamespace) is { Length: > 0 } parent
                ? $"{parent}.{symbol.Name}"
                : symbol.Name
            // ReSharper disable once TailRecursiveCall <-- this is more code than we need
            : symbol?.ContainingNamespace is not null
                ? NamespaceFromSymbol(symbol.ContainingNamespace)
                : string.Empty;

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
    public static string DiscrimStr(SyntaxTokenList? toks, TypeSyntax? type) =>
        toks?.Any(x =>
            x.Kind() is SyntaxKind.RefKeyword or SyntaxKind.InKeyword or SyntaxKind.OutKeyword
        ) ?? false
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
        SyntaxTokenList? modifiers,
        TypeParameterListSyntax? tParams,
        ReadOnlySpan<char> identifier,
        IEnumerable<BaseParameterSyntax>? @params,
        TypeSyntax? returnType
    ) =>
        (modifiers?.Any(SyntaxKind.StaticKeyword) ?? false ? "static " : string.Empty)
        + $"{DiscrimStr(modifiers, returnType)} {identifier}{tParams}"
        + $"({string.Join(", ", @params?.Select(DiscrimStr) ?? Enumerable.Empty<string>())})";

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
        SyntaxTokenList? modifiers,
        TypeParameterListSyntax? tParams,
        ReadOnlySpan<char> identifier,
        BaseParameterListSyntax? @params,
        TypeSyntax? returnType
    ) => DiscrimStr(modifiers, tParams, identifier, @params?.Parameters, returnType);

    /// <summary>
    /// Gets a string that can be used to discriminate a single parameter.
    /// </summary>
    /// <param name="param">The parameter.</param>
    /// <returns>The discriminator string.</returns>
    public static string DiscrimStr(BaseParameterSyntax param) =>
        DiscrimStr(param.Modifiers, param.Type);

    /// <summary>
    /// Gets the relative path for this document.
    /// </summary>
    /// <param name="doc">The document.</param>
    /// <returns>The relative path.</returns>
    public static string? RelativePath(this Document doc)
    {
        if (
            doc.FilePath is null
            || doc.Project.FilePath is null
            || Path.GetDirectoryName(doc.Project.FilePath) is not { Length: > 0 } dir
        )
        {
            return default;
        }

        var ret = Path.GetRelativePath(dir, doc.FilePath);
        return ret.StartsWith("..") ? default : ret.Replace('\\', '/').Trim('/');
    }

    /// <summary>
    /// Converts a relative path into a full path for a project.
    /// </summary>
    /// <param name="proj">The project.</param>
    /// <param name="relativePath">The relative path.</param>
    /// <returns>The full path. Upon failure, null is returned.</returns>
    public static string FullPath(this Project proj, string relativePath) =>
        Path.GetDirectoryName(proj.FilePath) is { Length: > 0 } dir
            ? Path.GetFullPath(relativePath, dir)
            : relativePath;

    /// <summary>
    /// Searches and replaces all occurrences of the <paramref name="oldValue"/> with the <paramref name="newValue"/> in the document name and project *relative* file path.
    /// </summary>
    public static Document ReplaceNameAndPath(this Document document, string oldValue, string newValue)
    {
        document = document.WithName(document.Name.Replace(oldValue, newValue));

        var relativePath = document.RelativePath();
        if (relativePath != null)
        {
            document = document.WithFilePath(FullPath(document.Project, relativePath.Replace(oldValue, newValue)));
        }

        return document;
    }

    /// <summary>
    /// Gets the new <see cref="ISymbol"/> matching the given old <see cref="ISymbol"/> in a new
    /// <see cref="Compilation"/>. This is useful for maintaining context after a mutating operation e.g. for getting a
    /// new type symbol instance after a rename operation.
    /// </summary>
    /// <param name="newCompilation">The new compilation.</param>
    /// <param name="oldSymbol">The symbol in the old compilation.</param>
    /// <param name="newName">The new <see cref="ISymbol.Name"/> of the symbol, if changed.</param>
    /// <returns>The new symbol.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldSymbol"/> was not part of the <see cref="Compilation"/> it was originally sourced from (i.e.
    /// it is a reference of a foreign type or otherwise did not have an <see cref="ISourceAssemblySymbol"/> ancestor).
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// <paramref name="oldSymbol"/> or one of its ancestors did not have a matching symbol in
    /// <paramref name="newCompilation"/>.
    /// </exception>
    public static ISymbol GetNewSymbol(
        this Compilation newCompilation,
        ISymbol oldSymbol,
        string? newName = null
    )
    {
        // Get all of the symbols we need to find.
        // This is "reversed" because the last item of the path we need to follow comes first.
        var oldPathReversed = oldSymbol.AncestorsAndSelf().ToArray();
        if (oldPathReversed[^1] is not ISourceAssemblySymbol)
        {
            throw new ArgumentException(
                "The given symbol was not part of the assembly represented by the Compilation i.e. it does not "
                    + "have ISourceAssemblySymbol as an ancestor.",
                nameof(oldSymbol)
            );
        }

        // Start from the compilation's assembly and walk down.
        var expectedEndMdName = newName is null
            ? oldSymbol.MetadataName
            : oldSymbol.MetadataName.Replace(oldSymbol.Name, newName);
        ISymbol current = newCompilation.Assembly;
        Debug.Assert(current is ISourceAssemblySymbol);

        // ------------------------------------vvv-------------- because we're skipping the source assembly.
        for (var i = oldPathReversed.Length - 2; i >= 0; i--)
        {
            var currentOld = oldPathReversed[i];
            var expectedMdName = i == 0 ? expectedEndMdName : currentOld.MetadataName;
            current =
                current.Members().FirstOrDefault(x => x.MetadataName == expectedMdName)
                ?? throw new InvalidOperationException($"Could not find \"{expectedMdName}\".");
        }

        return current;
    }

    private static IEnumerable<ISymbol> AncestorsAndSelf(this ISymbol sym)
    {
        do
        {
            yield return sym;
        } while ((sym = sym!.ContainingSymbol!) is not null);
    }

    /// <summary>
    /// Enumerates the members of the given symbol.
    /// </summary>
    /// <param name="sym">The symbol.</param>
    /// <returns>The member symbols.</returns>
    public static IEnumerable<ISymbol> Members(this ISymbol sym) =>
        sym switch
        {
            IAssemblySymbol assemblySymbol => assemblySymbol.Modules,
            IModuleSymbol moduleSymbol => [moduleSymbol.GlobalNamespace],
            INamespaceOrTypeSymbol namespaceOrTypeSymbol => namespaceOrTypeSymbol.GetMembers(),
            _ => [],
        };

    private static IEnumerable<ISymbol> Descendants(this ISymbol sym) =>
        sym.Members().SelectMany(x => x.Descendants());

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
    /// Determines whether this is a <see cref="PredefinedTypeSyntax"/> representing an integral type.
    /// </summary>
    /// <param name="syn">The type to check.</param>
    /// <returns>Whether it's an integer.</returns>
    public static bool IsInteger(this TypeSyntax syn) =>
        (syn as PredefinedTypeSyntax)?.Keyword.Kind()
            is SyntaxKind.ULongKeyword
                or SyntaxKind.LongKeyword
                or SyntaxKind.UIntKeyword
                or SyntaxKind.IntKeyword
                or SyntaxKind.UShortKeyword
                or SyntaxKind.ShortKeyword
                or SyntaxKind.ByteKeyword
                or SyntaxKind.SByteKeyword;

    /// <summary>
    /// Gets all of the identifiers within the given identifiable member syntax.
    /// </summary>
    /// <param name="syn">The member with the identifiers.</param>
    /// <returns>The identifiers.</returns>
    public static IEnumerable<string> MemberIdentifiers(this MemberDeclarationSyntax syn) =>
        syn switch
        {
            BaseFieldDeclarationSyntax fld => fld.Declaration.Variables.Select(x =>
                x.Identifier.ToString()
            ),
            MethodDeclarationSyntax meth => [meth.Identifier.ToString()],
            BaseNamespaceDeclarationSyntax nsd => [nsd.Name.ToString()],
            EventDeclarationSyntax ev => [ev.Identifier.ToString()],
            PropertyDeclarationSyntax prop => [prop.Identifier.ToString()],
            BaseTypeDeclarationSyntax typ => [typ.Identifier.ToString()],
            DelegateDeclarationSyntax del => [del.Identifier.ToString()],
            EnumMemberDeclarationSyntax em => [em.Identifier.ToString()],
            _ => [],
        };
}
