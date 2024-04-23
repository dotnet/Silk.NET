using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// Utilities for implementing the Silk DSL.
/// </summary>
public static class TransformationUtils
{
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

    class IdentifierRewriter(IReadOnlyDictionary<string, string> reassignments)
        : CSharpSyntaxRewriter(true)
    {
        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node) =>
            reassignments.TryGetValue(node.Identifier.ToString(), out var s)
                ? node.WithIdentifier(Identifier(s))
                : node;
    }

    /// <summary>
    /// Casts the parameters of calls to the given callee to the callee's parameter types where the caller type differs.
    /// </summary>
    /// <param name="node">The syntax node to replace calls in.</param>
    /// <param name="callee">The original function signature.</param>
    /// <param name="caller">The calling method signature.</param>
    /// <returns>The modified node.</returns>
    /// <remarks>
    /// The caller and callee must have an identical number of parameters and identical identifiers.
    /// </remarks>
    public static SyntaxNode CastTransformeeCalls(
        this SyntaxNode node,
        MethodDeclarationSyntax callee,
        MethodDeclarationSyntax caller
    )
    {
        if (
            caller.Identifier.ToString() != callee.Identifier.ToString()
            || caller.ParameterList.Parameters.Count != callee.ParameterList.Parameters.Count
        )
        {
            throw new ArgumentException(
                "Caller and callee must share the same identifier and number of parameters."
            );
        }

        return new MethodCallRewriter(caller, callee).Visit(node);
    }

    class MethodCallRewriter(MethodDeclarationSyntax caller, MethodDeclarationSyntax callee)
        : CSharpSyntaxRewriter
    {
        private int _castDepth;
        private TypeSyntax? _castTo;

        public override SyntaxNode? VisitCastExpression(CastExpressionSyntax node)
        {
            _castDepth++;
            var ret = base.VisitCastExpression(node);
            if (--_castDepth == 0 && _castTo is not null && ret is ExpressionSyntax expr)
            {
                return CastExpression(_castTo, expr);
            }
            return ret;
        }

        public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            var ret = base.VisitInvocationExpression(node);
            if (ret is not InvocationExpressionSyntax inv)
            {
                return ret;
            }

            if (
                (
                    inv.Expression is MemberAccessExpressionSyntax mae
                        ? mae.Name as IdentifierNameSyntax
                        : inv.Expression as IdentifierNameSyntax
                )
                    is { } idn
                && idn.Identifier.ToString() == callee.Identifier.ToString()
                && inv.ArgumentList.Arguments.Count == callee.ParameterList.Parameters.Count
            )
            {
                inv = inv.WithArgumentList(
                    inv.ArgumentList.WithArguments(
                        SeparatedList(
                            inv.ArgumentList.Arguments.Select(
                                (x, i) =>
                                    callee.ParameterList.Parameters[i].Type is { } ty
                                    && ty.ToString() is { Length: > 0 } tyStr
                                    && tyStr != caller.ParameterList.Parameters[i].Type?.ToString()
                                    && (
                                        x.Expression is not CastExpressionSyntax ce
                                        || ce.Type.ToString() != tyStr
                                    )
                                        ? x.WithExpression(CastExpression(ty, x.Expression))
                                        : x
                            )
                        )
                    )
                );

                if (callee.ReturnType.ToString() != caller.ReturnType.ToString())
                {
                    // Preserve cast order - lazily apply the cast if we have to.
                    if (_castDepth == 0)
                    {
                        return CastExpression(caller.ReturnType, inv);
                    }

                    _castTo = caller.ReturnType;
                }
            }

            return inv;
        }
    }
}
