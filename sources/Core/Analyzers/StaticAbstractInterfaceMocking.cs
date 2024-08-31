// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Core.Analyzers;

/// <summary>
/// A source generator that allows creating mocks of <c>static abstract</c> interfaces (i.e. in the style of the Surface
/// Host APIs)
/// </summary>
[Generator]
public class StaticAbstractInterfaceMocking : CSharpSyntaxRewriter, IIncrementalGenerator
{
    private ThreadLocal<List<DelegateDeclarationSyntax>?> _delegates = new(() => null);

    /// <inheritdoc />
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationEmbeddedSource(
            "Silk.NET.Core.Analyzers.MockStaticAbstractAttribute.cs"
        );
        context.RegisterSourceOutput(
            context.SyntaxProvider.ForAttributeWithMetadataName(
                "Silk.NET.Core.Analyzers.MockStaticAbstractAttribute",
                (s, _) => s is InterfaceDeclarationSyntax,
                (ctx, _) =>
                {
                    try
                    {
                        return (New: Visit(ctx.TargetNode), ctx.TargetNode);
                    }
                    catch (Exception ex)
                    {
#pragma warning disable RS1035
                        File.WriteAllText(
                            "/Users/dylan/Documents/Silk.NET3/sources/Windowing/Common/tmp.log",
                            ex.ToString()
                        );
#pragma warning restore RS1035
                        throw;
                    }
                }
            ),
            (s, a) =>
            {
                if (a.New is null)
                {
                    return;
                }

                var nsStr = NsStr(a.TargetNode);
                var @new = CompilationUnit()
                    .WithUsings(
                        List(
                            a.TargetNode.Ancestors()
                                .Last()
                                .DescendantNodesAndSelf()
                                .OfType<UsingDirectiveSyntax>()
                        )
                    )
                    .WithMembers(
                        string.IsNullOrWhiteSpace(nsStr)
                            ? SingletonList((MemberDeclarationSyntax)a.New)
                            : SingletonList<MemberDeclarationSyntax>(
                                FileScopedNamespaceDeclaration(
                                        ParseName(
                                            nsStr[
                                                ..(
                                                    nsStr.LastIndexOf('.') is not -1 and var i
                                                        ? i
                                                        : nsStr.Length
                                                )
                                            ]
                                        )
                                    )
                                    .WithMembers(SingletonList((MemberDeclarationSyntax)a.New))
                            )
                    );
                s.AddSource($"{nsStr}.cs", @new.NormalizeWhitespace().ToFullString());
            }
        );
    }

    private static string NsStr(SyntaxNode node) =>
        string.Join(
            '.',
            node.AncestorsAndSelf()
                .Select(x =>
                    x switch
                    {
                        BaseNamespaceDeclarationSyntax bn => bn.Name.ToString(),
                        TypeDeclarationSyntax td => td.Identifier.ToString(),
                        _ => string.Empty
                    }
                )
                .Where(x => x.Length > 0)
                .Reverse()
        );

    /// <inheritdoc />
    public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
        var before = _delegates.Value;
        List<DelegateDeclarationSyntax> delegates = [];
        _delegates.Value = delegates;
        var iface = (InterfaceDeclarationSyntax)
            base.VisitInterfaceDeclaration(
                node.WithMembers(
                    List(
                        node.Members.Where(x =>
                            x is PropertyDeclarationSyntax or MethodDeclarationSyntax
                        )
                    )
                )
            )!;
        _delegates.Value = before;
        return ClassDeclaration($"Mock{node.Identifier}")
            .WithModifiers(TokenList(Token(SyntaxKind.InternalKeyword)))
            .AddMembers(
                [
                    FieldDeclaration(
                            VariableDeclaration(
                                NullableType(IdentifierName("Sentinel")),
                                SingletonSeparatedList(VariableDeclarator("_current"))
                            )
                        )
                        .WithModifiers(TokenList(Token(SyntaxKind.StaticKeyword))),
                    ClassDeclaration("Sentinel")
                        .WithBaseList(
                            BaseList(
                                SingletonSeparatedList<BaseTypeSyntax>(
                                    SimpleBaseType(IdentifierName("IDisposable"))
                                )
                            )
                        )
                        .WithParameterList(
                            ParameterList(
                                SeparatedList(
                                    [
                                        Parameter(Identifier("previous"))
                                            .WithType(NullableType(IdentifierName("Sentinel")))
                                    ]
                                )
                            )
                        )
                        .WithMembers(
                            List<MemberDeclarationSyntax>(
                                [
                                    .. delegates.Select(x =>
                                        FieldDeclaration(
                                                VariableDeclaration(
                                                    ParseTypeName(
                                                        "global::System.Collections.Concurrent.ConcurrentQueue<object>?"
                                                    ),
                                                    SingletonSeparatedList(
                                                        VariableDeclarator(
                                                                $"_current{x.Identifier}"
                                                            )
                                                            .WithInitializer(
                                                                EqualsValueClause(
                                                                    LiteralExpression(
                                                                        SyntaxKind.DefaultLiteralExpression
                                                                    )
                                                                )
                                                            )
                                                    )
                                                )
                                            )
                                            .WithModifiers(
                                                TokenList(Token(SyntaxKind.InternalKeyword))
                                            )
                                    ),
                                    MethodDeclaration(
                                            PredefinedType(Token(SyntaxKind.VoidKeyword)),
                                            "Dispose"
                                        )
                                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                        .WithBody(
                                            Block(
                                                List<StatementSyntax>(
                                                    [
                                                        .. delegates.Select(x =>
                                                            IfStatement(
                                                                BinaryExpression(
                                                                    SyntaxKind.GreaterThanExpression,
                                                                    ConditionalAccessExpression(
                                                                        IdentifierName(
                                                                            $"_current{x.Identifier}"
                                                                        ),
                                                                        MemberBindingExpression(
                                                                            IdentifierName("Count")
                                                                        )
                                                                    ),
                                                                    LiteralExpression(
                                                                        SyntaxKind.NumericLiteralExpression,
                                                                        Literal(0)
                                                                    )
                                                                ),
                                                                ExpressionStatement(
                                                                    ThrowExpression(
                                                                        ImplicitObjectCreationExpression(
                                                                            ArgumentList(
                                                                                SingletonSeparatedList(
                                                                                    Argument(
                                                                                        LiteralExpression(
                                                                                            SyntaxKind.StringLiteralExpression,
                                                                                            Literal(
                                                                                                $"{x.Identifier} has unmet expectations."
                                                                                            )
                                                                                        )
                                                                                    )
                                                                                )
                                                                            ),
                                                                            null
                                                                        )
                                                                    )
                                                                )
                                                            )
                                                        ),
                                                        .. delegates.Select(x =>
                                                            ExpressionStatement(
                                                                AssignmentExpression(
                                                                    SyntaxKind.SimpleAssignmentExpression,
                                                                    IdentifierName(
                                                                        $"_current{x.Identifier}"
                                                                    ),
                                                                    CollectionExpression()
                                                                )
                                                            )
                                                        ),
                                                        ExpressionStatement(
                                                            AssignmentExpression(
                                                                SyntaxKind.SimpleAssignmentExpression,
                                                                MemberAccessExpression(
                                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                                    IdentifierName(
                                                                        $"Mock{node.Identifier}"
                                                                    ),
                                                                    IdentifierName("_current")
                                                                ),
                                                                IdentifierName("previous")
                                                            )
                                                        )
                                                    ]
                                                )
                                            )
                                        )
                                ]
                            )
                        ),
                    MethodDeclaration(IdentifierName("IDisposable"), "Begin")
                        .WithModifiers(
                            TokenList(
                                Token(SyntaxKind.PublicKeyword),
                                Token(SyntaxKind.StaticKeyword)
                            )
                        )
                        .WithExpressionBody(
                            ArrowExpressionClause(
                                AssignmentExpression(
                                    SyntaxKind.SimpleAssignmentExpression,
                                    IdentifierName("_current"),
                                    ObjectCreationExpression(IdentifierName("Sentinel"))
                                        .WithArgumentList(
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(IdentifierName("_current"))
                                                )
                                            )
                                        )
                                )
                            )
                        )
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                    .. iface.Members,
                    .. delegates.Select(x =>
                        MethodDeclaration(
                                PredefinedType(Token(SyntaxKind.VoidKeyword)),
                                Identifier($"Add{x.Identifier}")
                            )
                            .WithModifiers(
                                TokenList(
                                    Token(SyntaxKind.PublicKeyword),
                                    Token(SyntaxKind.StaticKeyword)
                                )
                            )
                            .WithParameterList(
                                ParameterList(
                                    SingletonSeparatedList(
                                        Parameter(Identifier("action"))
                                            .WithType(
                                                x.TypeParameterList is null
                                                    ? IdentifierName(x.Identifier)
                                                    : GenericName(
                                                        x.Identifier,
                                                        TypeArgumentList(
                                                            SeparatedList<TypeSyntax>(
                                                                x.TypeParameterList.Parameters.Select(
                                                                    y =>
                                                                        IdentifierName(y.Identifier)
                                                                )
                                                            )
                                                        )
                                                    )
                                            )
                                    )
                                )
                            )
                            .WithTypeParameterList(x.TypeParameterList)
                            .WithExpressionBody(
                                ArrowExpressionClause(
                                    InvocationExpression(
                                        MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            ParenthesizedExpression(
                                                AssignmentExpression(
                                                    SyntaxKind.CoalesceAssignmentExpression,
                                                    MemberAccessExpression(
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        PostfixUnaryExpression(
                                                            SyntaxKind.SuppressNullableWarningExpression,
                                                            IdentifierName("_current")
                                                        ),
                                                        IdentifierName($"_current{x.Identifier}")
                                                    ),
                                                    ImplicitObjectCreationExpression()
                                                )
                                            ),
                                            IdentifierName("Enqueue")
                                        ),
                                        ArgumentList(
                                            SingletonSeparatedList(
                                                Argument(IdentifierName("action"))
                                            )
                                        )
                                    )
                                )
                            )
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    ),
                    .. delegates
                ]
            );
    }

    private static BlockSyntax GetExpectationExecutionBody(
        bool isVoidReturn,
        string expectationIdentifier,
        ArgumentListSyntax argList,
        TypeArgumentListSyntax? typeParams
    ) =>
        Block(
            (IEnumerable<StatementSyntax>)

                [
                    IfStatement(
                        BinaryExpression(
                            SyntaxKind.LogicalAndExpression,
                            ParenthesizedExpression(
                                BinaryExpression(
                                    SyntaxKind.CoalesceExpression,
                                    InvocationExpression(
                                        ConditionalAccessExpression(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                PostfixUnaryExpression(
                                                    SyntaxKind.SuppressNullableWarningExpression,
                                                    IdentifierName("_current")
                                                ),
                                                IdentifierName($"_current{expectationIdentifier}")
                                            ),
                                            MemberBindingExpression(IdentifierName("TryDequeue"))
                                        ),
                                        ArgumentList(
                                            SingletonSeparatedList(
                                                Argument(
                                                    null,
                                                    Token(SyntaxKind.OutKeyword),
                                                    DeclarationExpression(
                                                        IdentifierName(
                                                            Identifier(
                                                                TriviaList(),
                                                                SyntaxKind.VarKeyword,
                                                                "var",
                                                                "var",
                                                                TriviaList()
                                                            )
                                                        ),
                                                        SingleVariableDesignation(
                                                            Identifier("expectationObj")
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                    ),
                                    LiteralExpression(SyntaxKind.FalseLiteralExpression)
                                )
                            ),
                            IsPatternExpression(
                                IdentifierName("expectationObj"),
                                DeclarationPattern(
                                    typeParams is null
                                        ? IdentifierName(expectationIdentifier)
                                        : GenericName(
                                            Identifier(expectationIdentifier),
                                            typeParams
                                        ),
                                    SingleVariableDesignation(Identifier("expectation"))
                                )
                            )
                        ),
                        isVoidReturn
                            ? ExpressionStatement(
                                InvocationExpression(IdentifierName("expectation"), argList)
                            )
                            : ReturnStatement(
                                InvocationExpression(IdentifierName("expectation"), argList)
                            ),
                        ElseClause(
                            ExpressionStatement(
                                ThrowExpression(
                                    ImplicitObjectCreationExpression(
                                        ArgumentList(
                                            SingletonSeparatedList(
                                                Argument(
                                                    LiteralExpression(
                                                        SyntaxKind.StringLiteralExpression,
                                                        Literal(
                                                            $"No matching expectations for {expectationIdentifier}."
                                                        )
                                                    )
                                                )
                                            )
                                        ),
                                        null
                                    )
                                )
                            )
                        )
                    ),
                ]
        );

    /// <inheritdoc />
    public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        CreateDelegatesForMember(node);
        return base.VisitMethodDeclaration(
            node.WithModifiers(
                    TokenList(node.Modifiers.Where(x => !x.IsKind(SyntaxKind.AbstractKeyword)))
                )
                .WithBody(
                    GetExpectationExecutionBody(
                        node.ReturnType.ToString() == "void",
                        $"{node.Identifier}Expectation",
                        ArgumentList(
                            SeparatedList(
                                node.ParameterList.Parameters.Select(x =>
                                    Argument(IdentifierName(x.Identifier))
                                        .WithRefKindKeyword(
                                            x.Modifiers.FirstOrDefault(y =>
                                                y.Kind()
                                                    is SyntaxKind.InKeyword
                                                        or SyntaxKind.OutKeyword
                                                        or SyntaxKind.RefKeyword
                                            )
                                        )
                                )
                            )
                        ),
                        node.TypeParameterList is null
                            ? null
                            : TypeArgumentList(
                                SeparatedList<TypeSyntax>(
                                    node.TypeParameterList.Parameters.Select(x =>
                                        IdentifierName(x.Identifier)
                                    )
                                )
                            )
                    )
                )
                .WithSemicolonToken(default)
        );
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        CreateDelegatesForMember(node);
        return base.VisitPropertyDeclaration(
            node.WithModifiers(
                    TokenList(node.Modifiers.Where(x => !x.IsKind(SyntaxKind.AbstractKeyword)))
                )
                .WithAccessorList(
                    (
                        node.AccessorList
                        ?? throw new InvalidOperationException(
                            "Bad property declaration for mocking."
                        )
                    ).WithAccessors(
                        List(
                            node.AccessorList.Accessors.Select(x =>
                                x.WithBody(
                                        GetExpectationExecutionBody(
                                            !x.Keyword.IsKind(SyntaxKind.GetKeyword),
                                            $"{x.Keyword.Kind().ToString()[..^"Keyword".Length]}{node.Identifier}Expectation",
                                            x.Keyword.IsKind(SyntaxKind.GetKeyword)
                                                ? ArgumentList()
                                                : ArgumentList(
                                                    SingletonSeparatedList(
                                                        Argument(IdentifierName("value"))
                                                    )
                                                ),
                                            null
                                        )
                                    )
                                    .WithSemicolonToken(default)
                            )
                        )
                    )
                )
        );
    }

    private void CreateDelegatesForMember(MemberDeclarationSyntax decl)
    {
        if (!decl.Modifiers.Any(SyntaxKind.AbstractKeyword))
        {
            return;
        }

        var members = decl switch
        {
            MethodDeclarationSyntax meth
                =>
                [
                    DelegateDeclaration(meth.ReturnType, $"{meth.Identifier}Expectation")
                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                        .WithParameterList(meth.ParameterList)
                        .WithTypeParameterList(meth.TypeParameterList)
                ],
            PropertyDeclarationSyntax prop
                => prop.AccessorList?.Accessors.Select(x =>
                    (
                        x.Keyword.Kind() switch
                        {
                            SyntaxKind.GetKeyword
                                => DelegateDeclaration(
                                    prop.Type,
                                    $"Get{prop.Identifier}Expectation"
                                ),
                            SyntaxKind.SetKeyword
                            or SyntaxKind.AddKeyword
                            or SyntaxKind.RemoveKeyword
                                => DelegateDeclaration(
                                        PredefinedType(Token(SyntaxKind.VoidKeyword)),
                                        $"{x.Keyword.Kind().ToString()[..^"Keyword".Length]}{prop.Identifier}Expectation"
                                    )
                                    .WithParameterList(
                                        ParameterList(
                                            SingletonSeparatedList(Parameter(Identifier("value")))
                                        )
                                    ),
                            _ => throw new ArgumentOutOfRangeException()
                        }
                    ).WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                ) ?? [],
            _ => throw new ArgumentOutOfRangeException(nameof(decl))
        };

        (
            _delegates.Value
            ?? throw new InvalidOperationException(
                $"{nameof(VisitInterfaceDeclaration)} has not been called"
            )
        ).AddRange(members);
    }
}
