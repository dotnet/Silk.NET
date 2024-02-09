using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.DSL;

/// <summary>
/// Contains utilities for actioning <see cref="IFunctionTransformer"/>s.
/// </summary>
/// <param name="transformers">The function transformers.</param>
public class FunctionTransformer(IEnumerable<IFunctionTransformer> transformers)
{
    /// <summary>
    /// Transforms all of the given functions, optionally including the original function signatures in the returned
    /// transformed functions.
    /// </summary>
    /// <param name="functions">The functions.</param>
    /// <param name="ctx">The wider context for this function transformation operation.</param>
    /// <param name="includeOriginal">
    /// Whether to include the original function in the outputs before the transformed ones.
    /// </param>
    /// <returns>The transformed (and optionally original) functions.</returns>
    public IEnumerable<MethodDeclarationSyntax> GetTransformedFunctions(
        IEnumerable<MethodDeclarationSyntax> functions,
        ITransformationContext ctx,
        bool includeOriginal = true
    )
    {
        var ret = functions is IReadOnlyCollection<MethodDeclarationSyntax> coll
            ? new List<MethodDeclarationSyntax>(coll.Count)
            : [];
        var transform = transformers.Aggregate<
            IFunctionTransformer,
            Action<MethodDeclarationSyntax>
        >(meth => ret.Add(meth), (c, t) => meth => t.Transform(meth, ctx, c));
        foreach (var function in functions)
        {
            var idx = ret.Count;
            ret.Remove(GetTransformedFunctions(function, transform));
            if (
                includeOriginal
                && !ret.Any(
                    x =>
                        x.ParameterList.Parameters.Select(y => y.Type?.ToString())
                            .SequenceEqual(
                                function.ParameterList.Parameters.Select(y => y.Type?.ToString())
                            )
                )
            )
            {
                ret.Insert(idx, function);
            }
            else
            {
                ret.Remove(function);
            }
        }

        return ret;
    }

    private MethodDeclarationSyntax GetTransformedFunctions(
        MethodDeclarationSyntax function,
        Action<MethodDeclarationSyntax> transform
    )
    {
        if (function.ExplicitInterfaceSpecifier is not null)
        {
            return function;
        }

        // The Silk DSL can be applied to the following:
        // - Methods, static or otherwise, where the containing class does not have an API interface
        //   - This usually means that the UseSilkDSL mods precedes the AddVTables mod and that the transformed
        //     functions will be extracted out to the interface as part of the latter mod.
        // - Static and non-static API interface methods
        // - Struct methods
        var staticFn = function.Modifiers.Any(x => x.IsKind(SyntaxKind.StaticKeyword));
        var declTy = function.FirstAncestorOrSelf<BaseTypeDeclarationSyntax>();
        var aai = FindNativeMemberContainerAttr(
            declTy?.AttributeLists.Where(x => x.Target is null).SelectMany(x => x.Attributes)
                ?? Enumerable.Empty<AttributeSyntax>(),
            staticFn
        );
        StatementSyntax? impl = null;
        if (declTy is ClassDeclarationSyntax or StructDeclarationSyntax && aai.Length == 0)
        {
            impl = ExpressionStatement(InvocationExpression(IdentifierName(function.Identifier)));
        }
        else if (
            declTy is InterfaceDeclarationSyntax ifd
            && aai.SequenceEqual(declTy.Identifier.ToString())
        )
        {
            var argList = ArgumentList(
                SeparatedList(
                    function.ParameterList.Parameters.Select(
                        x => Argument(IdentifierName(x.Identifier))
                    )
                )
            );
            // If it's static, it needs to have TSelf type parameter
            impl =
                staticFn
                && ifd.TypeParameterList?.Parameters is { Count: 1 } tPs
                && ifd.ConstraintClauses.Any(
                    x =>
                        x.Name.ToString() == tPs[0].Identifier.ToString()
                        && x.Constraints.Any(
                            y =>
                                y is TypeConstraintSyntax tc
                                && tc.Type.ToString() == $"{declTy.Identifier}<{tPs[0].Identifier}>"
                        )
                )
                    ? ExpressionStatement(
                        InvocationExpression(
                            MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                IdentifierName(aai.ToString()),
                                IdentifierName(function.Identifier)
                            ),
                            argList
                        )
                    )
                    : staticFn
                        ? null
                        : ExpressionStatement(
                            InvocationExpression(IdentifierName(function.Identifier), argList)
                        );
        }

        if (impl is null)
        {
            return function;
        }

        if (function.ParameterList.ToString() != "void")
        {
            impl = ReturnStatement(((ExpressionStatementSyntax)impl).Expression);
        }

        function = function
            .WithBody(Block(impl))
            .WithAttributeLists(
                // Add all the original attributes back, including the DllImport but make sure that if the original
                // DllImport is ExactSpelling we add an EntryPoint instead (given that we're changing the function
                // name)
                List(
                    (
                        function.AttributeLists.GetNativeFunctionInfo(out _, out var ep, out _)
                            ? function.AttributeLists.Select(
                                x =>
                                    x.WithAttributes(
                                        SeparatedList(
                                            x.Attributes.Select(
                                                y =>
                                                    y.IsAttribute(
                                                        "System.Runtime.InteropServices.DllImport"
                                                    )
                                                        ? y.WithArgumentList(
                                                            AttributeArgumentList(
                                                                SeparatedList<AttributeArgumentSyntax>(
                                                                    y.ArgumentList?.Arguments
                                                                        .Select(
                                                                            z =>
                                                                                z.NameEquals?.Name.Identifier.ToString()
                                                                                == nameof(
                                                                                    DllImportAttribute.EntryPoint
                                                                                )
                                                                                    ? null
                                                                                    : z
                                                                        )
                                                                        .Where(z => z is not null)
                                                                        .Concat(
                                                                            Enumerable.Repeat(
                                                                                AttributeArgument(
                                                                                        LiteralExpression(
                                                                                            SyntaxKind.StringLiteralExpression,
                                                                                            Literal(
                                                                                                ep
                                                                                                    // ReSharper disable once AccessToModifiedClosure
                                                                                                    ?? function.Identifier.ToString()
                                                                                            )
                                                                                        )
                                                                                    )
                                                                                    .WithNameEquals(
                                                                                        NameEquals(
                                                                                            IdentifierName(
                                                                                                nameof(
                                                                                                    DllImportAttribute.EntryPoint
                                                                                                )
                                                                                            )
                                                                                        )
                                                                                    ),
                                                                                1
                                                                            )
                                                                        )!
                                                                )
                                                            )
                                                        )
                                                        : y
                                            )
                                        )
                                    )
                            )
                            : function.AttributeLists
                    ).Concat(
                        Enumerable.Repeat(
                            AttributeList(
                                SingletonSeparatedList(Attribute(IdentifierName("Transformed")))
                            ),
                            1
                        )
                    )
                )
            )
            .WithExpressionBody(null)
            .WithSemicolonToken(default)
            .WithModifiers(
                TokenList(
                    function
                        .Modifiers.Where(x => !x.IsKind(SyntaxKind.ExternKeyword))
                        .Select(
                            x =>
                                x.IsKind(SyntaxKind.AbstractKeyword)
                                    ? Token(SyntaxKind.VirtualKeyword)
                                    : x
                        )
                )
            );

        transform(function);
        return function;
    }

    private static ReadOnlySpan<char> FindNativeMemberContainerAttr(
        IEnumerable<AttributeSyntax> attrs,
        bool staticInterface
    )
    {
        foreach (var attr in attrs)
        {
            if (attr.IsAttribute("Silk.NET.Core.NativeMemberContainer"))
            {
                // If it's a static interface, default to false as we need an explicit Static = true
                var shouldRet = !staticInterface;
                if (attr.ArgumentList is not { Arguments.Count: >= 1 })
                {
                    continue;
                }

                foreach (var arg in attr.ArgumentList.Arguments)
                {
                    if (arg.NameEquals?.Name.ToString() == "Static")
                    {
                        shouldRet = arg.Expression.IsKind(
                            staticInterface
                                ? SyntaxKind.TrueLiteralExpression
                                : SyntaxKind.FalseLiteralExpression
                        );
                        break;
                    }
                }

                if (
                    shouldRet
                    && attr.ArgumentList!.Arguments[0].Expression
                        is TypeOfExpressionSyntax { Type: { } ity }
                )
                {
                    var ret = ity.ToString().AsSpan();
                    if (ret.IndexOf('<') is > 0 and var idx)
                    {
                        if (!staticInterface)
                        {
                            continue;
                        }

                        ret = ret[..idx];
                    }
                    else if (staticInterface)
                    {
                        continue;
                    }

                    return ret;
                }
            }
        }

        return default;
    }
}
