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

                var dict = entrypoints.ToDictionary(x => x.Slot, x => x);
                ReadOnlySpan<int> slots = entrypoints.Select(x => x.Slot).OrderBy(x => x).ToArray();

                return Block
                (
                    ReturnStatement
                    (
                        InvocationExpression
                        (
                            BuildSubLoad(members, slots, dict, false),
                            ArgumentList
                            (
                                SeparatedList
                                (
                                    new[]
                                    {
                                        Argument
                                        (
                                            MemberAccessExpression
                                            (
                                                SyntaxKind.SimpleMemberAccessExpression, IdentifierName("s"),
                                                IdentifierName("Value")
                                            )
                                        ),
                                        Argument(IdentifierName("p"))
                                    }
                                )
                            )
                        )
                    )
                );
                
                const string keyName = "s";
                static LiteralExpressionSyntax Num
                    (int i)
                    => LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(i));

                static IdentifierNameSyntax BuildSubLoad
                (
                    List<MemberDeclarationSyntax> methods,
                    ReadOnlySpan<int> keys,
                    Dictionary<int, EntryPoint> entryPoints,
                    bool emitAssert
                )
                {
                    var body = new List<StatementSyntax>();
                    var name = NameGenerator.Name($"Load_{keys[0]}_{keys[keys.Length - 1]}");
                    if (keys.Length % 2 != 0)
                    {
                        // uneven, load lowest
                        body.Add
                        (
                            IfStatement
                            (
                                BinaryExpression(SyntaxKind.EqualsExpression, IdentifierName(keyName), Num(keys[0])),
                                ReturnStatement
                                (
                                    InvocationExpression
                                    (
                                        BuildFinalSubLoad(methods, entryPoints[keys[0]], emitAssert),
                                        ArgumentList
                                        (
                                            SeparatedList
                                            (
                                                new[] {Argument(IdentifierName(keyName)), Argument(IdentifierName("p"))}
                                            )
                                        )
                                    )
                                )
                            )
                        );
                        if (keys.Length > 1)
                        {
                            body.Add
                            (
                                ReturnStatement
                                (
                                    InvocationExpression
                                    (
                                        BuildSubLoad(methods, keys.Slice(1), entryPoints, emitAssert),
                                        ArgumentList
                                        (
                                            SeparatedList
                                            (
                                                new[] {Argument(IdentifierName(keyName)), Argument(IdentifierName("p"))}
                                            )
                                        )
                                    )
                                )
                            );
                        }
                        else
                        {
                            // return default
                            body.Add(ReturnStatement(DefaultExpression(IdentifierName("System.IntPtr"))));
                        }
                    }
                    else
                    {
                        // even, but not one, split.
                        var halfIndex = keys.Length / 2;
                        var lower = keys.Slice(0, halfIndex);
                        var upper = keys.Slice(halfIndex);
                        var midKey = keys[halfIndex];

                        body.Add
                        (
                            IfStatement
                            (
                                BinaryExpression(SyntaxKind.LessThanExpression, IdentifierName(keyName), Num(midKey)),
                                ReturnStatement
                                (
                                    InvocationExpression
                                    (
                                        BuildSubLoad(methods, lower, entryPoints, emitAssert),
                                        ArgumentList
                                        (
                                            SeparatedList
                                            (
                                                new[] {Argument(IdentifierName(keyName)), Argument(IdentifierName("p"))}
                                            )
                                        )
                                    )
                                ),
                                ElseClause
                                (
                                    ReturnStatement
                                    (
                                        InvocationExpression
                                        (
                                            BuildSubLoad(methods, upper, entryPoints, emitAssert),
                                            ArgumentList
                                            (
                                                SeparatedList
                                                (
                                                    new[]
                                                    {
                                                        Argument(IdentifierName(keyName)), Argument(IdentifierName("p"))
                                                    }
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                        );
                    }

                    methods.Add
                    (
                        MethodDeclaration
                                (QualifiedName(IdentifierName("System"), IdentifierName("IntPtr")), Identifier(name))
                            .WithParameterList
                            (
                                ParameterList
                                (
                                    SeparatedList
                                    (
                                        new[]
                                        {
                                            Parameter
                                                    (Identifier(keyName))
                                                .WithType(PredefinedType(Token(SyntaxKind.IntKeyword))),
                                            Parameter
                                                    (Identifier("p"))
                                                .WithType(PredefinedType(Token(SyntaxKind.StringKeyword)))
                                        }
                                    )
                                )
                            )
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
                                                            QualifiedName
                                                                (IdentifierName("System"), IdentifierName("Runtime")),
                                                            IdentifierName("CompilerServices")
                                                        ), IdentifierName("MethodImpl")
                                                    )
                                                )

                                                #region [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]

                                                .WithArgumentList
                                                (
                                                    AttributeArgumentList
                                                    (
                                                        SingletonSeparatedList
                                                        (
                                                            AttributeArgument
                                                            (
                                                                BinaryExpression
                                                                (
                                                                    SyntaxKind.BitwiseOrExpression,
                                                                    MemberAccessExpression
                                                                    (
                                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                                        MemberAccessExpression
                                                                        (
                                                                            SyntaxKind.SimpleMemberAccessExpression,
                                                                            MemberAccessExpression
                                                                            (
                                                                                SyntaxKind.SimpleMemberAccessExpression,
                                                                                MemberAccessExpression
                                                                                (
                                                                                    SyntaxKind
                                                                                        .SimpleMemberAccessExpression,
                                                                                    IdentifierName("System"),
                                                                                    IdentifierName("Runtime")
                                                                                ), IdentifierName("CompilerServices")
                                                                            ), IdentifierName("MethodImplOptions")
                                                                        ), IdentifierName("AggressiveInlining")
                                                                    ),
                                                                    CastExpression
                                                                    (
                                                                        IdentifierName
                                                                        (
                                                                            "System.Runtime.CompilerServices.MethodImplOptions"
                                                                        ), Num(512)
                                                                    )
                                                                )
                                                            )
                                                        )
                                                    )
                                                )

                                            #endregion

                                        )
                                    )
                                )
                            )
                            .WithModifiers(TokenList(Token(SyntaxKind.PrivateKeyword)))
                            .WithBody
                            (
                                Block(body)
                            )
#if !DEBUG
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
                                                        IdentifierName("System"), IdentifierName("Diagnostics")
                                                    ),
                                                    IdentifierName("DebuggerHidden")
                                                )
                                            )
                                        )
                                    )
                                )
                            )
#endif
                    );
                    return IdentifierName(name);
                }

                static IdentifierNameSyntax BuildFinalSubLoad
                    (List<MemberDeclarationSyntax> methods, EntryPoint entrypoint, bool emitAssert)
                {
                    var name = NameGenerator.Name($"Load_Final_{entrypoint.Slot}_{entrypoint.Name}");
                    var body = new List<StatementSyntax>();
                    if (emitAssert)
                        body.Add
                        (
                            ExpressionStatement
                            (
                                InvocationExpression
                                    (
                                        MemberAccessExpression
                                        (
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            MemberAccessExpression
                                            (
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                MemberAccessExpression
                                                (
                                                    SyntaxKind.SimpleMemberAccessExpression, IdentifierName("System"),
                                                    IdentifierName("Diagnostics")
                                                ), IdentifierName("Debug")
                                            ), IdentifierName("Assert")
                                        )
                                    )
                                    .WithArgumentList
                                    (
                                        ArgumentList
                                        (
                                            SingletonSeparatedList
                                            (
                                                Argument
                                                (
                                                    BinaryExpression
                                                        (SyntaxKind.EqualsExpression, IdentifierName(keyName), Num(entrypoint.Slot))
                                                )
                                            )
                                        )
                                    )
                            )
                        );

                    body.Add
                    (
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
                        )
                    );

                    methods.Add
                    (
                        MethodDeclaration
                                (QualifiedName(IdentifierName("System"), IdentifierName("IntPtr")), Identifier(name))
                            .WithParameterList
                            (
                                ParameterList
                                (
                                    SeparatedList
                                    (
                                        new[]
                                        {
                                            Parameter
                                                    (Identifier(keyName))
                                                .WithType(PredefinedType(Token(SyntaxKind.IntKeyword))),
                                            Parameter
                                                    (Identifier("p"))
                                                .WithType(PredefinedType(Token(SyntaxKind.StringKeyword)))
                                        }
                                    )
                                )
                            )
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
                                                            QualifiedName
                                                                (IdentifierName("System"), IdentifierName("Runtime")),
                                                            IdentifierName("CompilerServices")
                                                        ), IdentifierName("MethodImpl")
                                                    )
                                                )

                                                #region [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]

                                                .WithArgumentList
                                                (
                                                    AttributeArgumentList
                                                    (
                                                        SingletonSeparatedList
                                                        (
                                                            AttributeArgument
                                                            (
                                                                BinaryExpression
                                                                (
                                                                    SyntaxKind.BitwiseOrExpression,
                                                                    MemberAccessExpression
                                                                    (
                                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                                        MemberAccessExpression
                                                                        (
                                                                            SyntaxKind.SimpleMemberAccessExpression,
                                                                            MemberAccessExpression
                                                                            (
                                                                                SyntaxKind.SimpleMemberAccessExpression,
                                                                                MemberAccessExpression
                                                                                (
                                                                                    SyntaxKind
                                                                                        .SimpleMemberAccessExpression,
                                                                                    IdentifierName("System"),
                                                                                    IdentifierName("Runtime")
                                                                                ), IdentifierName("CompilerServices")
                                                                            ), IdentifierName("MethodImplOptions")
                                                                        ), IdentifierName("AggressiveInlining")
                                                                    ),
                                                                    CastExpression
                                                                    (
                                                                        IdentifierName
                                                                        (
                                                                            "System.Runtime.CompilerServices.MethodImplOptions"
                                                                        ), Num(512)
                                                                    )
                                                                )
                                                            )
                                                        )
                                                    )
                                                )

                                            #endregion

                                        )
                                    )
                                )
                            )
                            .WithModifiers(TokenList(Token(SyntaxKind.PrivateKeyword)))
                            .WithBody(Block(body))
#if !DEBUG
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
                                                        (IdentifierName("System"), IdentifierName("Diagnostics")),
                                                    IdentifierName("DebuggerHidden")
                                                )
                                            )
                                        )
                                    )
                                )
                            )
#endif
                    );
                    return IdentifierName(name);
                }
            }

            MethodDeclarationSyntax GetMethodFromEntrypoint(EntryPoint entrypoint)
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

            var members = new List<MemberDeclarationSyntax>();
            members.AddRange(entrypoints.Select(GetMethodFromEntrypoint));
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
                    .WithBody(GetSlotSwitch(entrypoints, members))
            );
            members.Add
            (
                MethodDeclaration
                        (PredefinedType(Token(SyntaxKind.VoidKeyword)), Identifier("Dispose"))
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                    .WithBody(Block())
            );
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
                    List
                    (
                        members
                    )
                );
        }
    }
}
