// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Identifies shared prefixes,
/// such as namespace prefixes (eg: vk, gl)
/// and enum constant prefixes (eg: VK_ACCESS).
/// <para/>
/// These are identified as [NameAffix] attributes that
/// <see cref="PrettifyNames"/> and other mods can then process further.
/// </summary>
[ModConfiguration<Configuration>]
public class IdentifySharedPrefixes(IOptionsSnapshot<IdentifySharedPrefixes.Configuration> config)
    : Mod
{
    /// <summary>
    /// This was from the original NameTrimmer code
    /// Referencing the original documentation:
    /// The second pass does not use <see cref="GetTrimmingName"/>.
    /// The third pass uses naive prefix detection for <see cref="GetPrefix"/>.
    /// </summary>
    /// <remarks>
    /// This documentation should be expanded to explain the reasoning for each pass.
    /// </remarks>
    private const int _passCount = 3;

    /// <summary>
    /// Strings that are not allowed to be part of the final prefix.
    /// </summary>
    private static readonly HashSet<string> _forbiddenPrefixes = new() { "unsigned", "per" };

    /// <summary>
    /// The configuration for the <see cref="IdentifySharedPrefixes"/> mod.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// Corrections to the automatic prefix determination.
        /// </summary>
        public Dictionary<string, string> PrefixOverrides { get; init; } = [];

        /// <summary>
        /// A list of known prefixes that are commonly used by names in the native API.
        /// These are preferred when identifying shared prefixes.
        /// </summary>
        public List<string> GlobalPrefixHints { get; init; } = [];
    }

    /// <inheritdoc />
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var configuration = config.Get(ctx.JobKey);
        var project = ctx.SourceProject;
        if (project is null)
        {
            return;
        }

        // Sort the hints from large to small
        // This makes it so that we prefer longer prefixes
        var hints = configuration.GlobalPrefixHints.ToList();
        hints.Sort((x, y) => -x.Length.CompareTo(y.Length));
        configuration = configuration with { GlobalPrefixHints = hints };

        // Gather all the names
        var visitor = new Visitor();
        foreach (var doc in project.Documents)
        {
            visitor.Visit(await doc.GetSyntaxRootAsync(ct));
        }

        // Identify shared prefixes
        var results = new Dictionary<string, Dictionary<string, string>>();
        foreach (var (scope, members) in visitor.Scopes)
        {
            var prefixes = IdentifyPrefixes(scope, members, visitor.NonDeterminant, configuration);
            if (prefixes == null)
            {
                continue;
            }

            results.Add(scope, prefixes);
        }

        // Output results as NameAffix attributes
        var rewriter = new Rewriter(results);
        foreach (var documentId in project.DocumentIds)
        {
            var document = project.GetDocument(documentId);
            if (document == null)
            {
                continue;
            }

            var syntaxRoot = await document.GetSyntaxRootAsync(ct);
            if (syntaxRoot == null)
            {
                continue;
            }

            project = document.WithSyntaxRoot(rewriter.Visit(syntaxRoot)).Project;
        }

        ctx.SourceProject = project;
    }

    /// <summary>
    /// Identifies shared prefixes and returns a dictionary mapping the member name to the identified prefix for that member.
    /// </summary>
    private Dictionary<string, string>? IdentifyPrefixes(
        string scope,
        List<MemberName> members,
        HashSet<string> nonDeterminant,
        Configuration configuration
    )
    {
        List<TrimmingNames>? localNames = null;
        string? identifiedPrefix = null;
        var naive = false;
        {
            for (var i = 0; i < _passCount; i++) // try with both trimming name and non trimming name
            {
                // Attempt to identify the hint being used.
                string? hint = null;
                foreach (var candidateHint in configuration.GlobalPrefixHints)
                {
                    var match = true;
                    foreach (var member in members)
                    {
                        if (
                            !member.UnaffixedName.StartsWith(
                                candidateHint,
                                StringComparison.OrdinalIgnoreCase
                            )
                        )
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        hint = candidateHint;
                        break;
                    }
                }

                var result = GetPrefix(
                    scope,
                    members,
                    configuration.PrefixOverrides,
                    nonDeterminant,
                    hint,
                    useTrimmingName: i == 0,
                    naive: naive = i == 2
                );

                if (result is null)
                {
                    // skip outright.
                    return null;
                }

                (identifiedPrefix, localNames) = result.Value;

                // If we have found a prefix,
                if (
                    identifiedPrefix.Length > 0
                    && identifiedPrefix.Length < localNames.Min(x => x.TrimmingName.Length)
                )
                {
                    // break and use it for trimming!
                    break;
                }

                // If not, do most of them at least start with the hint?
                if (
                    hint is null
                    || localNames.Count(x =>
                        x.TrimmingName.StartsWith(hint, StringComparison.OrdinalIgnoreCase)
                    )
                        >= localNames.Count / 2
                )
                {
                    // Nope, nothing we can do it seems, we've already tried both trimming name and non trimming name...
                    continue;
                }

                // The prefix is the hint!
                identifiedPrefix = hint;
                naive = true;
                break;
            }
        }

        // If identifiedPrefix is null, we fall back to the hints.
        // I know we've checked above whether this is the obvious answer for a given pass,
        // but if we've still got no possible prefix after all the passes, then this is better than nothing.
        // If the name doesn't start with the prefix, we simply won't use the prefix.
        if (
            string.IsNullOrWhiteSpace(identifiedPrefix)
            && configuration.GlobalPrefixHints is not { Count: > 0 }
        )
        {
            return null;
        }

        var results = new Dictionary<string, string>();

        identifiedPrefix = identifiedPrefix?.Trim('_');
        foreach (var (originalName, unaffixedName, trimmingName) in localNames!)
        {
            ReadOnlySpan<string> candidatePrefixes = !string.IsNullOrWhiteSpace(identifiedPrefix)
                ? [identifiedPrefix] // Otherwise we fall back to the hints
                : configuration.GlobalPrefixHints.AsSpan();

            foreach (var candidatePrefix in candidatePrefixes)
            {
                if (
                    naive
                    && (
                        candidatePrefix.Length >= trimmingName.Length
                        || !trimmingName.StartsWith(
                            candidatePrefix,
                            StringComparison.OrdinalIgnoreCase
                        )
                    )
                )
                {
                    continue;
                }

                var unaffixedNameI = 0;
                var isPrefixTooLong = false;
                foreach (var c in candidatePrefix)
                {
                    if (unaffixedNameI >= unaffixedName.Length)
                    {
                        isPrefixTooLong = true;
                        break;
                    }

                    if (char.ToLower(c) == char.ToLower(unaffixedName[unaffixedNameI]))
                    {
                        unaffixedNameI++;
                        continue;
                    }

                    if (c == '_')
                    {
                        unaffixedNameI++;
                    }
                }

                if (isPrefixTooLong)
                {
                    continue;
                }

                // Output prefix to results
                results[originalName] = unaffixedName[..unaffixedNameI];
                break;
            }
        }

        if (results.Count == 0)
        {
            return null;
        }

        return results;
    }

    /// <summary>
    /// Gets the prefix for the given constituents of the given scope.
    /// </summary>
    /// <param name="scope">The scope name if applicable.</param>
    /// <param name="members">The names to get a prefix for.</param>
    /// <param name="prefixOverrides">Prefix overrides.</param>
    /// <param name="nonDeterminant">List of names that should not be used for prefix determination.</param>
    /// <param name="hint">The global prefix hint if applicable.</param>
    /// <param name="useTrimmingName">
    /// Whether to use <see cref="GetTrimmingName"/> or to use the native name as-is.
    /// </param>
    /// <param name="naive">
    /// Just match the start of the strings; don't bother checking for obvious name separation gaps.
    /// </param>
    /// <returns>
    /// Null to skip this scope outright, empty if no prefix was found, or the prefix otherwise.
    /// <para/>
    /// A local names list is also returned.
    /// This is the list of names to be used for the remainder of the trimming process.
    /// </returns>
    private (string Prefix, List<TrimmingNames>)? GetPrefix(
        string scope,
        List<MemberName> members,
        Dictionary<string, string> prefixOverrides,
        HashSet<string>? nonDeterminant,
        string? hint,
        bool useTrimmingName,
        bool naive
    )
    {
        // If the type has no members,
        if (members.Count == 0)
        {
            // skip it
            return null;
        }

        // Get the trimming names
        var rawScopeTrimmingName =
            (string.IsNullOrWhiteSpace(scope) ? null : scope) ?? hint ?? string.Empty;
        var scopeTrimmingName = useTrimmingName
            ? GetTrimmingName(prefixOverrides, rawScopeTrimmingName, hint)
            : rawScopeTrimmingName;

        var localNames = members
            .Select(member => new TrimmingNames(
                member.OriginalName,
                member.UnaffixedName,
                useTrimmingName
                    ? GetTrimmingName(prefixOverrides, member.UnaffixedName, hint)
                    : member.UnaffixedName
            ))
            .ToList();

        // Set the prefix to the prefix override for this scope, if it exists.
        // This is to allow us to handle poorly/inconsistently named scopes,
        // without putting special cases elsewhere in the logic
        // ex: For the enum:
        //     enum Things {
        //       ThingsRGB
        //       ThingRGB
        //     }
        // If we specify a prefix override of "Thing",
        // then it will trim ThingsRGB to sRGB and ThingRGB to RGB
        // a case like this is simple to add a special case for in the generator to handle sRGB specially,
        // but see ImageChannelOrder from spirv.h for a more problematic occurrence.
        string prefix;
        if (prefixOverrides.TryGetValue(scope, out var @override))
        {
            // Use the override
            prefix = @override;
        }
        else
        {
            if (members.Count == 1)
            {
                if (!string.IsNullOrWhiteSpace(scopeTrimmingName))
                {
                    // Use the member name and its scope.
                    prefix = NameUtils.FindCommonPrefix(
                        [
                            members
                                .First(member =>
                                    !(nonDeterminant?.Contains(member.UnaffixedName) ?? false)
                                )
                                .UnaffixedName,
                            scopeTrimmingName,
                        ],
                        true,
                        false,
                        naive
                    );
                }
                else
                {
                    // One name. Can't determine prefix.
                    prefix = "";
                }
            }
            else
            {
                // Common case - Find the prefix based on the scope's members
                prefix = NameUtils.FindCommonPrefix(
                    localNames
                        .Where(x => !(nonDeterminant?.Contains(x.UnaffixedName) ?? false))
                        .Select(x => x.TrimmingName)
                        .ToList(),
                    // If naive mode is on and we're trimming type names, allow full matches (method class is
                    // probably the prefix)
                    naive && scope == "",
                    false,
                    naive
                );
            }
        }

        // If any of the children's trimming name is shorter than the prefix length,
        if (
            localNames.Any(x =>
                x.TrimmingName.Length <= prefix.Length
                && !(nonDeterminant?.Contains(x.UnaffixedName) ?? false)
            ) && !string.IsNullOrWhiteSpace(scopeTrimmingName)
        )
        {
            // Do a second pass, but put the scope name in the loop to see if it makes a difference
            prefix = NameUtils.FindCommonPrefix(
                localNames.Select(x => x.TrimmingName).Append(scopeTrimmingName).ToList(),
                // If naive mode is on and we're trimming type names, allow full matches (method class is probably the
                // prefix)
                naive && scope == "",
                false,
                naive
            );
        }

        // Prevent certain strings from being part of the final prefix
        foreach (var word in _forbiddenPrefixes)
        {
            // If the prefix starts with a forbidden prefix
            if (prefix.StartsWith($"{word}_"))
            {
                // Clear the prefix
                prefix = string.Empty;
            }

            // If the prefix contains the forbidden trimming surrounded by underscores
            var idx = prefix.IndexOf($"_{word}_", StringComparison.OrdinalIgnoreCase);
            if (idx != -1)
            {
                // Trim the end of the prefix to the start of the forbidden prefix
                // ex:
                //     input prefix = THIS_GL_
                //     forbidden prefix = GL
                //
                //     resulting prefix = THIS
                prefix = prefix[..idx];
            }
        }

        return (prefix, localNames);
    }

    /// <summary>
    /// Gets the name to feed into <see cref="NameUtils"/>.
    /// </summary>
    /// <param name="prefixOverrides">The prefix overrides.</param>
    /// <param name="name">The name to get a trimming name for.</param>
    /// <param name="hint">The global prefix hint.</param>
    /// <returns>The trimming name.</returns>
    private string GetTrimmingName(
        Dictionary<string, string> prefixOverrides,
        string name,
        string? hint = null
    )
    {
        // If there's a prefix override for this enum,
        if (prefixOverrides.ContainsKey(name))
        {
            // Use the raw native name as the trimming name
            return name;
        }

        if (hint is not null && name.StartsWith(hint, StringComparison.OrdinalIgnoreCase))
        {
            return NameSplitter.Underscore($"{hint}_{name[hint.Length..]}");
        }

        return NameSplitter.Underscore(name);
    }

    /// <param name="OriginalName">The name as it exists in source code.</param>
    /// <param name="UnaffixedName">The original name with affixes stripped.</param>
    private readonly record struct MemberName(string OriginalName, string UnaffixedName);

    /// <param name="OriginalName">The name as it exists in source code.</param>
    /// <param name="UnaffixedName">The original name with affixes stripped.</param>
    /// <param name="TrimmingName">The unaffixed name as a trimming name. See <see cref="GetTrimmingName"/>.</param>
    private readonly record struct TrimmingNames(
        string OriginalName,
        string UnaffixedName,
        string TrimmingName
    )
    {
        public override string ToString() =>
            $"(Unaffixed={UnaffixedName}, Trimming={TrimmingName})";
    }

    private class Visitor : CSharpSyntaxWalker
    {
        /// <summary>
        /// A mapping from scope names to their member names.
        /// These only represent names that need to have their prefixes determined.
        /// </summary>
        public Dictionary<string, List<MemberName>> Scopes { get; } = new();

        /// <summary>
        /// A set of type names marked with the [Transformed] attribute.
        /// </summary>
        /// <remarks>
        /// These are not used for prefix determination since they can contain identifiers that
        /// are not part of the original source code.
        /// </remarks>
        public HashSet<string> NonDeterminant { get; } = [];

        private BaseTypeDeclarationSyntax? _scope = null;

        private void ReportName(
            SyntaxToken memberIdentifier,
            SyntaxList<AttributeListSyntax> memberAttributeLists
        )
        {
            var scopeName = _scope?.Identifier.ToString() ?? "";
            var memberName = memberIdentifier.ToString();

            if (memberAttributeLists.ContainsAttribute("Silk.NET.Core.Transformed"))
            {
                NonDeterminant.Add(memberName);
            }

            if (!Scopes.TryGetValue(scopeName, out var members))
            {
                Scopes[scopeName] = members = [];
            }

            var nameAffixes = memberAttributeLists.GetNameAffixes();
            var unaffixedMemberName = NameAffixer.StripAffixes(memberName, nameAffixes);
            members.Add(new MemberName(memberName, unaffixedMemberName));
        }

        // ----- Types -----

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            ReportName(node.Identifier, node.AttributeLists);

            var previousScope = _scope;
            _scope = node;
            foreach (var member in node.Members)
            {
                Visit(member);
            }
            _scope = previousScope;
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            ReportName(node.Identifier, node.AttributeLists);

            var previousScope = _scope;
            _scope = node;
            foreach (var member in node.Members)
            {
                Visit(member);
            }
            _scope = previousScope;
        }

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            ReportName(node.Identifier, node.AttributeLists);

            var previousScope = _scope;
            _scope = node;
            foreach (var member in node.Members)
            {
                Visit(member);
            }
            _scope = previousScope;
        }

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            ReportName(node.Identifier, node.AttributeLists);

        // ----- Members -----

        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) =>
            ReportName(node.Identifier, node.AttributeLists);

        // Only supports single variable fields
        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            // If the node is not a constant, skip it
            // Otherwise, it's likely a C constant
            if (
                !node.Modifiers.Any(SyntaxKind.ConstKeyword)
                && !node.Modifiers.Any(SyntaxKind.StaticKeyword)
            )
            {
                return;
            }

            var firstVariable = node.Declaration.Variables.First();
            ReportName(firstVariable.Identifier, node.AttributeLists);
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            // Struct methods are introduced by the generator so we skip them
            // Otherwise, it's likely a C function
            if (_scope.IsKind(SyntaxKind.StructDeclaration))
            {
                return;
            }

            ReportName(node.Identifier, node.AttributeLists);
        }

        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            // If the node is not a constant, skip it
            // Otherwise, it's likely a C constant (often strings)
            var hasSetter =
                node.AccessorList?.Accessors.Any(a =>
                    a.IsKind(SyntaxKind.SetAccessorDeclaration)
                    || a.IsKind(SyntaxKind.InitAccessorDeclaration)
                ) ?? false;

            if (hasSetter)
            {
                return;
            }

            ReportName(node.Identifier, node.AttributeLists);
        }
    }

    /// <param name="results">ScopeName -> (MemberName -> MemberPrefix)</param>
    private class Rewriter(Dictionary<string, Dictionary<string, string>> results)
        : CSharpSyntaxRewriter
    {
        private BaseTypeDeclarationSyntax? _scope = null;

        private SyntaxList<AttributeListSyntax> RewriteAttributes(
            SyntaxToken memberIdentifier,
            SyntaxList<AttributeListSyntax> memberAttributeLists
        )
        {
            var scopeName = _scope?.Identifier.ToString() ?? "";
            if (!results.TryGetValue(scopeName, out var scopePrefixes))
            {
                return memberAttributeLists;
            }

            if (!scopePrefixes.TryGetValue(memberIdentifier.ToString(), out var prefix))
            {
                return memberAttributeLists;
            }

            return memberAttributeLists.AddNameAffix(
                NameAffixType.Prefix,
                "SharedPrefix",
                prefix,
                true
            );
        }

        // ----- Types -----

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            node = node.WithAttributeLists(RewriteAttributes(node.Identifier, node.AttributeLists));

            var previousScope = _scope;
            _scope = node;
            node = node.WithMembers(
                [.. node.Members.Select(member => (MemberDeclarationSyntax)Visit(member))]
            );
            _scope = previousScope;

            return node;
        }

        public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
        {
            node = node.WithAttributeLists(RewriteAttributes(node.Identifier, node.AttributeLists));

            var previousScope = _scope;
            _scope = node;
            node = node.WithMembers(
                [.. node.Members.Select(member => (MemberDeclarationSyntax)Visit(member))]
            );
            _scope = previousScope;

            return node;
        }

        public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            node = node.WithAttributeLists(RewriteAttributes(node.Identifier, node.AttributeLists));

            var previousScope = _scope;
            _scope = node;
            node = node.WithMembers(
                [.. node.Members.Select(member => (EnumMemberDeclarationSyntax)Visit(member))]
            );
            _scope = previousScope;

            return node;
        }

        public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            node.WithAttributeLists(RewriteAttributes(node.Identifier, node.AttributeLists));

        // ----- Members -----

        public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) =>
            node.WithAttributeLists(RewriteAttributes(node.Identifier, node.AttributeLists));

        // Only supports single variable fields
        public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node) =>
            node.WithAttributeLists(
                RewriteAttributes(
                    node.Declaration.Variables.First().Identifier,
                    node.AttributeLists
                )
            );

        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            node.WithAttributeLists(RewriteAttributes(node.Identifier, node.AttributeLists));

        public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node) =>
            node.WithAttributeLists(RewriteAttributes(node.Identifier, node.AttributeLists));
    }
}
