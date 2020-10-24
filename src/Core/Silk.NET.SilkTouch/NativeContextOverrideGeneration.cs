// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public partial class NativeApiGenerator
    {
        private Dictionary<INamedTypeSymbol, Func<ImmutableArray<TypedConstant>, (string, INativeContextOverride)?>>
            _nativeContextAttributes =
                new Dictionary<INamedTypeSymbol, Func<ImmutableArray<TypedConstant>, (string, INativeContextOverride)?>>();
    
        private void ProcessNativeContextOverrides
        (
            EntryPoint[] entrypoints,
            ref List<MemberDeclarationSyntax> members,
            ITypeSymbol classSymbol,
            ClassDeclarationSyntax classDeclaration
        )
        {
            IEnumerable<(string, INativeContextOverride)> overrides = FindNativeContextOverrides(classSymbol);

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

            int i = 0;
            foreach (var (lib, @override) in overrides)
            {
                i++;
                var name = $"OVERRIDE_{i}";
                members.Add(@override.Type(name, lib, entrypoints));
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

        private IEnumerable<(string, INativeContextOverride)> FindNativeContextOverrides(ITypeSymbol symbol)
        {
            var attributes = symbol.GetAttributes();
            foreach (var attribute in attributes)
            {
                if (attribute.AttributeClass is null) continue;
                
                if (_nativeContextAttributes.TryGetValue(attribute.AttributeClass, out var f))
                {
                    var v = f(attribute.ConstructorArguments);
                    if (v.HasValue)
                        yield return v.Value;
                }
            }
        }
    }
}
