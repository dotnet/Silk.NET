// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Core.Analyzers;

partial class HluSourceGenerator
{
    private static CompilationUnitSyntax CreateHostPartial(
        INamedTypeSymbol klass,
        IEnumerable<(
            bool IsMandatory,
            INamedTypeSymbol? Class,
            IFieldSymbol? Field,
            string? FieldType,
            SemanticModel SemanticModel
        )> fieldInfo
    )
    {
        IEnumerable<MemberDeclarationSyntax> privateCtor = klass.InstanceConstructors.Any(x =>
            x.Parameters.Length == 0
        )
            ? []
            :
            [
                ConstructorDeclaration(klass.Name)
                    .WithBody(Block())
                    .WithModifiers(TokenList(Token(SyntaxKind.PrivateKeyword)))
            ];
        fieldInfo = fieldInfo.ToArray();
        TypeDeclarationSyntax partial = ClassDeclaration(klass.Name)
            .WithModifiers(TokenList(Token(SyntaxKind.PartialKeyword)))
            .WithMembers(
                List(
                    [
                        _additionalComponentsField,
                        .. privateCtor,
                        GetHostCreateUninit(klass.Name),
                        GetHostCreate(klass.Name),
                        GetHostThrowIfMisconfigured(fieldInfo),
                        GetHostTryGet(fieldInfo),
                        GetHostTrySet(fieldInfo)
                    ]
                )
            )
            .WithBaseList(
                BaseList(
                    SingletonSeparatedList<BaseTypeSyntax>(
                        SimpleBaseType(
                            QualifiedName(
                                QualifiedName(
                                    QualifiedName(
                                        AliasQualifiedName(
                                            IdentifierName(Token(SyntaxKind.GlobalKeyword)),
                                            IdentifierName("Silk")
                                        ),
                                        IdentifierName("NET")
                                    ),
                                    IdentifierName("Core")
                                ),
                                IdentifierName("IHluComponentHost")
                            )
                        )
                    )
                )
            );
        return GetCompilationUnitForPartial(klass, partial);
    }

    private static CompilationUnitSyntax GetCompilationUnitForPartial(
        INamedTypeSymbol klass,
        TypeDeclarationSyntax partial,
        IEnumerable<SyntaxReference>? inheritUsingsFrom = null
    )
    {
        var ns = klass.ContainingNamespace;
        var parent = klass;
        while ((parent = parent?.ContainingType) is not null)
        {
            partial = (
                parent.TypeKind switch
                {
                    TypeKind.Class => (TypeDeclarationSyntax)ClassDeclaration(parent.Name),
                    TypeKind.Interface => InterfaceDeclaration(parent.Name),
                    TypeKind.Struct => StructDeclaration(parent.Name),
                    _ => throw new ArgumentOutOfRangeException()
                }
            ).WithModifiers(TokenList(Token(SyntaxKind.PartialKeyword))).WithMembers(SingletonList<MemberDeclarationSyntax>(partial));
        }

        return (
            ns?.IsGlobalNamespace ?? true
                ? CompilationUnit()
                    .WithMembers(
                        SingletonList<MemberDeclarationSyntax>(
                            partial.WithLeadingTrivia(
                                Trivia(
                                    NullableDirectiveTrivia(Token(SyntaxKind.EnableKeyword), true)
                                )
                            )
                        )
                    )
                : CompilationUnit()
                    .WithUsings(
                        List(
                            (inheritUsingsFrom ?? klass.DeclaringSyntaxReferences)
                                .SelectMany(x =>
                                    x.SyntaxTree.GetRoot()
                                        .DescendantNodes()
                                        .OfType<UsingDirectiveSyntax>()
                                )
                                .DistinctBy(x => x.Alias?.Name ?? x.Name)
                        )
                    )
                    .WithMembers(
                        SingletonList<MemberDeclarationSyntax>(
                            FileScopedNamespaceDeclaration(
                                    IdentifierName(
                                        ns.ToDisplayString(
                                            SymbolDisplayFormat.FullyQualifiedFormat.WithGlobalNamespaceStyle(
                                                SymbolDisplayGlobalNamespaceStyle.Omitted
                                            )
                                        )
                                    )
                                )
                                .WithMembers(SingletonList<MemberDeclarationSyntax>(partial))
                                .WithLeadingTrivia(
                                    Trivia(
                                        NullableDirectiveTrivia(
                                            Token(SyntaxKind.EnableKeyword),
                                            true
                                        )
                                    )
                                )
                        )
                    )
        ).NormalizeWhitespace();
    }

    private static MethodDeclarationSyntax GetHostCreate(string klass) =>
        MethodDeclaration(IdentifierName(klass), Identifier("Create"))
            .WithModifiers(
                TokenList(
                    Token(_createDocs, SyntaxKind.PublicKeyword, TriviaList()),
                    Token(SyntaxKind.StaticKeyword)
                )
            )
            .WithTypeParameterList(
                TypeParameterList(
                    SeparatedList<TypeParameterSyntax>(
                        new SyntaxNodeOrToken[]
                        {
                            TypeParameter(Identifier("TConfiguration")),
                            Token(SyntaxKind.CommaToken),
                            TypeParameter(Identifier("TRegistry"))
                        }
                    )
                )
            )
            .WithParameterList(
                ParameterList(
                    SingletonSeparatedList(
                        Parameter(Identifier("config")).WithType(IdentifierName("TConfiguration"))
                    )
                )
            )
            .WithConstraintClauses(
                List(
                    new[]
                    {
                        TypeParameterConstraintClause(IdentifierName("TConfiguration"))
                            .WithConstraints(
                                SingletonSeparatedList<TypeParameterConstraintSyntax>(
                                    TypeConstraint(
                                        QualifiedName(
                                            QualifiedName(
                                                QualifiedName(
                                                    AliasQualifiedName(
                                                        IdentifierName(
                                                            Token(SyntaxKind.GlobalKeyword)
                                                        ),
                                                        IdentifierName("Silk")
                                                    ),
                                                    IdentifierName("NET")
                                                ),
                                                IdentifierName("Core")
                                            ),
                                            IdentifierName("IHluConfiguration")
                                        )
                                    )
                                )
                            ),
                        TypeParameterConstraintClause(IdentifierName("TRegistry"))
                            .WithConstraints(
                                SingletonSeparatedList<TypeParameterConstraintSyntax>(
                                    TypeConstraint(
                                        QualifiedName(
                                            QualifiedName(
                                                QualifiedName(
                                                    AliasQualifiedName(
                                                        IdentifierName(
                                                            Token(SyntaxKind.GlobalKeyword)
                                                        ),
                                                        IdentifierName("Silk")
                                                    ),
                                                    IdentifierName("NET")
                                                ),
                                                IdentifierName("Core")
                                            ),
                                            IdentifierName("IHluComponentRegistry")
                                        )
                                    )
                                )
                            )
                    }
                )
            )
            .WithBody(
                Block(
                    (IEnumerable<StatementSyntax>)

                        [
                            LocalDeclarationStatement(
                                VariableDeclaration(
                                    IdentifierName(
                                        Identifier(
                                            TriviaList(),
                                            SyntaxKind.VarKeyword,
                                            "var",
                                            "var",
                                            TriviaList()
                                        )
                                    ),
                                    SingletonSeparatedList(
                                        VariableDeclarator(
                                            Identifier("ret"),
                                            null,
                                            EqualsValueClause(
                                                ObjectCreationExpression(
                                                    IdentifierName(klass),
                                                    ArgumentList(),
                                                    null
                                                )
                                            )
                                        )
                                    )
                                )
                            ),
                            ExpressionStatement(
                                InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("TRegistry"),
                                        GenericName(
                                            Identifier("ConfigureDefaults"),
                                            TypeArgumentList(
                                                SeparatedList(
                                                    (IEnumerable<TypeSyntax>)

                                                        [
                                                            IdentifierName(klass),
                                                            IdentifierName("TConfiguration"),
                                                            IdentifierName("TRegistry")
                                                        ]
                                                )
                                            )
                                        )
                                    ),
                                    ArgumentList(
                                        SeparatedList(
                                            [
                                                Argument(IdentifierName("ret")),
                                                Argument(IdentifierName("config"))
                                            ]
                                        )
                                    )
                                )
                            ),
                            ExpressionStatement(
                                InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("ret"),
                                        IdentifierName("ThrowIfMisconfigured")
                                    )
                                )
                            ),
                            ReturnStatement(IdentifierName("ret"))
                        ]
                )
            );

    private static MethodDeclarationSyntax GetHostThrowIfMisconfigured(
        IEnumerable<(
            bool IsMandatory,
            INamedTypeSymbol? Class,
            IFieldSymbol? Field,
            string? FieldType,
            SemanticModel SemanticModel
        )> fieldInfo
    ) =>
        MethodDeclaration(PredefinedType(Token(SyntaxKind.VoidKeyword)), "ThrowIfMisconfigured")
            .WithModifiers(TokenList(Token(_inheritDoc, SyntaxKind.PublicKeyword, TriviaList())))
            .WithBody(
                Block(
                    fieldInfo
                        .Where(x => x is { IsMandatory: true, Field: not null })
                        .Select(field =>
                            ExpressionStatement(
                                InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        QualifiedName(
                                            QualifiedName(
                                                QualifiedName(
                                                    AliasQualifiedName(
                                                        IdentifierName(
                                                            Token(SyntaxKind.GlobalKeyword)
                                                        ),
                                                        IdentifierName("Silk")
                                                    ),
                                                    IdentifierName("NET")
                                                ),
                                                IdentifierName("Core")
                                            ),
                                            IdentifierName("HluMissingComponentException")
                                        ),
                                        IdentifierName("ThrowIfNull")
                                    ),
                                    ArgumentList(
                                        SingletonSeparatedList(
                                            Argument(IdentifierName(field.Field!.Name))
                                        )
                                    )
                                )
                            )
                        )
                )
            );

    private static MethodDeclarationSyntax GetHostCreateUninit(string klass) =>
        MethodDeclaration(IdentifierName(klass), Identifier("CreateUninitialized"))
            .WithModifiers(
                TokenList(
                    Token(
                        TriviaList(
                            Trivia(
                                DocumentationCommentTrivia(
                                    SyntaxKind.SingleLineDocumentationCommentTrivia,
                                    List(
                                        new XmlNodeSyntax[]
                                        {
                                            XmlText()
                                                .WithTextTokens(
                                                    TokenList(
                                                        XmlTextLiteral(
                                                            TriviaList(
                                                                DocumentationCommentExterior("///")
                                                            ),
                                                            " ",
                                                            " ",
                                                            TriviaList()
                                                        )
                                                    )
                                                ),
                                            XmlExampleElement(
                                                    XmlText()
                                                        .WithTextTokens(
                                                            TokenList(
                                                                XmlTextNewLine(
                                                                    TriviaList(),
                                                                    "\n",
                                                                    "\n",
                                                                    TriviaList()
                                                                ),
                                                                XmlTextLiteral(
                                                                    TriviaList(
                                                                        DocumentationCommentExterior(
                                                                            "    ///"
                                                                        )
                                                                    ),
                                                                    " Creates an uninitialized ",
                                                                    " Creates an uninitialized ",
                                                                    TriviaList()
                                                                )
                                                            )
                                                        ),
                                                    XmlNullKeywordElement()
                                                        .WithAttributes(
                                                            SingletonList<XmlAttributeSyntax>(
                                                                XmlCrefAttribute(
                                                                    NameMemberCref(
                                                                        IdentifierName(klass)
                                                                    )
                                                                )
                                                            )
                                                        ),
                                                    XmlText()
                                                        .WithTextTokens(
                                                            TokenList(
                                                                XmlTextLiteral(
                                                                    TriviaList(),
                                                                    ". This probably isn't what you want unless you're pre-configuring a host",
                                                                    ". This probably isn't what you want unless you're pre-configuring a host",
                                                                    TriviaList()
                                                                ),
                                                                XmlTextNewLine(
                                                                    TriviaList(),
                                                                    "\n",
                                                                    "\n",
                                                                    TriviaList()
                                                                ),
                                                                XmlTextLiteral(
                                                                    TriviaList(
                                                                        DocumentationCommentExterior(
                                                                            "    ///"
                                                                        )
                                                                    ),
                                                                    " with custom components.",
                                                                    " with custom components.",
                                                                    TriviaList()
                                                                ),
                                                                XmlTextNewLine(
                                                                    TriviaList(),
                                                                    "\n",
                                                                    "\n",
                                                                    TriviaList()
                                                                ),
                                                                XmlTextLiteral(
                                                                    TriviaList(
                                                                        DocumentationCommentExterior(
                                                                            "    ///"
                                                                        )
                                                                    ),
                                                                    " ",
                                                                    " ",
                                                                    TriviaList()
                                                                )
                                                            )
                                                        )
                                                )
                                                .WithStartTag(
                                                    XmlElementStartTag(
                                                        XmlName(Identifier("summary"))
                                                    )
                                                )
                                                .WithEndTag(
                                                    XmlElementEndTag(XmlName(Identifier("summary")))
                                                ),
                                            XmlText()
                                                .WithTextTokens(
                                                    TokenList(
                                                        XmlTextNewLine(
                                                            TriviaList(),
                                                            "\n",
                                                            "\n",
                                                            TriviaList()
                                                        ),
                                                        XmlTextLiteral(
                                                            TriviaList(
                                                                DocumentationCommentExterior(
                                                                    "    ///"
                                                                )
                                                            ),
                                                            " ",
                                                            " ",
                                                            TriviaList()
                                                        )
                                                    )
                                                ),
                                            XmlExampleElement(
                                                    SingletonList<XmlNodeSyntax>(
                                                        XmlText()
                                                            .WithTextTokens(
                                                                TokenList(
                                                                    XmlTextLiteral(
                                                                        TriviaList(),
                                                                        "The uninitialized component host.",
                                                                        "The uninitialized component host.",
                                                                        TriviaList()
                                                                    )
                                                                )
                                                            )
                                                    )
                                                )
                                                .WithStartTag(
                                                    XmlElementStartTag(
                                                        XmlName(Identifier("returns"))
                                                    )
                                                )
                                                .WithEndTag(
                                                    XmlElementEndTag(XmlName(Identifier("returns")))
                                                ),
                                            XmlText()
                                                .WithTextTokens(
                                                    TokenList(
                                                        XmlTextNewLine(
                                                            TriviaList(),
                                                            "\n",
                                                            "\n",
                                                            TriviaList()
                                                        )
                                                    )
                                                )
                                        }
                                    )
                                )
                            )
                        ),
                        SyntaxKind.PublicKeyword,
                        TriviaList()
                    ),
                    Token(SyntaxKind.StaticKeyword)
                )
            )
            .WithExpressionBody(ArrowExpressionClause(ImplicitObjectCreationExpression()))
            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));

    private static MethodDeclarationSyntax GetHostTryGet(
        IEnumerable<(
            bool IsMandatory,
            INamedTypeSymbol? Class,
            IFieldSymbol? Field,
            string? FieldType,
            SemanticModel SemanticModel
        )> fieldInfo
    ) =>
        MethodDeclaration(PredefinedType(Token(SyntaxKind.BoolKeyword)), Identifier("TryGet"))
            .WithModifiers(TokenList(Token(_inheritDoc, SyntaxKind.PublicKeyword, TriviaList())))
            .WithTypeParameterList(
                TypeParameterList(SingletonSeparatedList(TypeParameter(Identifier("TComponent"))))
            )
            .WithParameterList(
                ParameterList(
                    SingletonSeparatedList(
                        Parameter(Identifier("component"))
                            .WithAttributeLists(
                                SingletonList(
                                    AttributeList(
                                        SingletonSeparatedList(
                                            Attribute(
                                                    QualifiedName(
                                                        QualifiedName(
                                                            QualifiedName(
                                                                AliasQualifiedName(
                                                                    IdentifierName(
                                                                        Token(
                                                                            SyntaxKind.GlobalKeyword
                                                                        )
                                                                    ),
                                                                    IdentifierName("System")
                                                                ),
                                                                IdentifierName("Diagnostics")
                                                            ),
                                                            IdentifierName("CodeAnalysis")
                                                        ),
                                                        IdentifierName("NotNullWhen")
                                                    )
                                                )
                                                .WithArgumentList(
                                                    AttributeArgumentList(
                                                        SingletonSeparatedList(
                                                            AttributeArgument(
                                                                LiteralExpression(
                                                                    SyntaxKind.TrueLiteralExpression
                                                                )
                                                            )
                                                        )
                                                    )
                                                )
                                        )
                                    )
                                )
                            )
                            .WithModifiers(TokenList(Token(SyntaxKind.OutKeyword)))
                            .WithType(NullableType(IdentifierName("TComponent")))
                    )
                )
            )
            .WithBody(
                Block(
                    (IEnumerable<StatementSyntax>)

                        [
                            .. fieldInfo
                                .Where(x => x is { Field.Name: not null, FieldType: not null })
                                .Select(x =>
                                    IfStatement(
                                        BinaryExpression(
                                            SyntaxKind.EqualsExpression,
                                            TypeOfExpression(IdentifierName("TComponent")),
                                            TypeOfExpression(ParseTypeName(x.FieldType!))
                                        ),
                                        Block(
                                            ExpressionStatement(
                                                AssignmentExpression(
                                                    SyntaxKind.SimpleAssignmentExpression,
                                                    IdentifierName("component"),
                                                    CastExpression(
                                                        NullableType(IdentifierName("TComponent")),
                                                        CastExpression(
                                                            NullableType(
                                                                PredefinedType(
                                                                    Token(SyntaxKind.ObjectKeyword)
                                                                )
                                                            ),
                                                            PostfixUnaryExpression(
                                                                SyntaxKind.SuppressNullableWarningExpression,
                                                                IdentifierName(x.Field!.Name)
                                                            )
                                                        )
                                                    )
                                                )
                                            ),
                                            ReturnStatement(
                                                BinaryExpression(
                                                    SyntaxKind.NotEqualsExpression,
                                                    IdentifierName(x.Field!.Name),
                                                    LiteralExpression(
                                                        SyntaxKind.DefaultLiteralExpression,
                                                        Token(SyntaxKind.DefaultKeyword)
                                                    )
                                                )
                                            )
                                        )
                                    )
                                ),
                            ExpressionStatement(
                                AssignmentExpression(
                                    SyntaxKind.SimpleAssignmentExpression,
                                    IdentifierName("component"),
                                    LiteralExpression(
                                        SyntaxKind.DefaultLiteralExpression,
                                        Token(SyntaxKind.DefaultKeyword)
                                    )
                                )
                            ),
                            ReturnStatement(
                                LiteralExpression(
                                    SyntaxKind.FalseLiteralExpression,
                                    Token(SyntaxKind.FalseKeyword)
                                )
                            )
                        ]
                )
            );

    private static MethodDeclarationSyntax GetHostTrySet(
        IEnumerable<(
            bool IsMandatory,
            INamedTypeSymbol? Class,
            IFieldSymbol? Field,
            string? FieldType,
            SemanticModel SemanticModel
        )> fieldInfo
    ) =>
        MethodDeclaration(PredefinedType(Token(SyntaxKind.BoolKeyword)), Identifier("TrySet"))
            .WithModifiers(TokenList(Token(_inheritDoc, SyntaxKind.PublicKeyword, TriviaList())))
            .WithTypeParameterList(
                TypeParameterList(
                    SeparatedList(
                        [
                            TypeParameter(Identifier("TComponent")),
                            TypeParameter(Identifier("TImpl"))
                        ]
                    )
                )
            )
            .WithParameterList(
                ParameterList(
                    SingletonSeparatedList(
                        Parameter(Identifier("component")).WithType(IdentifierName("TImpl"))
                    )
                )
            )
            .WithConstraintClauses(
                SingletonList(
                    TypeParameterConstraintClause(
                        IdentifierName("TImpl"),
                        SingletonSeparatedList<TypeParameterConstraintSyntax>(
                            TypeConstraint(IdentifierName("TComponent"))
                        )
                    )
                )
            )
            .WithBody(
                Block(
                    (IEnumerable<StatementSyntax>)

                        [
                            ExpressionStatement(
                                InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        QualifiedName(
                                            AliasQualifiedName(
                                                IdentifierName(Token(SyntaxKind.GlobalKeyword)),
                                                IdentifierName("System")
                                            ),
                                            IdentifierName("ArgumentNullException")
                                        ),
                                        IdentifierName("ThrowIfNull")
                                    ),
                                    ArgumentList(
                                        SingletonSeparatedList(
                                            Argument(IdentifierName("component"))
                                        )
                                    )
                                )
                            ),
                            .. fieldInfo
                                .Where(x => x is { FieldType: not null, Field.Name: not null })
                                .Select(x =>
                                    IfStatement(
                                        BinaryExpression(
                                            SyntaxKind.EqualsExpression,
                                            TypeOfExpression(IdentifierName("TComponent")),
                                            TypeOfExpression(ParseTypeName(x.FieldType!))
                                        ),
                                        Block(
                                            ExpressionStatement(
                                                AssignmentExpression(
                                                    SyntaxKind.SimpleAssignmentExpression,
                                                    IdentifierName(x.Field!.Name),
                                                    CastExpression(
                                                        IdentifierName(x.FieldType!),
                                                        CastExpression(
                                                            PredefinedType(
                                                                Token(SyntaxKind.ObjectKeyword)
                                                            ),
                                                            PostfixUnaryExpression(
                                                                SyntaxKind.SuppressNullableWarningExpression,
                                                                IdentifierName("component")
                                                            )
                                                        )
                                                    )
                                                )
                                            ),
                                            ReturnStatement(
                                                LiteralExpression(
                                                    SyntaxKind.TrueLiteralExpression,
                                                    Token(SyntaxKind.TrueKeyword)
                                                )
                                            )
                                        )
                                    )
                                ),
                            ExpressionStatement(
                                AssignmentExpression(
                                    SyntaxKind.SimpleAssignmentExpression,
                                    ElementAccessExpression(
                                            ParenthesizedExpression(
                                                AssignmentExpression(
                                                    SyntaxKind.CoalesceAssignmentExpression,
                                                    IdentifierName("_additionalComponents"),
                                                    CollectionExpression()
                                                )
                                            )
                                        )
                                        .WithArgumentList(
                                            BracketedArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(
                                                        TypeOfExpression(
                                                            IdentifierName("TComponent")
                                                        )
                                                    )
                                                )
                                            )
                                        ),
                                    IdentifierName("component")
                                )
                            ),
                            ReturnStatement(
                                LiteralExpression(
                                    SyntaxKind.TrueLiteralExpression,
                                    Token(SyntaxKind.TrueKeyword)
                                )
                            )
                        ]
                )
            );

    private static readonly FieldDeclarationSyntax _additionalComponentsField = FieldDeclaration(
            VariableDeclaration(
                    NullableType(
                        QualifiedName(
                            QualifiedName(
                                QualifiedName(
                                    AliasQualifiedName(
                                        IdentifierName(Token(SyntaxKind.GlobalKeyword)),
                                        IdentifierName("System")
                                    ),
                                    IdentifierName("Collections")
                                ),
                                IdentifierName("Generic")
                            ),
                            GenericName(Identifier("Dictionary"))
                                .WithTypeArgumentList(
                                    TypeArgumentList(
                                        SeparatedList<TypeSyntax>(
                                            new SyntaxNodeOrToken[]
                                            {
                                                QualifiedName(
                                                    AliasQualifiedName(
                                                        IdentifierName(
                                                            Token(SyntaxKind.GlobalKeyword)
                                                        ),
                                                        IdentifierName("System")
                                                    ),
                                                    IdentifierName("Type")
                                                ),
                                                Token(SyntaxKind.CommaToken),
                                                PredefinedType(Token(SyntaxKind.ObjectKeyword))
                                            }
                                        )
                                    )
                                )
                        )
                    )
                )
                .WithVariables(
                    SingletonSeparatedList(VariableDeclarator(Identifier("_additionalComponents")))
                )
        )
        .WithModifiers(TokenList(Token(SyntaxKind.PrivateKeyword)))
        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));

    private static readonly SyntaxTriviaList _inheritDoc = TriviaList(
        Trivia(
            DocumentationCommentTrivia(
                SyntaxKind.SingleLineDocumentationCommentTrivia,
                List(
                    new XmlNodeSyntax[]
                    {
                        XmlText()
                            .WithTextTokens(
                                TokenList(
                                    XmlTextLiteral(
                                        TriviaList(DocumentationCommentExterior("///")),
                                        " ",
                                        " ",
                                        TriviaList()
                                    )
                                )
                            ),
                        XmlNullKeywordElement().WithName(XmlName(Identifier("inheritdoc"))),
                        XmlText()
                            .WithTextTokens(
                                TokenList(XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()))
                            )
                    }
                )
            )
        )
    );

    private static readonly SyntaxTriviaList _createDocs = TriviaList(
        Trivia(
            DocumentationCommentTrivia(
                SyntaxKind.SingleLineDocumentationCommentTrivia,
                List(
                    new XmlNodeSyntax[]
                    {
                        XmlText()
                            .WithTextTokens(
                                TokenList(
                                    XmlTextLiteral(
                                        TriviaList(DocumentationCommentExterior("///")),
                                        " ",
                                        " ",
                                        TriviaList()
                                    )
                                )
                            ),
                        XmlExampleElement(
                                XmlText()
                                    .WithTextTokens(
                                        TokenList(
                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()),
                                            XmlTextLiteral(
                                                TriviaList(DocumentationCommentExterior("    ///")),
                                                " Creates a ",
                                                " Creates a ",
                                                TriviaList()
                                            )
                                        )
                                    ),
                                XmlNullKeywordElement()
                                    .WithAttributes(
                                        SingletonList<XmlAttributeSyntax>(
                                            XmlCrefAttribute(
                                                NameMemberCref(IdentifierName("Surface"))
                                            )
                                        )
                                    ),
                                XmlText()
                                    .WithTextTokens(
                                        TokenList(
                                            XmlTextLiteral(
                                                TriviaList(),
                                                " with the components from the given registry,",
                                                " with the components from the given registry,",
                                                TriviaList()
                                            ),
                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()),
                                            XmlTextLiteral(
                                                TriviaList(DocumentationCommentExterior("    ///")),
                                                " configured using the given configuration.",
                                                " configured using the given configuration.",
                                                TriviaList()
                                            ),
                                            XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()),
                                            XmlTextLiteral(
                                                TriviaList(DocumentationCommentExterior("    ///")),
                                                " ",
                                                " ",
                                                TriviaList()
                                            )
                                        )
                                    )
                            )
                            .WithStartTag(XmlElementStartTag(XmlName(Identifier("summary"))))
                            .WithEndTag(XmlElementEndTag(XmlName(Identifier("summary")))),
                        XmlText()
                            .WithTextTokens(
                                TokenList(
                                    XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()),
                                    XmlTextLiteral(
                                        TriviaList(DocumentationCommentExterior("    ///")),
                                        " ",
                                        " ",
                                        TriviaList()
                                    )
                                )
                            ),
                        XmlExampleElement(
                                SingletonList<XmlNodeSyntax>(
                                    XmlText()
                                        .WithTextTokens(
                                            TokenList(
                                                XmlTextLiteral(
                                                    TriviaList(),
                                                    "The configuration for the components.",
                                                    "The configuration for the components.",
                                                    TriviaList()
                                                )
                                            )
                                        )
                                )
                            )
                            .WithStartTag(
                                XmlElementStartTag(
                                        XmlName(
                                            Identifier(
                                                TriviaList(),
                                                SyntaxKind.ParamKeyword,
                                                "param",
                                                "param",
                                                TriviaList()
                                            )
                                        )
                                    )
                                    .WithAttributes(
                                        SingletonList<XmlAttributeSyntax>(
                                            XmlNameAttribute(
                                                XmlName(Identifier("name")),
                                                Token(SyntaxKind.DoubleQuoteToken),
                                                IdentifierName("config"),
                                                Token(SyntaxKind.DoubleQuoteToken)
                                            )
                                        )
                                    )
                            )
                            .WithEndTag(
                                XmlElementEndTag(
                                    XmlName(
                                        Identifier(
                                            TriviaList(),
                                            SyntaxKind.ParamKeyword,
                                            "param",
                                            "param",
                                            TriviaList()
                                        )
                                    )
                                )
                            ),
                        XmlText()
                            .WithTextTokens(
                                TokenList(
                                    XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()),
                                    XmlTextLiteral(
                                        TriviaList(DocumentationCommentExterior("    ///")),
                                        " ",
                                        " ",
                                        TriviaList()
                                    )
                                )
                            ),
                        XmlExampleElement(
                                SingletonList<XmlNodeSyntax>(
                                    XmlText()
                                        .WithTextTokens(
                                            TokenList(
                                                XmlTextLiteral(
                                                    TriviaList(),
                                                    "The instantiated object.",
                                                    "The instantiated object.",
                                                    TriviaList()
                                                )
                                            )
                                        )
                                )
                            )
                            .WithStartTag(XmlElementStartTag(XmlName(Identifier("returns"))))
                            .WithEndTag(XmlElementEndTag(XmlName(Identifier("returns")))),
                        XmlText()
                            .WithTextTokens(
                                TokenList(XmlTextNewLine(TriviaList(), "\n", "\n", TriviaList()))
                            )
                    }
                )
            )
        )
    );
}
