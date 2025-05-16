using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Casts the arguments and return type of calls to the given function within the given node.
    /// </summary>
    /// <param name="node">The node in which to search for function calls.</param>
    /// <param name="callee">The callee.</param>
    /// <param name="castReturnType">The type to cast the return type of invocations to.</param>
    /// <param name="castParameterTypes">The types to cast each parameter with the given index to.</param>
    /// <returns>The rewritten syntax node.</returns>
    public static SyntaxNode CastFunctionCalls(
        this SyntaxNode node,
        MethodDeclarationSyntax callee,
        TypeSyntax? castReturnType = null,
        IReadOnlyList<(int Index, TypeSyntax CastType)>? castParameterTypes = null
    ) => new MethodCallRewriter(callee, castReturnType, castParameterTypes).Visit(node);

    /// <summary>
    /// Casts the arguments and return type of calls to the given function within the given node.
    /// </summary>
    /// <param name="node">The node in which to search for function calls.</param>
    /// <param name="callee">The callee.</param>
    /// <param name="newReturnType">The type to cast the return type of invocations to.</param>
    /// <param name="newParameters">
    /// The new parameters for which invocations will be cast to the parameter type where they differ.
    /// </param>
    /// <returns>The rewritten syntax node.</returns>
    public static SyntaxNode CastFunctionCalls(
        this SyntaxNode node,
        MethodDeclarationSyntax callee,
        TypeSyntax? newReturnType,
        IReadOnlyList<ParameterSyntax> newParameters
    )
    {
        var toRw = new List<(int, TypeSyntax)>();
        foreach (var newParam in newParameters)
        {
            for (var i = 0; i < callee.ParameterList.Parameters.Count; i++)
            {
                var param = callee.ParameterList.Parameters[i];
                if (
                    param.Identifier.ToString() == newParam.Identifier.ToString()
                    && param.Type?.ToString() != newParam.Type?.ToString()
                )
                {
                    toRw.Add(
                        (
                            i,
                            param.Type
                                ?? throw new InvalidOperationException("Parameter has no type.")
                        )
                    );
                }
            }
        }

        return node.CastFunctionCalls(callee, newReturnType, toRw);
    }

    class MethodCallRewriter(
        MethodDeclarationSyntax callee,
        TypeSyntax? castReturnType = null,
        IReadOnlyList<(int Index, TypeSyntax CastType)>? castParameterTypes = null
    ) : CSharpSyntaxRewriter
    {
        private int _castDepth;
        private TypeSyntax? _castTo;
        private int _argNo;

        public override SyntaxNode? VisitCastExpression(CastExpressionSyntax node)
        {
            _castDepth++;
            var ret = base.VisitCastExpression(node);
            if (
                --_castDepth == 0
                && _castTo is not null
                && ret is ExpressionSyntax expr
                && (expr is not CastExpressionSyntax ce || ce.Type.ToString() != _castTo.ToString())
            )
            {
                ret = CastExpression(_castTo, expr);
                _castTo = null;
            }

            return ret;
        }

        public override SyntaxNode? VisitArgument(ArgumentSyntax node)
        {
            var ret = base.VisitArgument(node);
            var argNo = _argNo++;
            if (ret is not ArgumentSyntax arg || castParameterTypes is null)
            {
                return ret;
            }

            foreach (var (idx, castTo) in castParameterTypes)
            {
                if (
                    idx == argNo
                    && (
                        arg.Expression is not CastExpressionSyntax ce
                        || ce.Type.ToString() != castTo.ToString()
                    )
                )
                {
                    return arg.WithExpression(CastExpression(castTo, arg.Expression));
                }
            }

            return ret;
        }

        public override SyntaxNode? VisitArgumentList(ArgumentListSyntax node)
        {
            // This is to handle patterns like Call(x, Call(y, z))
            // See the comment in VisitInvocationExpression for more
            var castDepthBefore = _castDepth;
            var argNoBefore = _argNo;
            _castDepth = 0;
            _argNo = 0;
            var ret = base.VisitArgumentList(node);
            _castDepth = castDepthBefore;
            _argNo = argNoBefore;
            return ret;
        }

        public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            if (
                (
                    node.Expression is MemberAccessExpressionSyntax mae
                        ? mae.Name as IdentifierNameSyntax
                        : node.Expression as IdentifierNameSyntax
                )
                    is not { } idn
                || idn.Identifier.ToString() != callee.Identifier.ToString()
                || node.ArgumentList.Arguments.Count != callee.ParameterList.Parameters.Count
            )
            {
                return base.VisitInvocationExpression(node);
            }

            // == CAST ORDER PRESERVATION ==
            // If the argument expression already contains casts, we assume that the desired argument cast applies after
            // any other existing expression. In the case of (ABC)Call(1, 2), we visit the ABC cast which increments the
            // _castDepth to 1, then we recurse into the invocation. We set _castTo to the return type cast we want on
            // exit in this function, and then that is evaluated on exit from VisitCastExpression. Lovely recursion.
            //
            // == CALLS WITHIN CALLS ==
            //
            // It is expected that casts are only applied after an entire invocation expression has been visited. That
            // is:
            //
            //                | reset when recursing into arguments
            //                v
            // 1    2    3    0     <-- _castDepth
            // v--- v--- v--- v----
            // (ABC)(XYZ)Call(x, y)
            //               ------^
            //               we do not set _castTo until we have finished evaluating the arguments
            //
            // Meaning that in the nesting case:
            //
            // 1    2    3    0  1    2    3    0    3 <-- _castDepth
            // v--- v--- v--- v- v--- v--- v--- v--- v
            // (ABC)(XYZ)Call(x, (ABC)(XYZ)Call(y, z))
            //                  ^                   |^-----------------------------------------------------+
            //                  |                   | (1) _castTo is set after arguments is evaluated      |
            //                  +-----<<<<<<<<<-----+                                                      |
            //              (2) applied and set to null                                                    |
            //              by the time we eval outer arg                                                  |
            //                                                                                             |
            //              (3) _castTo, still null here, -------------------------------------------------+
            //              will be set to the outer cast
            //
            // Note that the state is pushed onto the stack in VisitArgumentList, but the _castTo contract is expected
            // to be respected here and in VisitCastExpression.
            Debug.Assert(_castTo is null);
            var ret = base.VisitInvocationExpression(node);
            if (ret is not InvocationExpressionSyntax inv)
            {
                return ret;
            }

            if (_castDepth == 0 && castReturnType is not null)
            {
                ret = CastExpression(castReturnType, inv);
            }
            else
            {
                _castTo = castReturnType;
            }

            return ret;
        }
    }

    /// <summary>
    /// Get the element type for the given "pointer-like" type. That is (for example):
    /// <list type="bullet">
    /// <item><term>For <c>sbyte***</c>: </term><description><c>sbyte**</c></description></item>
    /// <item><term>For <c>Ptr2D&lt;sbyte&gt;</c>: </term><description><c>Ptr&lt;sbyte&gt;</c></description></item>
    /// <item><term>For <c>Ref&lt;sbyte&gt;</c>: </term><description><c>sbyte</c></description></item>
    /// </list>
    /// </summary>
    /// <param name="syn">The type syntax.</param>
    /// <returns>The element type. Null if the type is not a pointer.</returns>
    public static TypeSyntax? GetPointerLikeElementType(this TypeSyntax syn) =>
        syn switch
        {
            PointerTypeSyntax ptr => ptr.ElementType,
            GenericNameSyntax { TypeArgumentList.Arguments.Count: 1 } gn
                when gn.Identifier.ToString().AsSpan() is { Length: >= 3 } span
                    && span[..3] is "Ref" or "Ptr"
                    && (span.Length == 3 || span[^1] is 'D') => span.Length == 3
                ? gn.TypeArgumentList.Arguments[0]
            : byte.TryParse(span[3..^1], out var nd)
                ? gn.WithIdentifier(
                    nd <= 2 ? Identifier(span[..3].ToString()) : Identifier($"{span[..3]}{nd - 1}")
                )
            : null,
            _ => null,
        };
}
