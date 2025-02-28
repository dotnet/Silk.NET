using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Utility;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// An output function from <see cref="FunctionTransformer"/>
/// </summary>
/// <param name="Function">Function syntax</param>
/// <param name="HasConflictingSignature">Is there another function which will have a conflicting syntax</param>
/// <param name="IsOriginal">Is this the original function syntax</param>
public record TransformedFunction(
    MethodDeclarationSyntax Function,
    bool HasConflictingSignature,
    bool IsOriginal
);

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
    public IEnumerable<TransformedFunction> GetTransformedFunctions(
        string? key,
        IEnumerable<MethodDeclarationSyntax> functions,
        ITransformationContext ctx,
        bool includeOriginal = true
    )
    {
        var ret = functions is IReadOnlyCollection<MethodDeclarationSyntax> coll
            ? new List<TransformedFunction>(coll.Count)
            : [];
        var discrims = new HashSet<string>();

        // Aggregate all the transformers into one delegate
        ctx.Transformers = transformers.SelectMany(x => x.Get(key)).ToArray();
        var transform = ctx.Transformers.Aggregate<
            IFunctionTransformer,
            Action<MethodDeclarationSyntax>
        >(
            (meth) =>
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

                bool hasConflictingSignature = false;

                if (ctx.Original is not null && includeOriginal)
                {
                    var origDiscrim = ModUtils.DiscrimStr(
                        ctx.Original.Modifiers,
                        ctx.Original.TypeParameterList,
                        ctx.Original.Identifier.ToString(),
                        ctx.Original.ParameterList,
                        returnType: null
                    );

                    hasConflictingSignature = origDiscrim == discrim;
                }

                var declTy = ctx.Original?.FirstAncestorOrSelf<BaseTypeDeclarationSyntax>();

                bool isInInterface = declTy is InterfaceDeclarationSyntax;

                // Only add it if it's an overload that does not conflict.
                if (discrims.Add(discrimWithRet) && discrims.Add(discrim))
                {
                    if (isInInterface)
                    {
                        meth = meth.WithBody(null)
                            .WithExpressionBody(null)
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
                    }
                    // Small fixup to convert to use expression bodies where possible
                    else if (
                        meth.ExpressionBody is null
                        && meth.Body?.Statements.Count == 1
                        && (
                            (meth.Body.Statements[0] as ReturnStatementSyntax)?.Expression
                            ?? (
                                meth.ReturnType is PredefinedTypeSyntax pt
                                && pt.Keyword.IsKind(SyntaxKind.VoidKeyword)
                                    ? (
                                        meth.Body.Statements[0] as ExpressionStatementSyntax
                                    )?.Expression
                                    : null
                            )
                        )
                            is { } expr
                    )
                    {
                        meth = meth.WithBody(null)
                            .WithExpressionBody(ArrowExpressionClause(expr))
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
                    }
                    ret.Add(new(meth, hasConflictingSignature, false));
                }
                // TODO else warn maybe?
            },
            (c, t) => meth => t.Transform(meth, ctx, c)
        );
        foreach (var function in functions)
        {
            // We can't handle varargs right now
            if (
                function.ParameterList.Parameters.Any(x =>
                    x.Identifier.IsKind(SyntaxKind.ArgListKeyword)
                )
            )
            {
                logger.LogWarning(
                    "Varargs are not supported yet, excluding function: {}",
                    function
                        .WithBody(null)
                        .WithExpressionBody(null)
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        .NormalizeWhitespace(eol: "\n")
                        .ToFullString()
                );
                continue;
            }

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
                logger.LogWarning(
                    "Failed to add discriminator for original function \"{}\" because a previous transformed or original function conflicts with it. This may cause inconsistencies in outputs.",
                    discrim
                );
            }

            ctx.Original = function;
            TransformFunctions(function, transform);
            if (includeOriginal)
            {
                // Try to add the original function as-is
                ret.Insert(
                    idx,
                    new(
                        function.WithAttributeLists(
                            List(
                                function
                                    .AttributeLists.Select(x =>
                                        x.WithAttributes(
                                            SeparatedList(
                                                x.Attributes.Where(y =>
                                                    !y.IsAttribute(
                                                        "System.Runtime.InteropServices.UnmanagedCallersOnly"
                                                    )
                                                )
                                            )
                                        )
                                    )
                                    .Where(x => x.Attributes.Count > 0)
                            )
                        ),
                        !discrims.Add(discrim),
                        true
                    )
                );
            }

            ctx.Original = null;
        }

        ctx.Transformers = null;
        return ret;
    }

    private void TransformFunctions(
        MethodDeclarationSyntax function,
        Action<MethodDeclarationSyntax> transform
    )
    {
        if (function.ExplicitInterfaceSpecifier is not null)
        {
            return;
        }

        var declTy = function.FirstAncestorOrSelf<BaseTypeDeclarationSyntax>();

        bool isInInterface = declTy is InterfaceDeclarationSyntax;

        // The Silk DSL can be applied to static and non-static methods in a class or a struct.
        if (declTy is not (ClassDeclarationSyntax or StructDeclarationSyntax) && !isInInterface)
        {
            return;
        }

        if (isInInterface)
        {
            transform(function);
            return;
        }

        StatementSyntax impl = ExpressionStatement(
            InvocationExpression(
                IdentifierName(function.Identifier),
                ArgumentList(
                    SeparatedList(
                        function.ParameterList.Parameters.Select(x =>
                            Argument(
                                null,
                                x.Modifiers.Where(mod =>
                                        mod.IsKind(SyntaxKind.RefKeyword)
                                        || mod.IsKind(SyntaxKind.InKeyword)
                                        || mod.IsKind(SyntaxKind.OutKeyword)
                                    )
                                    .FirstOrDefault(),
                                IdentifierName(
                                    x.Identifier.Text == function.Identifier.Text
                                        ? $"_{x.Identifier.Text}"
                                        : x.Identifier.Text
                                )
                            )
                        )
                    )
                )
            )
        );

        if (function.ReturnType.ToString() != "void")
        {
            impl = ReturnStatement(
                CastExpression(function.ReturnType, ((ExpressionStatementSyntax)impl).Expression)
            );
        }

        // Fix for some malformed trivia
        var originalFunction = function;

        if (function.HasLeadingTrivia)
        {
            function = function.WithLeadingTrivia(
                function
                    .GetLeadingTrivia()
                    .Where(trivia =>
                        !trivia.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia)
                    )
                    .ToSyntaxTriviaList()
            );
        }

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
            .WithParameterList(
                ParameterList(
                    SeparatedList(
                        function.ParameterList.Parameters.Select(param =>
                            param.Identifier.Text == function.Identifier.Text
                                ? param.WithIdentifier(Identifier($"_{param.Identifier.Text}"))
                                : param
                        )
                    )
                )
            )
            .WithModifiers(
                TokenList(function.Modifiers.Where(x => !x.IsKind(SyntaxKind.ExternKeyword)))
            );

        transform(function);
    }
}
