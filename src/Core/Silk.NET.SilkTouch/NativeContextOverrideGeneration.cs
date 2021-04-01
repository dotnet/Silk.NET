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
            INamedTypeSymbol excludeFromOverrideAttribute
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

            foreach (var (attSymbol, attId, lib, @override) in overrides.OrderBy(x => x.Item2))
            {
                var name = $"OVERRIDE_{attId}";
                members.Add(@override.Type(name, lib, entrypoints.Where(x => x.SourceSymbol.GetAttributes()
                    .All(x2 =>
                    {
                        if (!SymbolEqualityComparer.Default.Equals(x2.AttributeClass, excludeFromOverrideAttribute))
                            return true;

                        var matchId = (int) x2.ConstructorArguments[0].Value!;
                        return matchId != attId;
                    })).ToArray()));
                last = IfStatement
                (
                    BinaryExpression
                    (
                        SyntaxKind.EqualsExpression, IdentifierName("n"),
                        LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(lib))
                    ), ReturnStatement(ObjectCreationExpression(IdentifierName(name), ArgumentList(), null)),
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
