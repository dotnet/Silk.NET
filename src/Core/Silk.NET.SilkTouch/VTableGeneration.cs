// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public partial class NativeApiGenerator
    {
        private TypeDeclarationSyntax GenerateVTable
            (bool preloadVTable, Dictionary<int, string> entryPoints, bool emitAssert, bool vNext)
        {
            var vTableMembers = new List<MemberDeclarationSyntax>();

            var initializeStatements = new List<StatementSyntax>();

            if (!preloadVTable)
            {
                vTableMembers.Add
                (
                    FieldDeclaration
                    (
                        List<AttributeListSyntax>(),
                        TokenList(Token(SyntaxKind.PrivateKeyword)),
                        VariableDeclaration
                        (
                            IdentifierName("Silk.NET.Core.Contexts.INativeContext"),
                            SingletonSeparatedList(VariableDeclarator("_ctx"))
                        )
                    )
                );

                initializeStatements.Add
                (
                    ExpressionStatement
                    (
                        AssignmentExpression
                        (
                            SyntaxKind.SimpleAssignmentExpression, IdentifierName("_ctx"),
                            IdentifierName("ctx")
                        )
                    )
                );
            }
            else
            {
                initializeStatements.AddRange
                (
                    entryPoints.Values.Distinct()
                        .Select
                        (
                            entryPoint => ExpressionStatement
                            (
                                AssignmentExpression
                                (
                                    SyntaxKind.SimpleAssignmentExpression,
                                    IdentifierName($"_{entryPoint}"),
                                    InvocationExpression
                                    (
                                        MemberAccessExpression
                                        (
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            IdentifierName("ctx"),
                                            IdentifierName("GetProcAddress")
                                        ),
                                        ArgumentList
                                        (
                                            SingletonSeparatedList
                                            (
                                                Argument
                                                (
                                                    LiteralExpression
                                                    (
                                                        SyntaxKind.StringLiteralExpression,
                                                        Literal(entryPoint)
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

            vTableMembers.Add
            (
                MethodDeclaration
                        (PredefinedType(Token(SyntaxKind.VoidKeyword)), "Initialize")
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
                                            (Identifier("ctx"))
                                        .WithType
                                            (IdentifierName("Silk.NET.Core.Contexts.INativeContext")),
                                    Parameter
                                            (Identifier("maxSlots"))
                                        .WithType
                                            (PredefinedType(Token(SyntaxKind.IntKeyword)))
                                }
                            )
                        )
                    )
                    .WithBody(Block(initializeStatements))
            );

            List<VariableDeclaratorSyntax> slotVars = new List<VariableDeclaratorSyntax>();
            foreach (var entrypoint in entryPoints.Values.Distinct())
            {
                var name = $"_{entrypoint}";
                slotVars.Add(VariableDeclarator(name));
            }

            vTableMembers.Add
            (
                MethodDeclaration
                    (
                        PredefinedType(Token(SyntaxKind.VoidKeyword)),
                        "GeneratedThrowHelperInvalidSlot"
                    )
                    .WithParameterList(ParameterList())
                    .WithModifiers
                    (
                        TokenList
                        (
                            Token(SyntaxKind.PrivateKeyword),
                            Token(SyntaxKind.StaticKeyword)
                        )
                    )
                    .WithBody
                    (
                        Block
                        (
                            ThrowStatement
                            (
                                ObjectCreationExpression
                                    (
                                        QualifiedName
                                        (
                                            IdentifierName("System"),
                                            IdentifierName("InvalidOperationException")
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
                                                    LiteralExpression
                                                    (
                                                        SyntaxKind.StringLiteralExpression,
                                                        Literal("Invalid Slot")
                                                    )
                                                )
                                            )
                                        )
                                    )
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
                                                IdentifierName("System"),
                                                IdentifierName("Diagnostics")
                                            ), IdentifierName("DebuggerHidden")
                                        )
                                    )
                                )
                            )
                        )
                    )
            );

            vTableMembers.Add
            (
                FieldDeclaration
                (
                    List<AttributeListSyntax>(),
                    TokenList(Token(SyntaxKind.PrivateKeyword)),
                    VariableDeclaration
                        (IdentifierName("System.IntPtr"), SeparatedList(slotVars))
                )
            );

            vTableMembers.Add
            (
                MethodDeclaration(IdentifierName("System.IntPtr"), "Load")
                    .WithParameterList
                    (
                        ParameterList
                        (
                            SeparatedList
                            (
                                new[]
                                {
                                    Parameter
                                            (Identifier("slot"))
                                        .WithType
                                            (PredefinedType(Token(SyntaxKind.IntKeyword))),
                                    Parameter
                                            (Identifier("entryPoint"))
                                        .WithType
                                        (
                                            PredefinedType(Token(SyntaxKind.StringKeyword))
                                        )
                                }
                            )
                        )
                    )
                    .WithBody(Block(BuildLoad(ref vTableMembers, entryPoints, emitAssert, preloadVTable, vNext)))
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
            );

            vTableMembers.Add
            (
                MethodDeclaration
                        (PredefinedType(Token(SyntaxKind.VoidKeyword)), "Purge")
                    .WithParameterList(ParameterList(SeparatedList<ParameterSyntax>()))
                    .WithBody
                    (
                        Block
                        (
                            entryPoints.Values.Distinct()
                                .Select
                                (
                                    x => ExpressionStatement
                                    (
                                        AssignmentExpression
                                        (
                                            SyntaxKind.SimpleAssignmentExpression,
                                            IdentifierName($"_{x}"),
                                            DefaultExpression
                                                (IdentifierName("System.IntPtr"))
                                        )
                                    )
                                )
                        )
                    )
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
            );

            vTableMembers.Add
            (
                MethodDeclaration
                        (PredefinedType(Token(SyntaxKind.VoidKeyword)), "Dispose")
                    .WithParameterList(ParameterList(SeparatedList<ParameterSyntax>()))
                    .WithBody(Block())
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
            );

            return ClassDeclaration
            (
                List<AttributeListSyntax>(),
                TokenList
                    (Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.SealedKeyword)),
                Identifier("GeneratedVTable"), null,
                BaseList
                (
                    SingletonSeparatedList
                    (
                        (BaseTypeSyntax) SimpleBaseType
                            (IdentifierName("Silk.NET.Core.Native.IVTable"))
                    )
                ), List<TypeParameterConstraintClauseSyntax>(), List(vTableMembers)
            );
        }
        
                private IEnumerable<StatementSyntax> BuildLoad
            (ref List<MemberDeclarationSyntax> vTableMembers, Dictionary<int, string> entryPoints, bool emitAssert, bool preloadVTable, bool vNext)
        {
            const string keyName = "slot";
            
            Span<int> orderedKeys = entryPoints.Keys.OrderBy(x => x).ToArray();

            var exp = BuildSubLoad(ref vTableMembers, orderedKeys, entryPoints, emitAssert, preloadVTable, vNext);

            return new[] {ReturnStatement(InvocationExpression(exp, ArgumentList(SeparatedList(new [] { Argument(IdentifierName(keyName)), Argument(IdentifierName("entryPoint")) }))))};

            static IdentifierNameSyntax BuildSubLoad
            (
                ref List<MemberDeclarationSyntax> methods,
                ReadOnlySpan<int> keys,
                IReadOnlyDictionary<int, string> entryPoints,
                bool emitAssert, 
                bool preloadVTable,
                bool vNext
            )
            {
                var body = new List<StatementSyntax>();
                var name = $"Load_{keys[0]}_{keys[keys.Length - 1]}";
                if (keys.Length % 2 != 0)
                {
                    // uneven, load lowest
                    body.Add
                    (
                        IfStatement
                        (
                            BinaryExpression(SyntaxKind.EqualsExpression, IdentifierName(keyName), Num(keys[0])),
                            ReturnStatement
                                (InvocationExpression(BuildFinalSubLoad(ref methods, keys[0], entryPoints[keys[0]], emitAssert, preloadVTable, vNext), ArgumentList(SeparatedList(new [] { Argument(IdentifierName(keyName)), Argument(IdentifierName("entryPoint")) }))))
                        )
                    );
                    if (keys.Length > 1)
                    {
                        body.Add
                            (ReturnStatement(InvocationExpression(BuildSubLoad(ref methods, keys.Slice(1), entryPoints, emitAssert, preloadVTable, vNext), ArgumentList(SeparatedList(new [] { Argument(IdentifierName(keyName)), Argument(IdentifierName("entryPoint")) })))));
                    }
                    else
                    {
                        // throw & return default
                        body.Add
                            (ExpressionStatement(InvocationExpression(IdentifierName("GeneratedThrowHelperInvalidSlot"))));
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
                            ReturnStatement(InvocationExpression(BuildSubLoad(ref methods, lower, entryPoints, emitAssert, preloadVTable, vNext), ArgumentList(SeparatedList(new [] { Argument(IdentifierName(keyName)), Argument(IdentifierName("entryPoint")) })))),
                            ElseClause
                                (ReturnStatement(InvocationExpression(BuildSubLoad(ref methods, upper, entryPoints, emitAssert, preloadVTable, vNext), ArgumentList(SeparatedList(new [] { Argument(IdentifierName(keyName)), Argument(IdentifierName("entryPoint")) })))))
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
                                                (Identifier("entryPoint"))
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
                                                                                SyntaxKind.SimpleMemberAccessExpression,
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
                                                QualifiedName(IdentifierName("System"), IdentifierName("Diagnostics")),
                                                IdentifierName("DebuggerHidden")
                                            )
                                        )
                                    )
                                )
                            )
                        )
                );
                return IdentifierName(name);
            }

            static IdentifierNameSyntax BuildFinalSubLoad(ref List<MemberDeclarationSyntax> methods, int key, string entryPoint, bool emitAssert, bool preloadVTable, bool vNext)
            {
                var name = $"Load_Final_{key}_{entryPoint}";
                var body = new List<StatementSyntax>();
                if (emitAssert)
                    body.Add(ExpressionStatement(
                        InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            IdentifierName("System"),
                                            IdentifierName("Diagnostics")),
                                        IdentifierName("Debug")),
                                    IdentifierName("Assert")))
                            .WithArgumentList(
                                ArgumentList(
                                    SingletonSeparatedList(
                                        Argument(
                                            BinaryExpression(
                                                SyntaxKind.EqualsExpression,
                                                IdentifierName(keyName),
                                                Num(key))))))));

                var localName = $"_{entryPoint}";
                if (!preloadVTable)
                {
                    body.Add
                    (
                        IfStatement
                        (
                            BinaryExpression
                            (
                                SyntaxKind.NotEqualsExpression, IdentifierName(localName),
                                DefaultExpression(IdentifierName("System.IntPtr"))
                            ), ReturnStatement(IdentifierName(localName))
                        )
                    );

                    body.Add
                    (
                        ExpressionStatement
                        (
                            AssignmentExpression
                            (
                                SyntaxKind.SimpleAssignmentExpression, IdentifierName(localName),
                                InvocationExpression
                                (
                                    MemberAccessExpression
                                    (
                                        SyntaxKind.SimpleMemberAccessExpression, IdentifierName("_ctx"),
                                        IdentifierName("GetProcAddress")
                                    ), ArgumentList
                                    (
                                        SeparatedList
                                        (
                                            new[]
                                            {
                                                Argument(IdentifierName("entryPoint")),
                                                Argument(IdentifierName("slot"))
                                            }
                                        )
                                    )
                                )
                            )
                        )
                    );
                }

                body.Add(ReturnStatement(IdentifierName(localName)));

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
                                                (Identifier("entryPoint"))
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
                                                                                SyntaxKind.SimpleMemberAccessExpression,
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
                                                QualifiedName(IdentifierName("System"), IdentifierName("Diagnostics")),
                                                IdentifierName("DebuggerHidden")
                                            )
                                        )
                                    )
                                )
                            )
                        )
                );
                return IdentifierName(name);
            }

            static LiteralExpressionSyntax Num
                (int i)
                => LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(i));
        }
    }
}
