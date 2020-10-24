// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.NativeContextOverrides
{
    public sealed class PInvokeNativeContextOverride : INativeContextOverride
    {
        public TypeDeclarationSyntax Type(string name, string lib, Entrypoint[] entrypoints)
        {
            static BlockSyntax GetSlotSwitch(Entrypoint[] entrypoints)
            {
                StatementSyntax last = ThrowStatement(IdentifierName("null"));

                foreach (var entrypoint in entrypoints)
                {
                    last = IfStatement
                    (
                        BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, IdentifierName("p"),
                            LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(entrypoint.Name))
                        ),
                        ReturnStatement
                        (
                            CastExpression
                            (
                                QualifiedName(IdentifierName("System"), IdentifierName("IntPtr")),
                                CastExpression
                                (
                                    FunctionPointerType
                                    (
                                        FunctionPointerCallingConvention(Token(SyntaxKind.ManagedKeyword)),
                                        FunctionPointerParameterList
                                            (SeparatedList(entrypoint.LoadTypes.Select(FunctionPointerParameter)))
                                    ),
                                    ParenthesizedExpression
                                    (
                                        PrefixUnaryExpression
                                            (SyntaxKind.AddressOfExpression, IdentifierName($"I_{entrypoint.Slot}"))
                                    )
                                )
                            )
                        ), ElseClause(last)
                    );
                }

                return Block(last);
            }

            MethodDeclarationSyntax GetMethodFromEntrypoint(Entrypoint entrypoint)
                => MethodDeclaration(entrypoint.LoadTypes.Last(), Identifier($"I_{entrypoint.Slot}"))
                    .WithAttributeLists
                    (
                        SingletonList
                        (
                            AttributeList
                            (
                                SingletonSeparatedList
                                (
                                    Attribute
                                        (
                                            QualifiedName
                                            (
                                                QualifiedName
                                                (
                                                    QualifiedName(IdentifierName("System"), IdentifierName("Runtime")),
                                                    IdentifierName("InteropServices")
                                                ), IdentifierName("DllImport")
                                            )
                                        )
                                        .WithArgumentList
                                        (
                                            AttributeArgumentList
                                            (
                                                SeparatedList<AttributeArgumentSyntax>
                                                (
                                                    new SyntaxNodeOrToken[]
                                                    {
                                                        AttributeArgument
                                                        (
                                                            LiteralExpression
                                                                (SyntaxKind.StringLiteralExpression, Literal(lib))
                                                        ),
                                                        Token(SyntaxKind.CommaToken),
                                                        AttributeArgument
                                                            (
                                                                LiteralExpression
                                                                (
                                                                    SyntaxKind.StringLiteralExpression,
                                                                    Literal(entrypoint.Name)
                                                                )
                                                            )
                                                            .WithNameEquals(NameEquals(IdentifierName("EntryPoint"))),
                                                        Token(SyntaxKind.CommaToken),
                                                        AttributeArgument
                                                            (
                                                                CastExpression
                                                                (
                                                                    QualifiedName
                                                                    (
                                                                        QualifiedName
                                                                        (
                                                                            QualifiedName
                                                                            (
                                                                                IdentifierName("System"),
                                                                                IdentifierName("Runtime")
                                                                            ), IdentifierName("InteropServices")
                                                                        ), IdentifierName("CallingConvention")
                                                                    ),
                                                                    LiteralExpression
                                                                    (
                                                                        SyntaxKind.NumericLiteralExpression,
                                                                        Literal((int) entrypoint.CallingConvention)
                                                                    )
                                                                )
                                                            )
                                                            .WithNameEquals
                                                                (NameEquals(IdentifierName("CallingConvention")))
                                                    }
                                                )
                                            )
                                        )
                                )
                            )
                        )
                    )
                    .WithModifiers
                    (
                        TokenList
                        (
                            Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.StaticKeyword),
                            Token(SyntaxKind.ExternKeyword)
                        )
                    )
                    .WithParameterList
                    (
                        ParameterList
                        (
                            SeparatedList
                            (
                                entrypoint.LoadTypes.Take
                                        (entrypoint.LoadTypes.Length - 1)
                                    .Select((x, i) => Parameter(default, default, x, Identifier($"p_{i}"), default))
                            )
                        )
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));

            return ClassDeclaration(name)
                .WithBaseList
                (
                    BaseList
                    (
                        SingletonSeparatedList<BaseTypeSyntax>
                        (
                            SimpleBaseType
                            (
                                QualifiedName
                                (
                                    QualifiedName
                                    (
                                        QualifiedName
                                        (
                                            QualifiedName(IdentifierName("Silk"), IdentifierName("NET")),
                                            IdentifierName("Core")
                                        ), IdentifierName("Contexts")
                                    ), IdentifierName("INativeContext")
                                )
                            )
                        )
                    )
                )
                .WithModifiers
                (
                    TokenList
                    (
                        Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.SealedKeyword),
                        Token(SyntaxKind.UnsafeKeyword)
                    )
                )
                .WithMembers
                (
                    List<MemberDeclarationSyntax>
                    (
                        entrypoints.Select(GetMethodFromEntrypoint)
                            .Append
                            (
                                MethodDeclaration(IdentifierName("IntPtr"), Identifier("GetProcAddress"))
                                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                    .WithParameterList
                                    (
                                        ParameterList
                                        (
                                            SeparatedList
                                            (
                                                new[]
                                                {
                                                    Parameter
                                                            (Identifier("p"))
                                                        .WithType(PredefinedType(Token(SyntaxKind.StringKeyword))),
                                                    Parameter
                                                            (Identifier("s"))
                                                        .WithType
                                                            (NullableType(PredefinedType(Token(SyntaxKind.IntKeyword))))
                                                        .WithDefault
                                                        (
                                                            EqualsValueClause
                                                            (
                                                                LiteralExpression
                                                                (
                                                                    SyntaxKind.DefaultLiteralExpression,
                                                                    Token(SyntaxKind.DefaultKeyword)
                                                                )
                                                            )
                                                        )
                                                }
                                            )
                                        )
                                    )
                                    .WithBody(GetSlotSwitch(entrypoints))
                            )
                            .Append
                            (
                                MethodDeclaration
                                        (PredefinedType(Token(SyntaxKind.VoidKeyword)), Identifier("Dispose"))
                                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                    .WithBody(Block())
                            )
                    )
                );
        }
    }
}
