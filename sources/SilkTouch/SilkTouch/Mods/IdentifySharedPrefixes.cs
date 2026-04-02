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
public class IdentifySharedPrefixes(IOptionsSnapshot<IdentifySharedPrefixes.Configuration> config)
    : Mod
{
    private static readonly HashSet<string> _forbiddenTrimmings = new() { "unsigned", "per" };

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
        if (ctx.SourceProject is null)
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
        foreach (var doc in ctx.SourceProject.Documents)
        {
            visitor.Visit(await doc.GetSyntaxRootAsync(ct));
        }

        // TODO
        Console.WriteLine();
    }

    /// <summary>
    /// Identifies shared prefixes and returns a dictionary mapping the member name to the identified prefix for that member.
    /// </summary>
    private Dictionary<string, string>? IdentifyPrefixes(
        string scope,
        List<string> members,
        HashSet<string> nonDeterminant,
        Configuration configuration
    )
    {
        // This was from the original NameTrimmer code
        // TODO: Document what each pass does
        const int nPasses = 3;

        List<TrimmingNames>? localNames = null;
        string? identifiedPrefix = null;
        var naive = false;
        {
            for (var i = 0; i < nPasses; i++) // try with both trimming name and non trimming name
            {
                // Attempt to identify the hint being used.
                string? hint = null;
                foreach (var candidateHint in configuration.GlobalPrefixHints)
                {
                    var match = true;
                    foreach (var member in members)
                    {
                        if (!member.StartsWith(candidateHint, StringComparison.OrdinalIgnoreCase))
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

        // If identifiedPrefix is null, we fall back to the hints. I know we've checked above whether this is the
        // obvious answer for a given pass, but if we've still got no possible prefix after all of the passes then this
        // is better than nothing - if the name doesn't start with the prefix we simply won't use the prefix.
        if (
            string.IsNullOrWhiteSpace(identifiedPrefix)
            && configuration.GlobalPrefixHints is not { Count: > 0 }
        )
        {
            return null;
        }

        var results = new Dictionary<string, string>();

        identifiedPrefix = identifiedPrefix?.Trim('_');
        foreach (var (originalName, trimmingName) in localNames!)
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

                var originalNameI = 0;
                var isPrefixTooLong = false;
                for (var candidateI = 0; candidateI < candidatePrefix.Length; candidateI++)
                {
                    if (originalNameI >= originalName.Length)
                    {
                        isPrefixTooLong = true;
                        break;
                    }

                    if (
                        char.ToLower(candidatePrefix[candidateI])
                        == char.ToLower(originalName[originalNameI])
                    )
                    {
                        originalNameI++;
                        continue;
                    }

                    if (candidatePrefix[candidateI] == '_')
                    {
                        originalNameI++;
                    }
                }

                if (isPrefixTooLong)
                {
                    continue;
                }

                // Output prefix to results
                results.Add(originalName, originalName[..originalNameI]);
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
    /// Just match the start of the strings, don't bother checking for obvious name separation gaps.
    /// </param>
    /// <returns>
    /// Null to skip this scope outright, empty if no prefix was found, or the prefix otherwise.
    /// <para/>
    /// A local names list is also returned.
    /// This is the list of names to be used for the remainder of the trimming process
    /// and contains the trimming name and original name.
    /// </returns>
    private (string Prefix, List<TrimmingNames>)? GetPrefix(
        string? scope,
        List<string> members,
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

        if (string.IsNullOrWhiteSpace(scope))
        {
            scope = null;
        }

        // Get the trimming names
        var scopeTrimmingName = useTrimmingName
            ? GetTrimmingName(prefixOverrides, scope ?? hint ?? string.Empty, hint)
            : scope ?? hint ?? string.Empty;

        var localNames = members
            .Select(member => new TrimmingNames(
                member,
                useTrimmingName ? GetTrimmingName(prefixOverrides, member, hint) : member
            ))
            .ToList();

        // Set the prefix to the prefix override for this scope, if it exists.
        // This is to allow us to handle poorly/inconsistently named scopes,
        // without putting special cases elsewhere in the logic
        // ex: For the enum
        //     enum Things {
        //       ThingsRGB
        //       ThingRGB
        //     }
        // If we specify a prefix override of "Thing",
        // then it will trim ThingsRGB to sRGB and ThingRGB to RGB
        // a case like this is simple to add a special case for in the generator to handle sRGB specially,
        // but see ImageChannelOrder from spirv.h for a more problematic occurrence.
        string prefix;
        if (scope is not null && prefixOverrides.TryGetValue(scope, out var @override))
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
                            members.First(member => !(nonDeterminant?.Contains(member) ?? false)),
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
                        .Where(x => !(nonDeterminant?.Contains(x.OriginalName) ?? false))
                        .Select(x => x.TrimmingName)
                        .ToList(),
                    // If naive mode is on and we're trimming type names, allow full matches (method class is
                    // probably the prefix)
                    naive && scope is null,
                    false,
                    naive
                );
            }
        }

        // If any of the children's trimming name is shorter than the prefix length,
        if (
            localNames.Any(x =>
                x.TrimmingName.Length <= prefix.Length
                && !(nonDeterminant?.Contains(x.OriginalName) ?? false)
            ) && !string.IsNullOrWhiteSpace(scopeTrimmingName)
        )
        {
            // Do a second pass, but put the scope name in the loop to see if it makes a difference
            prefix = NameUtils.FindCommonPrefix(
                localNames.Select(x => x.TrimmingName).Append(scopeTrimmingName).ToList(),
                // If naive mode is on and we're trimming type names, allow full matches (method class is probably the
                // prefix)
                naive && scope is null,
                false,
                naive
            );
        }

        // Iterate through all of the forbidden trimmings,
        foreach (var word in _forbiddenTrimmings)
        {
            // If the prefix starts with a forbidden trimming,
            if (prefix.StartsWith($"{word}_"))
            {
                // Clear the prefix
                prefix = string.Empty;
            }

            // If the prefix contains the forbidden trimming surrounded by underscores,
            var idx = prefix.IndexOf($"_{word}_", StringComparison.OrdinalIgnoreCase);
            if (idx != -1)
            {
                // Trim the end of the prefix to the start of the forbidden trimming
                // ex:
                //     input prefix = THIS_GL_
                //     forbidden trimming = GL
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

    /// <summary>
    /// Similar to <see cref="CandidateNames"/>, but with some additional information.
    /// </summary>
    /// <param name="OriginalName">The original, unmodified name.</param>
    /// <param name="TrimmingName">The name used for trimming purposes.</param>
    private readonly record struct TrimmingNames(string OriginalName, string TrimmingName)
    {
        /// <summary>
        /// Formats this instance as a string.
        /// </summary>
        public override string ToString() => $"(Original={OriginalName}, Trimming={TrimmingName})";
    }

    // TODO: Need to also store affixes
    private class Visitor : CSharpSyntaxWalker
    {
        /// <summary>
        /// A mapping from scope names to their member names.
        /// These only represent names that need to have their prefixes determined.
        /// </summary>
        public Dictionary<string, List<string>> Scopes { get; } = new();

        /// <summary>
        /// A set of type names marked with the [Transformed] attribute.
        /// </summary>
        /// <remarks>
        /// These are not used for prefix determination since they can contain identifiers that
        /// are not part of the original source code.
        /// </remarks>
        public HashSet<string> NonDeterminant { get; } = [];

        private BaseTypeDeclarationSyntax? scope = null;

        private void ReportName(SyntaxToken scope, SyntaxToken member)
        {
            var scopeName = scope.ToString();
            if (!Scopes.TryGetValue(scopeName, out var members))
            {
                Scopes[scopeName] = members = [];
            }

            members.Add(member.ToString());
        }

        private void TryReportNonDeterminant(
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxToken identifier
        )
        {
            if (attributeLists.ContainsAttribute("Silk.NET.Core.Transformed"))
            {
                NonDeterminant.Add(identifier.ToString());
            }
        }

        // ----- Types -----

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            ReportName(default, node.Identifier);
            TryReportNonDeterminant(node.AttributeLists, node.Identifier);

            scope = node;
            foreach (var member in node.Members)
            {
                Visit(member);
            }
            scope = null;
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            ReportName(default, node.Identifier);
            TryReportNonDeterminant(node.AttributeLists, node.Identifier);

            scope = node;
            foreach (var member in node.Members)
            {
                Visit(member);
            }
            scope = null;
        }

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            ReportName(default, node.Identifier);
            TryReportNonDeterminant(node.AttributeLists, node.Identifier);

            scope = node;
            foreach (var member in node.Members)
            {
                Visit(member);
            }
            scope = null;
        }

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node) { }

        // ----- Members -----

        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            ReportName(scope!.Identifier, node.Identifier);
            TryReportNonDeterminant(node.AttributeLists, node.Identifier);
        }

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

            foreach (var variable in node.Declaration.Variables)
            {
                ReportName(scope!.Identifier, variable.Identifier);
                TryReportNonDeterminant(node.AttributeLists, variable.Identifier);
            }
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            // Struct methods are introduced by the generator so we skip them
            // Otherwise, it's likely a C function
            if (scope.IsKind(SyntaxKind.StructDeclaration))
            {
                return;
            }

            ReportName(scope!.Identifier, node.Identifier);
            TryReportNonDeterminant(node.AttributeLists, node.Identifier);
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

            ReportName(scope!.Identifier, node.Identifier);
            TryReportNonDeterminant(node.AttributeLists, node.Identifier);
        }
    }
}
