// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.NativeContextOverrides
{
    public sealed class PInvokeNativeContextOverride : INativeContextOverride
    {
        /// <inheritdoc />
        public TypeDeclarationSyntax Type(string name, string lib, EntryPoint[] entrypoints)
        {
            static BlockSyntax GetSlotSwitch(EntryPoint[] entrypoints, List<MemberDeclarationSyntax> members)
            {
                members.Add(NativeContextOverrideHelper.GetProcAddress);
                members.Add(NativeContextOverrideHelper.TryGetProcAddress);
                
                return Block
                (
                    ReturnStatement
                    (
                        SwitchExpression
                        (
                            IdentifierName("p").AddLeadingSpace().AddTrailingSpace(),
                            SeparatedList
                            (
                                entrypoints.Select
                                (
                                    e => SwitchExpressionArm
                                    (
                                        ConstantPattern
                                            (LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(e.Name))),
                                        CastExpression
                                        (
                                            QualifiedName(IdentifierName("System"), IdentifierName("IntPtr")),
                                            CastExpression
                                            (
                                                FunctionPointerType
                                                (
                                                    FunctionPointerCallingConvention(Token(SyntaxKind.ManagedKeyword)),
                                                    FunctionPointerParameterList
                                                        (SeparatedList(e.LoadTypes.Select(FunctionPointerParameter)))
                                                ),
                                                ParenthesizedExpression
                                                (
                                                    PrefixUnaryExpression
                                                        (SyntaxKind.AddressOfExpression, IdentifierName($"I_{e.Name}"))
                                                )
                                            )
                                        )
                                    )
                                ).Append(SwitchExpressionArm(DiscardPattern(), DefaultExpression(IdentifierName("nint"))))
                            )
                        )
                    )
                );
            }

            MethodDeclarationSyntax GetMethodFromEntrypoint(EntryPoint entrypoint)
                => MethodDeclaration(entrypoint.LoadTypes.Last().AddTrailingSpace(), Identifier($"I_{entrypoint.Name}"))
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
                            Token(SyntaxKind.PrivateKeyword).AddTrailingSpace(),
                            Token(SyntaxKind.StaticKeyword).AddTrailingSpace(),
                            Token(SyntaxKind.ExternKeyword).AddTrailingSpace()
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
                                    .Select((x, i) => Parameter(default, default, x, Identifier($"p_{i}").AddLeadingSpace(), default))
                            )
                        )
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));

            var v = entrypoints.Distinct(new NameComparer()).ToArray();
            var members = new List<MemberDeclarationSyntax>();
            members.AddRange(v.Select(GetMethodFromEntrypoint));
            members.Add
            (
                MethodDeclaration(IdentifierName("IntPtr"), Identifier("CoreGetProcAddress").AddLeadingSpace())
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword).AddTrailingSpace()))
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
                                    .WithType(PredefinedType(Token(SyntaxKind.StringKeyword).AddTrailingSpace())),
                                    Parameter
                                            (Identifier("s"))
                                        .WithType(NullableType(PredefinedType(Token(SyntaxKind.IntKeyword).AddTrailingSpace())))
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
                    .WithBody(GetSlotSwitch(v, members))
            );
            members.Add
            (
                MethodDeclaration
                        (PredefinedType(Token(SyntaxKind.VoidKeyword).AddTrailingSpace()), Identifier("Dispose"))
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword).AddTrailingSpace()))
                    .WithBody(Block())
            );
            return ClassDeclaration(Identifier(name).AddLeadingSpace())
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
                        Token(SyntaxKind.PrivateKeyword).AddTrailingSpace(),
                        Token(SyntaxKind.SealedKeyword).AddTrailingSpace(),
                        Token(SyntaxKind.UnsafeKeyword).AddTrailingSpace()
                    )
                )
                .WithMembers
                (
                    List
                    (
                        members
                    )
                );
        }
    }

    public class NameComparer : IEqualityComparer<EntryPoint>
    {
        public bool Equals(EntryPoint x, EntryPoint y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(EntryPoint obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
