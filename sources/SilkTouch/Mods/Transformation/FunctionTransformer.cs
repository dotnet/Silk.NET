using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// Contains utilities for actioning <see cref="IFunctionTransformer"/>s.
/// </summary>
/// <param name="transformers">The function transformers.</param>
/// <param name="logger">The logger.</param>
public class FunctionTransformer(
    IEnumerable<IJobDependency<IFunctionTransformer>> transformers,
    ILogger<FunctionTransformer> logger
)
{
    /// <summary>
    /// Transforms all of the given functions, optionally including the original function signatures in the returned
    /// transformed functions.
    /// </summary>
    /// <param name="key">The job key.</param>
    /// <param name="functions">The functions.</param>
    /// <param name="ctx">The wider context for this function transformation operation.</param>
    /// <param name="includeOriginal">
    /// Whether to include the original function in the outputs before the transformed ones.
    /// </param>
    /// <returns>The transformed (and optionally original) functions.</returns>
    public IEnumerable<MethodDeclarationSyntax> GetTransformedFunctions(
        string? key,
        IEnumerable<MethodDeclarationSyntax> functions,
        ITransformationContext ctx,
        bool includeOriginal = true
    )
    {
        var ret = functions is IReadOnlyCollection<MethodDeclarationSyntax> coll
            ? new List<MethodDeclarationSyntax>(coll.Count)
            : [];
        var discrims = new HashSet<string>();

        // Aggregate all the transformers into one delegate
        var transform = transformers
            .SelectMany(x => x.Get(key))
            .Aggregate<IFunctionTransformer, Action<MethodDeclarationSyntax>>(
                meth =>
                {
                    // Get the discriminator string to determine whether it conflicts. Note that we set the return type
                    // to null as overloads that differ only by return type aren't acceptable. However, we do need a
                    // discriminator that does include the return type so we can determine whether the function has gone
                    // through the transformation pipeline completely unmodified.
                    var discrim = ModUtils.DiscrimStr(
                        meth.Modifiers,
                        meth.TypeParameterList,
                        meth.Identifier.ToString(),
                        meth.ParameterList,
                        returnType: null
                    );
                    var discrimWithRet = ModUtils.DiscrimStr(
                        meth.Modifiers,
                        meth.TypeParameterList,
                        meth.Identifier.ToString(),
                        meth.ParameterList,
                        meth.ReturnType
                    );

                    // Only add it if it's an overload that does not conflict.
                    if (discrims.Add(discrimWithRet) && discrims.Add(discrim))
                    {
                        // Small fixup to convert to use expression bodies where possible
                        if (
                            meth.ExpressionBody is null
                            && meth.Body?.Statements.FirstOrDefault()
                                is ReturnStatementSyntax { Expression: { } expr }
                        )
                        {
                            meth = meth.WithBody(null)
                                .WithExpressionBody(ArrowExpressionClause(expr))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
                        }
                        ret.Add(meth);
                    }
                    // TODO else warn maybe?
                },
                (c, t) => meth => t.Transform(meth, ctx, c)
            );
        foreach (var function in functions)
        {
            // Get the discriminator string to determine whether it conflicts. Note that we set the return type
            // to null as overloads that differ only by return type aren't acceptable. However, we do need a
            // discriminator that does include the return type so we can determine whether the function has gone
            // through the transformation pipeline completely unmodified.
            var discrim = ModUtils.DiscrimStr(
                function.Modifiers,
                function.TypeParameterList,
                function.Identifier.ToString(),
                function.ParameterList,
                returnType: null
            );
            var discrimWithRet = ModUtils.DiscrimStr(
                function.Modifiers,
                function.TypeParameterList,
                function.Identifier.ToString(),
                function.ParameterList,
                function.ReturnType
            );
            var idx = ret.Count;

            // Add the discriminator to the hash set to prevent unmodified functions from being output as transformed
            // ones. We might remove it later.
            if (!discrims.Add(discrimWithRet))
            {
                logger.LogWarning("Failed to add discriminator for original function \"{}\" because a previous transformed or original function conflicts with it. This may cause inconsistencies in outputs.", discrim);
            }

            if (TransformFunctions(function, transform) is not null && includeOriginal)
            {
                // Try to add the original function as-is
                if (discrims.Add(discrim))
                {
                    ret.Insert(idx, function);
                }
                else
                {
                    // Sometimes when functions are transformed they only differ by return type. C# doesn't allow
                    // this, so we add a suffix to the original function to differentiate them.
                    var newIden = $"{function.Identifier}Raw";
                    var rep = new Dictionary<string, string>
                    {
                        { function.Identifier.ToString(), newIden }
                    };

                    // Any reference to the original function needs to be replaced as well.
                    foreach (ref var added in CollectionsMarshal.AsSpan(ret)[idx..])
                    {
                        added = (MethodDeclarationSyntax)added.ReplaceIdentifiers(rep);
                    }

                    // Add the suffixed function
                    var newFun = function.WithIdentifierForImport(Identifier(newIden));
                    discrim = ModUtils.DiscrimStr(
                        function.Modifiers,
                        function.TypeParameterList,
                        newIden,
                        function.ParameterList,
                        returnType: null
                    );
                    if (discrims.Add(discrim))
                    {
                        ret.Insert(idx, newFun);
                    }
                }
            }
        }

        return ret;
    }

    private MethodDeclarationSyntax? TransformFunctions(
        MethodDeclarationSyntax function,
        Action<MethodDeclarationSyntax> transform
    )
    {
        if (function.ExplicitInterfaceSpecifier is not null)
        {
            return null;
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
        var argList = ArgumentList(
            SeparatedList(
                function.ParameterList.Parameters.Select(x =>
                    Argument(IdentifierName(x.Identifier))
                )
            )
        );

        // If it's a simple case of transforming a class or struct method, then we can just call into the function
        // without any extra shenanigans
        if (declTy is ClassDeclarationSyntax or StructDeclarationSyntax && aai.Length == 0)
        {
            impl = ExpressionStatement(
                InvocationExpression(IdentifierName(function.Identifier), argList)
            );
        }
        else if (
            declTy is InterfaceDeclarationSyntax ifd
            && aai.SequenceEqual(declTy.Identifier.ToString())
        )
        {
            // If it's static, it needs to have TSelf type parameter
            impl =
                staticFn
                && ifd.TypeParameterList?.Parameters is { Count: 1 } tPs
                && ifd.ConstraintClauses.Any(x =>
                    x.Name.ToString() == tPs[0].Identifier.ToString()
                    && x.Constraints.Any(y =>
                        y is TypeConstraintSyntax tc
                        && tc.Type.ToString() == $"{declTy.Identifier}<{tPs[0].Identifier}>"
                    )
                )
                    // To call static abstracts in DIMs we need to access it through TSelf
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
                    // Otherwise, static functions aren't applicable.
                    : staticFn
                        ? null
                        : ExpressionStatement(
                            InvocationExpression(IdentifierName(function.Identifier), argList)
                        );
        }

        if (impl is null)
        {
            return null;
        }

        if (function.ReturnType.ToString() != "void")
        {
            impl = ReturnStatement(
                CastExpression(function.ReturnType, ((ExpressionStatementSyntax)impl).Expression)
            );
        }

        var originalFunction = function;
        function = function
            .WithBody(Block(impl))
            .WithAttributeLists(
                List(
                    function
                        .AttributeLists.Select(x =>
                            x.WithAttributes(
                                SeparatedList(
                                    x.Attributes.Where(y =>
                                        !y.IsAttribute("System.Runtime.InteropServices.DllImport")
                                        && !y.IsAttribute("Silk.NET.Core.NativeFunction")
                                        && !y.IsAttribute(
                                            "System.Runtime.CompilerServices.MethodImpl"
                                        )
                                    )
                                )
                            )
                        )
                        .Where(x => x.Attributes.Count > 0)
                        .Concat(
                            Enumerable.Repeat(
                                AttributeList(
                                    SingletonSeparatedList(Attribute(IdentifierName("Transformed")))
                                ),
                                1
                            )
                        )
                )
            )
            .AddNativeFunction(originalFunction)
            .WithExpressionBody(null)
            .WithSemicolonToken(default)
            .WithModifiers(
                TokenList(
                    function
                        .Modifiers.Where(x => !x.IsKind(SyntaxKind.ExternKeyword))
                        .Select(x =>
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
