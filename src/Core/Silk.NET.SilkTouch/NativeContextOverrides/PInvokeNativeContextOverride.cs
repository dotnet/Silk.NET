// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using static Silk.NET.SilkTouch.NameGenerator;

namespace Silk.NET.SilkTouch.NativeContextOverrides
{
    public sealed class PInvokeNativeContextOverride : INativeContextOverride
    {
        /// <inheritdoc />
        public TypeDeclarationSyntax Type(OverrideContext ctx)
        {
            var canUseCorrectCallConv = ctx.IsNet5OrGreater;
            static BlockSyntax GetSlotSwitch(EntryPoint[] entrypoints, List<MemberDeclarationSyntax> members, bool canUseCorrectCallConv)
            {
                members.Add(NativeContextOverrideHelper.GetProcAddress);
                members.Add(NativeContextOverrideHelper.TryGetProcAddress);
                return Block
                (
                    ReturnStatement
                    (
                        SwitchExpression
                        (
                            IdentifierName("p"),
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
                                                canUseCorrectCallConv
                                                    ? e.LoadTypes.GetFuncPtrType(e.CallingConvention)
                                                    : e.LoadTypes.GetFuncPtrType(null),
                                                ParenthesizedExpression
                                                (
                                                    PrefixUnaryExpression
                                                    (
                                                        SyntaxKind.AddressOfExpression,
                                                        IdentifierSilk
                                                        (
                                                            canUseCorrectCallConv 
                                                                ? $"S_{e.Name}"
                                                                : $"I_{e.Name}"
                                                        )
                                                    )
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

            MethodDeclarationSyntax GetMethodFromEntrypoint(EntryPoint entrypoint, bool callConvCorrection = false)
            {
                var ret = MethodDeclaration
                (
                    entrypoint.LoadTypes.Last(),
                    Identifier(Name(callConvCorrection ? $"S_{entrypoint.Name}" : $"I_{entrypoint.Name}"))
                )
                .WithAttributeLists
                (
                    SingletonList
                    (
                        AttributeList
                        (
                            SingletonSeparatedList
                            (
                                callConvCorrection
                                    ? Attribute
                                        (
                                            QualifiedName
                                            (
                                                QualifiedName
                                                (
                                                    QualifiedName
                                                        (IdentifierName("System"), IdentifierName("Runtime")),
                                                    IdentifierName("InteropServices")
                                                ), IdentifierName("UnmanagedCallersOnly")
                                            )
                                        )
                                        .WithArgumentList
                                        (
                                            AttributeArgumentList
                                            (
                                                SeparatedList<AttributeArgumentSyntax>
                                                (
                                                    entrypoint.CallingConvention == CallingConvention.Winapi
                                                        ? Array.Empty<SyntaxNodeOrToken>()
                                                        : new SyntaxNodeOrToken[]
                                                        {
                                                            AttributeArgument
                                                                (
                                                                    ImplicitArrayCreationExpression
                                                                    (
                                                                        InitializerExpression
                                                                        (
                                                                            SyntaxKind.ArrayInitializerExpression,
                                                                            SingletonSeparatedList<ExpressionSyntax>
                                                                            (
                                                                                TypeOfExpression
                                                                                (
                                                                                    QualifiedName
                                                                                    (
                                                                                        QualifiedName
                                                                                        (
                                                                                            QualifiedName
                                                                                            (
                                                                                                IdentifierName
                                                                                                    ("System"),
                                                                                                IdentifierName
                                                                                                    ("Runtime")
                                                                                            ),
                                                                                            IdentifierName
                                                                                                ("CompilerServices")
                                                                                        ),
                                                                                        IdentifierName
                                                                                        (
                                                                                            "CallConv" +
                                                                                            entrypoint.CallingConvention
                                                                                                .GetCallingConvention()
                                                                                        )
                                                                                    )
                                                                                )
                                                                            )
                                                                        )
                                                                    )
                                                                )
                                                                .WithNameEquals(NameEquals(IdentifierName("CallConvs")))
                                                        }
                                                )
                                            )
                                        )
                                    : Attribute
                                        (
                                            QualifiedName
                                            (
                                                QualifiedName
                                                (
                                                    QualifiedName
                                                        (IdentifierName("System"), IdentifierName("Runtime")),
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
                                                            (
                                                                SyntaxKind.StringLiteralExpression,
                                                                Literal(ctx.Library)
                                                            )
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
                                                            .WithNameEquals
                                                                (NameEquals(IdentifierName("EntryPoint"))),
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
                    callConvCorrection
                        ? TokenList(Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.StaticKeyword))
                        : TokenList
                        (
                            Token(SyntaxKind.PrivateKeyword),
                            Token(SyntaxKind.StaticKeyword),
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
                                .Select((x, i) => Parameter(default, default, x, Identifier($"p{i}"), default))
                        )
                    )
                );

                if (callConvCorrection)
                {
                    ret = ret.WithExpressionBody
                    (
                        ArrowExpressionClause
                        (
                            InvocationExpression
                            (
                                IdentifierSilk($"I_{entrypoint.Name}"),
                                ArgumentList
                                (
                                    SeparatedList
                                    (
                                        entrypoint.LoadTypes.Take(entrypoint.LoadTypes.Length - 1)
                                            .Select((_, i) => Argument(IdentifierName($"p{i}")))
                                    )
                                )
                            )
                        )
                    );
                }

                return ret.WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            }

            var v = ctx.EntryPoints.Distinct(new NameComparer()).ToArray();
            var members = new List<MemberDeclarationSyntax>();
            members.AddRange(v.Select(x => GetMethodFromEntrypoint(x)));
            if (canUseCorrectCallConv)
            {
                members.AddRange(v.Select(x => GetMethodFromEntrypoint(x, true)));
            }

            members.Add
            (
                MethodDeclaration(IdentifierName("IntPtr"), Identifier("CoreGetProcAddress"))
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
                                        .WithType(NullableType(PredefinedType(Token(SyntaxKind.IntKeyword))))
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
                    .WithBody(GetSlotSwitch(v, members, canUseCorrectCallConv))
            );
            members.Add
            (
                MethodDeclaration
                        (PredefinedType(Token(SyntaxKind.VoidKeyword)), Identifier("Dispose"))
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                    .WithBody(Block())
            );
            return ClassDeclaration(ctx.Name)
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
