using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
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
                ret.Insert(idx, new(function, !discrims.Add(discrim), true));

                // TODO: Not sure what changed here. Need to check history.
                // if (discrims.Add(discrim))
                // {
                //     ret.Insert(idx, function);
                // }
                // else
                // {
                //     // Sometimes when functions are transformed they only differ by return type. C# doesn't allow
                //     // this, so we add a suffix to the original function to differentiate them.
                //     var newIden = $"{function.Identifier}Raw";
                //     var rep = new Dictionary<string, string>
                //     {
                //         { function.Identifier.ToString(), newIden },
                //     };
                //
                //     // Any reference to the original function needs to be replaced as well.
                //     foreach (ref var added in CollectionsMarshal.AsSpan(ret)[idx..])
                //     {
                //         added = (MethodDeclarationSyntax)added.ReplaceIdentifiers(rep);
                //     }
                //
                //     // Add the suffixed function
                //     var newFun = function
                //         .WithRenameSafeAttributeLists()
                //         .WithIdentifier(Identifier(newIden));
                //     discrim = ModUtils.DiscrimStr(
                //         function.Modifiers,
                //         function.TypeParameterList,
                //         newIden,
                //         function.ParameterList,
                //         returnType: null
                //     );
                //     if (discrims.Add(discrim))
                //     {
                //         ret.Insert(idx, newFun);
                //     }
                // }
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

        var unmanagedCallersOnlyAttr = function
            .AttributeLists.SelectMany(al => al.Attributes)
            .FirstOrDefault(attr => attr.Name.ToString() == "UnmanagedCallersOnly");

        ExpressionSyntax functionCall = IdentifierName(function.Identifier);

        if (unmanagedCallersOnlyAttr is not null)
        {
            var callConvArg = unmanagedCallersOnlyAttr?.ArgumentList?.Arguments.FirstOrDefault(
                arg => arg.NameEquals?.Name.Identifier.ValueText == "CallConvs"
            );
            var callConvTypes =
                callConvArg != null
                    ? "["
                        + string.Join(
                            ", ",
                            callConvArg
                                .Expression.DescendantNodesAndSelf()
                                .OfType<TypeOfExpressionSyntax>()
                                .Select(typeOfExpr =>
                                {
                                    // Strip the "CallConv" prefix from the type name.
                                    var typeName = typeOfExpr.Type.ToString();
                                    return typeName.StartsWith("CallConv")
                                        ? typeName.Substring(8)
                                        : typeName;
                                })
                        )
                        + "]"
                    : string.Empty;

            var parameterTypes = string.Join(
                ", ",
                function.ParameterList.Parameters.Select(p => p.Type!.ToString())
            );

            var delegateType =
                $"delegate* unmanaged{callConvTypes}<{parameterTypes}, {function.ReturnType}>";

            functionCall = CastExpression(
                ParseTypeName(delegateType),
                PrefixUnaryExpression(SyntaxKind.AddressOfExpression, functionCall)
            );
        }

        StatementSyntax impl = ExpressionStatement(
            InvocationExpression(
                functionCall,
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
                TokenList(
                    function.Modifiers.Where(x =>
                        x.Kind() is not (SyntaxKind.ExternKeyword or SyntaxKind.PartialKeyword)
                    )
                )
            );

        transform(function);
    }
}
