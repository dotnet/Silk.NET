// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;

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
        public IReadOnlyList<string> GlobalPrefixHints { get; init; } = [];
    }

    /// <inheritdoc />
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var cfg = config.Get(ctx.JobKey);
        if (ctx.SourceProject is null)
        {
            return;
        }

        // Sort the hints from large to small
        // This makes it so that we prefer longer prefixes
        var hints = cfg.GlobalPrefixHints.ToList();
        hints.Sort((x, y) => -x.Length.CompareTo(y.Length));
        cfg = cfg with { GlobalPrefixHints = hints };

        // Gather all the names
        var visitor = new Visitor();
        foreach (var doc in ctx.SourceProject.Documents)
        {
            visitor.Visit(await doc.GetSyntaxRootAsync(ct));
        }

        // TODO
        Console.WriteLine();
    }

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
