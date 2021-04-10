// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
            (bool preloadVTable, Dictionary<int, string> entryPoints, bool emitAssert, bool vNext, string generatedVTableName)
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

            var generatedThrowHelperInvalidSlot = "GeneratedThrowHelperInvalidEntryPoint";
            vTableMembers.Add
            (
                MethodDeclaration
                    (
                        IdentifierName("nint"),
                        generatedThrowHelperInvalidSlot
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
                                                IdentifierName("System"),
                                                IdentifierName("Diagnostics")
                                            ), IdentifierName("DebuggerHidden")
                                        )
                                    )
                                )
                            )
                        )
                    )
#endif
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

            /*
             * create the obsolete legacy "Load" forward
             * looks something like:
             * Load(int slot, string entryPoint) => Load(entryPoint);
             */
            vTableMembers.Add
            (
                MethodDeclaration(IdentifierName("nint"), "Load")
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
                    .WithExpressionBody(ArrowExpressionClause(InvocationExpression(IdentifierName("Load"), ArgumentList(SingletonSeparatedList(Argument(IdentifierName("entryPoint")))))))
                    .WithBody(null)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
            );

            /*
             * create the legacy "Load"
             * looks something like:
             * Load(string entryPoint) => entryPoint switch {
             * "myEntryPoint" => MyEntryPoint
             * _ => GeneratedThrowHelperInvalidEntryPoint()
             * };
             */
            vTableMembers.Add
            (
                MethodDeclaration(IdentifierName("nint"), "Load")
                    .WithParameterList
                    (
                        ParameterList
                        (
                            SeparatedList
                            (
                                new[]
                                {
                                    Parameter
                                            (Identifier("entryPoint"))
                                        .WithType(PredefinedType(Token(SyntaxKind.StringKeyword)))
                                }
                            )
                        )
                    )
                    .WithExpressionBody
                    (
                        ArrowExpressionClause
                        (
                            SwitchExpression
                            (
                                IdentifierName("entryPoint"),
                                SeparatedList
                                (
                                    entryPoints.Values.Distinct()
                                        .Select
                                        (
                                            s => SwitchExpressionArm
                                            (
                                                ConstantPattern
                                                    (LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(s))),
                                                IdentifierName(FirstLetterToUpper(s))
                                            )
                                        )
                                )
                            )
                        )
                    )
                    .WithBody(null)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
            );
            
            /*
             * Create a property for every entryPoint like:
             * public nint MyEntryPoint => _myEntryPoint != 0 ? _myEntryPoint : (_myEntryPoint = _ctx.Load(myEntryPoint))
             */
            vTableMembers.AddRange
            (
                entryPoints.Values.Distinct().Select
                (
                    s => PropertyDeclaration
                            (IdentifierName("nint"), FirstLetterToUpper(s))
                        .WithExpressionBody
                        (
                            ArrowExpressionClause
                            (
                                ConditionalExpression
                                (
                                    BinaryExpression
                                    (
                                        SyntaxKind.NotEqualsExpression, IdentifierName("_" + s),
                                        DefaultExpression(IdentifierName("nint"))
                                    ), IdentifierName("_" + s),
                                    ParenthesizedExpression
                                    (
                                        AssignmentExpression
                                        (
                                            SyntaxKind.SimpleAssignmentExpression, IdentifierName("_" + s),
                                            InvocationExpression
                                            (
                                                IdentifierName("_ctx.GetProcAddress"),
                                                ArgumentList
                                                (
                                                    SingletonSeparatedList
                                                    (
                                                        Argument
                                                        (
                                                            LiteralExpression
                                                                (SyntaxKind.StringLiteralExpression, Literal(s))
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                        )
                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                )
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
                                                (IdentifierName("nint"))
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
                Identifier(generatedVTableName), null,
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

        private static string FirstLetterToUpper(string s)
        {
            return s.First().ToString().ToUpper() + s.Substring(1);
        }
    }
}
