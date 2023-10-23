// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public partial class NativeApiGenerator
    {
        private Dictionary<INamedTypeSymbol, Func<ImmutableArray<TypedConstant>, (int, string, INativeContextOverride)?>>
            _nativeContextAttributes =
                new(SymbolEqualityComparer.Default);
    
        private void ProcessNativeContextOverrides
        (
            EntryPoint[] entrypoints,
            ref List<MemberDeclarationSyntax> members,
            ITypeSymbol classSymbol,
            INamedTypeSymbol excludeFromOverrideAttribute,
            Compilation comp,
            ref List<(string Class, int Override)> overrideLog
        )
        {
            var overrides = FindNativeContextOverrides(classSymbol);

            StatementSyntax last = ReturnStatement
            (
                ObjectCreationExpression(
                        QualifiedName(
                            QualifiedName(
                                QualifiedName(
                                    QualifiedName(
                                        IdentifierName("Silk"),
                                        IdentifierName("NET")),
                                    IdentifierName("Core")),
                                IdentifierName("Contexts")),
                            IdentifierName("DefaultNativeContext")))
                    .WithArgumentList(
                        ArgumentList(
                            SingletonSeparatedList(
                                Argument(
                                    IdentifierName("n")))))
            );

            StatementSyntax arrLast = IfStatement
            (
                InvocationExpression
                (
                    ParseName("Silk.NET.Core.Contexts.DefaultNativeContext.TryCreate"),
                    ArgumentList
                    (
                        SeparatedList
                        (
                            new []
                            {
                                Argument(IdentifierName("name")),
                                Argument
                                (
                                    null,
                                    Token(SyntaxKind.OutKeyword),
                                    DeclarationExpression
                                    (
                                        IdentifierName("DefaultNativeContext"),
                                        SingleVariableDesignation(Identifier("context"))
                                    )
                                )
                            }
                        )
                    )
                ),
                ReturnStatement(IdentifierName("context"))
            );

            foreach (var (attSymbol, attId, lib, @override) in overrides.OrderBy(x => x.Item2))
            {
                overrideLog.Add((classSymbol.ToDisplayString(), attId));
                var name = NameGenerator.Name($"OVERRIDE_{attId}");
                members.Add(@override.Type(new(name, lib, entrypoints.Where(x => x.SourceSymbol.GetAttributes()
                    .All(x2 =>
                    {
                        if (!SymbolEqualityComparer.Default.Equals(x2.AttributeClass, excludeFromOverrideAttribute))
                            return true;

                        var matchId = (int) x2.ConstructorArguments[0].Value!;
                        return matchId != attId;
                    })).ToArray(), comp.SyntaxTrees?.FirstOrDefault()?.IsNet5OrGreater() ?? false)));

                arrLast = IfStatement
                (
                    BinaryExpression
                    (
                        SyntaxKind.LogicalAndExpression,
                        MemberAccessExpression
                        (
                            SyntaxKind.SimpleMemberAccessExpression,
                            IdentifierName("SilkTouchRuntimeConfiguration"),
                            IdentifierName($"{classSymbol.ToDisplayString().Replace(".", "")}PInvokeOverride{attId}")
                        ),
                        BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, IdentifierName("name"),
                            LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(lib))
                        )
                    ),
                    ReturnStatement(ObjectCreationExpression(IdentifierName(name), ArgumentList(), null)),
                    ElseClause(arrLast)
                );

                last = IfStatement
                (
                    BinaryExpression
                    (
                        SyntaxKind.LogicalAndExpression,
                        MemberAccessExpression
                        (
                            SyntaxKind.SimpleMemberAccessExpression,
                            IdentifierName("SilkTouchRuntimeConfiguration"),
                            IdentifierName($"{classSymbol.ToDisplayString().Replace(".", "")}PInvokeOverride{attId}")
                        ),
                        BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, IdentifierName("n"),
                            LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(lib))
                        )
                    ),
                    ReturnStatement(ObjectCreationExpression(IdentifierName(name), ArgumentList(), null)),
                    ElseClause(last)
                );
            }

            members.Add
            (
                MethodDeclaration(IdentifierName("INativeContext"), Identifier("CreateDefaultContext"))
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)))
                    .WithParameterList
                    (
                        ParameterList
                        (
                            SingletonSeparatedList
                                (Parameter(Identifier("n")).WithType(PredefinedType(Token(SyntaxKind.StringKeyword))))
                        )
                    )
                    .WithBody(Block(last))
                .WithAttributeLists(
                    SingletonList
                    (
                        AttributeList
                        (
                            SingletonSeparatedList
                            (
                                Attribute
                                (
                                    ParseName("System.ObsoleteAttribute"),
                                    AttributeArgumentList
                                    (
                                        SingletonSeparatedList
                                        (
                                            AttributeArgument
                                            (
                                                LiteralExpression(SyntaxKind.StringLiteralExpression,
                                                Literal("This function is obsolete! Please use the string[] overload!")
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    )
                ))
            );

            //wrap arrLast into its foreach loop
            //eg `foreach(string name in n)`
            arrLast = ForEachStatement(PredefinedType(Token(SyntaxKind.StringKeyword)), Identifier("name"), IdentifierName("n"), Block(arrLast));

            members.Add
            (
                MethodDeclaration(IdentifierName("INativeContext"), Identifier("CreateDefaultContext"))
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)))
                    .WithParameterList
                    (
                        ParameterList
                        (
                            SingletonSeparatedList
                            (Parameter(Identifier("n")).WithType(ArrayType(PredefinedType(Token(SyntaxKind.StringKeyword)), SingletonList(ArrayRankSpecifier()))))
                        )
                    )
                .WithBody
                (
                    Block
                    (
                        arrLast,
                        ThrowStatement
                        (
                            ObjectCreationExpression(IdentifierName("System.IO.FileNotFoundException"))
                                .WithArgumentList
                                (
                                    ArgumentList
                                    (
                                        SingletonSeparatedList
                                        (
                                            Argument
                                            (
                                                LiteralExpression
                                                (
                                                    SyntaxKind.StringLiteralExpression,
                                                    Literal("Could not load from any of the possible library names! Please make sure that the library is installed and in the right place!")
                                                )
                                            )
                                        )
                                    )
                                )
                        )
                    )
                )
            );
        }

        private IEnumerable<(INamedTypeSymbol, int, string, INativeContextOverride)> FindNativeContextOverrides(ITypeSymbol symbol)
        {
            var attributes = symbol.GetAttributes();
            foreach (var attribute in attributes)
            {
                if (attribute.AttributeClass is null) continue;

                if (_nativeContextAttributes.TryGetValue(attribute.AttributeClass, out var f))
                {
                    var v = f(attribute.ConstructorArguments);
                    if (v.HasValue)
                        yield return (attribute.AttributeClass, v.Value.Item1, v.Value.Item2, v.Value.Item3);
                }
            }
        }
    }
}
