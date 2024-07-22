// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Core.Analyzers;

partial class HluSourceGenerator
{
    private static CompilationUnitSyntax CreateRegistryPartial(
        INamedTypeSymbol klass,
        SemanticModel semanticModel,
        IReadOnlyList<(
            INamedTypeSymbol ComponentType,
            INamedTypeSymbol ImplementationType,
            AttributeSyntax ApplicationSyntax,
            bool IsDefault
        )> components
    ) =>
        GetCompilationUnitForPartial(
            klass,
            ClassDeclaration(klass.Name)
                .WithModifiers(TokenList(Token(SyntaxKind.PartialKeyword)))
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
                                    IdentifierName("IHluComponentRegistry")
                                )
                            )
                        )
                    )
                )
                .WithMembers(
                    List<MemberDeclarationSyntax>(
                        [
                            GetRegistryConfigureDefaults(components),
                            GetRegistryTryConfigureComponent(semanticModel, components)
                        ]
                    )
                )
        );

    private static MethodDeclarationSyntax GetRegistryConfigureDefaults(
        IEnumerable<(
            INamedTypeSymbol ComponentType,
            INamedTypeSymbol ImplementationType,
            AttributeSyntax ApplicationSyntax,
            bool IsDefault
        )> components
    ) =>
        MethodDeclaration(
                PredefinedType(Token(SyntaxKind.VoidKeyword)),
                Identifier("ConfigureDefaults")
            )
            .WithModifiers(
                TokenList(
                    Token(_inheritDoc, SyntaxKind.PublicKeyword, TriviaList()),
                    Token(SyntaxKind.StaticKeyword)
                )
            )
            .WithTypeParameterList(
                TypeParameterList(
                    SeparatedList(
                        [
                            TypeParameter(Identifier("THost")),
                            TypeParameter(Identifier("TConfiguration")),
                            TypeParameter(Identifier("TRegistry"))
                        ]
                    )
                )
            )
            .WithParameterList(
                ParameterList(
                    SeparatedList(
                        [
                            Parameter(Identifier("dest")).WithType(IdentifierName("THost")),
                            Parameter(Identifier("config"))
                                .WithType(IdentifierName("TConfiguration"))
                        ]
                    )
                )
            )
            .WithConstraintClauses(
                List(
                    new[]
                    {
                        TypeParameterConstraintClause(IdentifierName("THost"))
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
                                            IdentifierName("IHluComponentHost")
                                        )
                                    )
                                )
                            ),
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
                    components
                        .Where(x => x.IsDefault)
                        .Select(x =>
                            ExpressionStatement(
                                InvocationExpression(
                                    GenericName(
                                        Identifier("TryConfigureComponent"),
                                        TypeArgumentList(
                                            SeparatedList(
                                                [
                                                    ((GenericNameSyntax)x.ApplicationSyntax.Name)
                                                        .TypeArgumentList
                                                        .Arguments[0],
                                                    IdentifierName("THost"),
                                                    IdentifierName("TConfiguration"),
                                                    IdentifierName("TRegistry")
                                                ]
                                            )
                                        )
                                    ),
                                    ArgumentList(
                                        SeparatedList(
                                            [
                                                Argument(IdentifierName("dest")),
                                                Argument(IdentifierName("config"))
                                            ]
                                        )
                                    )
                                )
                            )
                        )
                )
            );

    private static MethodDeclarationSyntax GetRegistryTryConfigureComponent(
        SemanticModel semanticModel,
        IReadOnlyList<(
            INamedTypeSymbol ComponentType,
            INamedTypeSymbol ImplementationType,
            AttributeSyntax ApplicationSyntax,
            bool IsDefault
        )> components
    ) =>
        MethodDeclaration(
                PredefinedType(Token(SyntaxKind.BoolKeyword)),
                Identifier("TryConfigureComponent")
            )
            .WithModifiers(
                TokenList(
                    Token(_inheritDoc, SyntaxKind.PublicKeyword, TriviaList()),
                    Token(SyntaxKind.StaticKeyword)
                )
            )
            .WithTypeParameterList(
                TypeParameterList(
                    SeparatedList(
                        [
                            TypeParameter(Identifier("TComponent")),
                            TypeParameter(Identifier("THost")),
                            TypeParameter(Identifier("TConfiguration")),
                            TypeParameter(Identifier("TRegistry"))
                        ]
                    )
                )
            )
            .WithParameterList(
                ParameterList(
                    SeparatedList(
                        [
                            Parameter(Identifier("dest")).WithType(IdentifierName("THost")),
                            Parameter(Identifier("config"))
                                .WithType(IdentifierName("TConfiguration"))
                        ]
                    )
                )
            )
            .WithConstraintClauses(
                List(
                    new[]
                    {
                        TypeParameterConstraintClause(IdentifierName("THost"))
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
                                            IdentifierName("IHluComponentHost")
                                        )
                                    )
                                )
                            ),
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
                            IfStatement(
                                InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("dest"),
                                        GenericName(
                                            Identifier("TryGet"),
                                            TypeArgumentList(
                                                SingletonSeparatedList<TypeSyntax>(
                                                    IdentifierName("TComponent")
                                                )
                                            )
                                        )
                                    ),
                                    ArgumentList(
                                        SingletonSeparatedList(
                                            Argument(
                                                null,
                                                Token(SyntaxKind.OutKeyword),
                                                IdentifierName("_")
                                            )
                                        )
                                    )
                                ),
                                ReturnStatement(
                                    LiteralExpression(
                                        SyntaxKind.FalseLiteralExpression,
                                        Token(SyntaxKind.FalseKeyword)
                                    )
                                )
                            ),
                            .. components.Select(
                                (x, compIdx) =>
                                {
                                    var encounteredFallbackOption = false;
                                    return IfStatement(
                                        BinaryExpression(
                                            SyntaxKind.EqualsExpression,
                                            TypeOfExpression(IdentifierName("TComponent")),
                                            TypeOfExpression(
                                                ((GenericNameSyntax)x.ApplicationSyntax.Name)
                                                    .TypeArgumentList
                                                    .Arguments[0]
                                            )
                                        ),
                                        Block(
                                            x.ImplementationType.InstanceConstructors.Where(y =>
                                                    y.DeclaredAccessibility == Accessibility.Public
                                                )
                                                .Concat(
                                                    x.ImplementationType.GetMembers()
                                                        .OfType<IMethodSymbol>()
                                                        .Where(y =>
                                                            y
                                                                is {
                                                                    Name: "TryConfigure",
                                                                    ReturnType.SpecialType: SpecialType.System_Boolean,
                                                                    TypeParameters: [
                                                                        {
                                                                            ConstraintTypes.Length: 1
                                                                        }
                                                                    ],
                                                                    DeclaredAccessibility: Accessibility.Public
                                                                }
                                                            && y.TypeParameters[0]
                                                                .ConstraintTypes[0]
                                                                .ToDisplayString(NamespaceQualified)
                                                                == "Silk.NET.Core.IHluComponentHost"
                                                            && y.Parameters[0]
                                                                .Type.Equals(
                                                                    y.TypeParameters[0],
                                                                    SymbolEqualityComparer.Default
                                                                )
                                                        )
                                                )
                                                .Select(y =>
                                                    (
                                                        NumRequired: y.Parameters.Count(z =>
                                                            z.Type.NullableAnnotation
                                                                == NullableAnnotation.NotAnnotated
                                                            && z.Type.SpecialType
                                                                != SpecialType.System_Nullable_T
                                                        ),
                                                        Ctor: y
                                                    )
                                                )
                                                .OrderByDescending(y =>
                                                    (y.NumRequired * 1000)
                                                    + y.Ctor.Parameters.Length
                                                    - y.Ctor.TypeParameters.Length
                                                )
                                                .TakeWhile(y =>
                                                    !encounteredFallbackOption
                                                    && (
                                                        y.NumRequired != 0
                                                        || (encounteredFallbackOption = true)
                                                    )
                                                )
                                                .SelectMany(
                                                    (y, ctorIdx) =>
                                                        GetRegistryConfigureMandatoryDependencies(
                                                            compIdx,
                                                            y.Ctor,
                                                            ctorIdx,
                                                            semanticModel,
                                                            [
                                                                .. GetRegistryDependencyVariableDeclarations(
                                                                    compIdx,
                                                                    y.Ctor,
                                                                    ctorIdx,
                                                                    semanticModel
                                                                ),
                                                                .. GetRegistryTryConfigureOptionalDependencies(
                                                                    compIdx,
                                                                    y.Ctor,
                                                                    ctorIdx,
                                                                    semanticModel
                                                                ),
                                                                GetRegistryTrySetConfiguredComponent(
                                                                    x.ApplicationSyntax,
                                                                    compIdx,
                                                                    y.Ctor,
                                                                    ctorIdx
                                                                )
                                                            ]
                                                        )
                                                )
                                        )
                                    );
                                }
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

    private static IEnumerable<StatementSyntax> GetRegistryDependencyVariableDeclarations(
        int compIdx,
        IMethodSymbol ctor,
        int ctorIdx,
        SemanticModel semanticModel
    ) =>
        ctor
            .Parameters.Skip(ctor.TypeParameters.Length)
            .Select((z, pIdx) => (Component: z, PIdx: pIdx))
            .Where(z =>
                z.Component.Type.NullableAnnotation == NullableAnnotation.Annotated
                || z.Component.Type.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T
            )
            .Select(z =>
                LocalDeclarationStatement(
                    VariableDeclaration(
                        NullableType(
                            ParseTypeName(
                                SymbolDisplay.ToMinimalDisplayString(
                                    z.Component.Type,
                                    semanticModel,
                                    0,
                                    SymbolDisplayFormat.FullyQualifiedFormat
                                )
                            )
                        ),
                        SingletonSeparatedList(
                            VariableDeclarator(
                                Identifier($"dep{compIdx}Ctor{ctorIdx}Param{z.PIdx}"),
                                null,
                                EqualsValueClause(
                                    PostfixUnaryExpression(
                                        SyntaxKind.SuppressNullableWarningExpression,
                                        LiteralExpression(
                                            SyntaxKind.DefaultLiteralExpression,
                                            Token(SyntaxKind.DefaultKeyword)
                                        )
                                    )
                                )
                            )
                        )
                    )
                )
            );

    private static readonly SymbolDisplayFormat NamespaceQualified =
        SymbolDisplayFormat.FullyQualifiedFormat.WithGlobalNamespaceStyle(
            SymbolDisplayGlobalNamespaceStyle.Omitted
        );

    private static IEnumerable<StatementSyntax> GetRegistryTryConfigureOptionalDependencies(
        int compIdx,
        IMethodSymbol ctor,
        int ctorIdx,
        SemanticModel semanticModel
    ) =>
        ctor
            .Parameters.Skip(ctor.TypeParameters.Length)
            .Select((z, i) => (Component: z, PIdx: i))
            .Where(z =>
                z.Component.Type.NullableAnnotation == NullableAnnotation.Annotated
                || z.Component.Type.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T
            )
            .Select(z =>
                IfStatement(
                    z
                        .Component.GetAttributes()
                        .Any(w =>
                            w.AttributeClass?.ToDisplayString(NamespaceQualified)
                            == "Silk.NET.Core.HluHostedComponentAttribute"
                        )
                        ? GetRegistryTryGetOrAddAndGetComponent(
                            z.Component.Type,
                            compIdx,
                            ctorIdx,
                            z.PIdx,
                            semanticModel
                        )
                        : GetRegistryTryGetDependency(
                            z.Component.Type,
                            compIdx,
                            ctorIdx,
                            z.PIdx,
                            semanticModel
                        ),
                    ExpressionStatement(
                        AssignmentExpression(
                            SyntaxKind.SimpleAssignmentExpression,
                            IdentifierName($"dep{compIdx}Ctor{ctorIdx}Param{z.PIdx}"),
                            IdentifierName($"dep{compIdx}Ctor{ctorIdx}Param{z.PIdx}Opt")
                        )
                    )
                )
            );

    private static IEnumerable<StatementSyntax> GetRegistryConfigureMandatoryDependencies(
        int compIdx,
        IMethodSymbol ctor,
        int ctorIdx,
        SemanticModel semanticModel,
        IEnumerable<StatementSyntax> ifSatisfiedStatements
    ) =>
        ctor
            .Parameters.Skip(ctor.TypeParameters.Length)
            .Select((z, i) => (Component: z, PIdx: i))
            .Where(z =>
                z.Component.Type.NullableAnnotation == NullableAnnotation.NotAnnotated
                && z.Component.Type.OriginalDefinition.SpecialType != SpecialType.System_Nullable_T
            )
            .Aggregate(
                (ExpressionSyntax?)null,
                (current, x) =>
                {
                    var isComp = x
                        .Component.GetAttributes()
                        .Any(y =>
                            y.AttributeClass?.ToDisplayString(NamespaceQualified)
                            == "Silk.NET.Core.HluHostedComponentAttribute"
                        );
                    var declExpr = DeclarationExpression(
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
                            Identifier($"dep{compIdx}Ctor{ctorIdx}Param{x.PIdx}")
                        )
                    );
                    var expr = isComp
                        ? GetRegistryHostTryConfigureComponentAndTryGet(
                            x.Component.Type,
                            compIdx,
                            ctorIdx,
                            x.PIdx,
                            semanticModel,
                            declExpr
                        )
                        : ParenthesizedExpression(
                            GetRegistryTryGetDependency(
                                x.Component.Type,
                                compIdx,
                                ctorIdx,
                                x.PIdx,
                                semanticModel,
                                true,
                                declExpr
                            )
                        );
                    if (current is not null and not BinaryExpressionSyntax)
                    {
                        current = ParenthesizedExpression(current);
                    }

                    return current is null
                        ? expr
                        : BinaryExpression(SyntaxKind.LogicalAndExpression, current, expr);
                }
            )
            is not { } mandatoryGetIfCondition
            ? ifSatisfiedStatements
            : [IfStatement(mandatoryGetIfCondition, Block(ifSatisfiedStatements))];

    private static ExpressionSyntax GetRegistryTryGetOrAddAndGetComponent(
        ITypeSymbol compType,
        int compIdx,
        int ctorIdx,
        int pIdx,
        SemanticModel semanticModel,
        ExpressionSyntax? argument = null
    ) =>
        BinaryExpression(
            SyntaxKind.LogicalOrExpression,
            GetRegistryTryGetDependency(
                compType,
                compIdx,
                ctorIdx,
                pIdx,
                semanticModel,
                false,
                argument
            ),
            GetRegistryHostTryConfigureComponentAndTryGet(
                compType,
                compIdx,
                ctorIdx,
                pIdx,
                semanticModel,
                argument ?? IdentifierName($"dep{compIdx}Ctor{ctorIdx}Param{pIdx}Opt")
            )
        );

    private static ReturnStatementSyntax GetRegistryTrySetConfiguredComponent(
        AttributeSyntax attr,
        int compIdx,
        IMethodSymbol ctor,
        int ctorIdx
    ) =>
        ReturnStatement(
            InvocationExpression(
                ctor.TypeParameters.Length > 0
                    ? MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        ParseTypeName(
                            ctor.ContainingType.ToDisplayString(
                                SymbolDisplayFormat.FullyQualifiedFormat
                            )
                        ),
                        GenericName(
                            Identifier(ctor.Name),
                            TypeArgumentList(
                                SingletonSeparatedList<TypeSyntax>(IdentifierName("THost"))
                            )
                        )
                    )
                    : MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("dest"),
                        ((GenericNameSyntax)attr.Name).WithIdentifier(Identifier("TrySet"))
                    ),
                ArgumentList(
                    SingletonSeparatedList(
                        Argument(
                            ObjectCreationExpression(
                                ((GenericNameSyntax)attr.Name).TypeArgumentList.Arguments[1],
                                ArgumentList(
                                    SeparatedList(
                                        ctor.Parameters.Select(
                                            (_, pIdx) =>
                                                Argument(
                                                    IdentifierName(
                                                        (pIdx, ctor.TypeParameters.Length) is (0, 1)
                                                            ? "dest"
                                                            : $"dep{compIdx}Ctor{ctorIdx}Param{pIdx}"
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
            )
        );

    private static InvocationExpressionSyntax GetRegistryTryGetDependency(
        ITypeSymbol compType,
        int compIdx,
        int ctorIdx,
        int pIdx,
        SemanticModel semanticModel,
        bool configuration = true,
        ExpressionSyntax? argument = null
    ) =>
        InvocationExpression(
            MemberAccessExpression(
                SyntaxKind.SimpleMemberAccessExpression,
                IdentifierName(configuration ? "config" : "dest"),
                GenericName(
                    Identifier(configuration ? "TryGetConfiguration" : "TryGet"),
                    TypeArgumentList(
                        SingletonSeparatedList(
                            NotNull(
                                ParseTypeName(
                                    SymbolDisplay.ToMinimalDisplayString(
                                        compType,
                                        semanticModel,
                                        0,
                                        SymbolDisplayFormat.FullyQualifiedFormat
                                    )
                                )
                            )
                        )
                    )
                )
            ),
            ArgumentList(
                SingletonSeparatedList(
                    Argument(
                        null,
                        Token(SyntaxKind.OutKeyword),
                        argument
                            ?? DeclarationExpression(
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
                                    Identifier($"dep{compIdx}Ctor{ctorIdx}Param{pIdx}Opt")
                                )
                            )
                    )
                )
            )
        );

    private static ParenthesizedExpressionSyntax GetRegistryHostTryConfigureComponentAndTryGet(
        ITypeSymbol compType,
        int compIdx,
        int ctorIdx,
        int pIdx,
        SemanticModel semanticModel,
        ExpressionSyntax? argument = null
    ) =>
        ParenthesizedExpression(
            BinaryExpression(
                SyntaxKind.LogicalAndExpression,
                InvocationExpression(
                    MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("TRegistry"),
                        GenericName(
                            Identifier("TryConfigureComponent"),
                            TypeArgumentList(
                                SeparatedList(
                                    [
                                        NotNull(
                                            ParseTypeName(
                                                SymbolDisplay.ToMinimalDisplayString(
                                                    compType,
                                                    semanticModel,
                                                    0,
                                                    SymbolDisplayFormat.FullyQualifiedFormat
                                                )
                                            )
                                        ),
                                        IdentifierName("THost"),
                                        IdentifierName("TConfiguration"),
                                        IdentifierName("TRegistry")
                                    ]
                                )
                            )
                        )
                    ),
                    ArgumentList(
                        SeparatedList(
                            [Argument(IdentifierName("dest")), Argument(IdentifierName("config"))]
                        )
                    )
                ),
                GetRegistryTryGetDependency(
                    compType,
                    compIdx,
                    ctorIdx,
                    pIdx,
                    semanticModel,
                    false,
                    argument
                )
            )
        );

    private static TypeSyntax NotNull(TypeSyntax syn) =>
        syn switch
        {
            NullableTypeSyntax nullableTypeSyntax => nullableTypeSyntax.ElementType,
            PointerTypeSyntax pointerTypeSyntax
                => pointerTypeSyntax.WithElementType(NotNull(pointerTypeSyntax.ElementType)),
            RefTypeSyntax refTypeSyntax => refTypeSyntax.WithType(NotNull(refTypeSyntax.Type)),
            ScopedTypeSyntax scopedTypeSyntax
                => scopedTypeSyntax.WithType(NotNull(scopedTypeSyntax.Type)),
            _ => syn
        };
}
