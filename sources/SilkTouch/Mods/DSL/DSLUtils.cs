using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.DSL;

/// <summary>
/// Utilities for implementing the Silk DSL.
/// </summary>
public static class DSLUtils
{
    /// <summary>
    /// Replaces the identifiers in the given syntax node.
    /// </summary>
    /// <param name="syn">The syntax node.</param>
    /// <param name="reassignments">The replacements.</param>
    /// <returns>The new syntax node.</returns>
    public static SyntaxNode ReplaceIdentifiers(
        this SyntaxNode syn,
        IReadOnlyDictionary<string, string> reassignments
    ) => new IdentifierRewriter(reassignments).Visit(syn);

    /// <summary>
    /// Wraps the given statement in a fixed statement. This removes a tiny bit of boilerplate to ensure that fixed
    /// statements are chained.
    /// </summary>
    /// <param name="syn">The statement.</param>
    /// <param name="factory">Creates the fixed statement.</param>
    /// <returns>Fixed statement.</returns>
    public static FixedStatementSyntax AddFixed(
        this SyntaxList<StatementSyntax> syn,
        Func<StatementSyntax, FixedStatementSyntax> factory
    ) => factory(syn is [FixedStatementSyntax] ? syn[0] : Block(syn));

    class IdentifierRewriter(IReadOnlyDictionary<string, string> reassignments)
        : CSharpSyntaxRewriter(true)
    {
        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node) =>
            reassignments.TryGetValue(node.Identifier.ToString(), out var s)
                ? node.WithIdentifier(Identifier(s))
                : node;
    }
}
