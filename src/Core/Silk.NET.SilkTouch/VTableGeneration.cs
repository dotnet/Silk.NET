// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using static Silk.NET.SilkTouch.NameGenerator;

namespace Silk.NET.SilkTouch
{
    public partial class NativeApiGenerator
    {
        private TypeDeclarationSyntax GenerateVTable
            (bool preloadVTable, List<string> entryPoints, bool emitAssert, bool vNext, string generatedVTableName)
        {
            var vTableMembers = new List<MemberDeclarationSyntax>();

            var constructorStatements = new List<StatementSyntax>();

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

            constructorStatements.Add
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

            if (preloadVTable)
            {
                constructorStatements.AddRange
                (
                    entryPoints.Distinct()
                        .Select
                        (
                            entryPoint => ExpressionStatement
                            (
                                AssignmentExpression
                                (
                                    SyntaxKind.SimpleAssignmentExpression,
                                    IdentifierSilk($"_{entryPoint}"),
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
                ConstructorDeclaration(Name("GeneratedVTable"))
                    .WithModifiers(TokenList(Token(SyntaxKind.InternalKeyword)))
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
                                            (IdentifierName("Silk.NET.Core.Contexts.INativeContext"))
                                }
                            )
                        )
                    )
                    .WithBody(Block(constructorStatements))
            );

            List<VariableDeclaratorSyntax> slotVars = new List<VariableDeclaratorSyntax>();
            foreach (var entrypoint in entryPoints.Distinct())
            {
                slotVars.Add(VariableDeclarator(Name($"_{entrypoint}")));
            }

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
                                    entryPoints.Distinct()
                                        .Select
                                        (
                                            s => SwitchExpressionArm
                                            (
                                                ConstantPattern
                                                    (LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(s))),
                                                IdentifierSilk(s)
                                            )
                                        )
                                        .Append
                                        (
                                            SwitchExpressionArm
                                            (
                                                DiscardPattern(),
                                                InvocationExpression
                                                (
                                                    IdentifierName("_ctx.GetProcAddress"),
                                                    ArgumentList
                                                    (
                                                        SingletonSeparatedList
                                                        (
                                                            Argument
                                                            (
                                                                IdentifierName("entryPoint")
                                                            )
                                                        )
                                                    )
                                                )
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
                entryPoints.Distinct().Select
                (
                    s => PropertyDeclaration(IdentifierName("nint"), Name(s))
                        .WithExpressionBody
                        (
                            ArrowExpressionClause
                            (
                                ConditionalExpression
                                (
                                    BinaryExpression
                                    (
                                        SyntaxKind.NotEqualsExpression, IdentifierSilk("_" + s),
                                        DefaultExpression(IdentifierName("nint"))
                                    ), IdentifierSilk("_" + s),
                                    ParenthesizedExpression
                                    (
                                        AssignmentExpression
                                        (
                                            SyntaxKind.SimpleAssignmentExpression, IdentifierSilk("_" + s),
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
                            entryPoints.Distinct()
                                .Select
                                (
                                    x => ExpressionStatement
                                    (
                                        AssignmentExpression
                                        (
                                            SyntaxKind.SimpleAssignmentExpression,
                                            IdentifierSilk($"_{x}"),
                                            DefaultExpression
                                                (IdentifierName("nint"))
                                        )
                                    )
                                )
                        )
                    )
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
            );

            var p = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "silktouch.lock");
            if (!File.Exists(p))
            {
                File.WriteAllText(p, "");
                Debugger.Launch();
            }

            vTableMembers.Add
            (
                MethodDeclaration(IdentifierName("IVTable"), Identifier("Clone"))
                    .WithParameterList(ParameterList(SeparatedList<ParameterSyntax>()))
                    .WithBody
                    (
                        Block
                        (
                            LocalDeclarationStatement
                            (
                                VariableDeclaration
                                (
                                    IdentifierName
                                    (
                                        Identifier
                                        (
                                            TriviaList(),
                                            SyntaxKind.VarKeyword,
                                            "var",
                                            "var",
                                            TriviaList()
                                        )
                                    ),
                                    SingletonSeparatedList
                                    (
                                        VariableDeclarator(Identifier("ret"))
                                            .WithInitializer
                                            (
                                                EqualsValueClause
                                                (
                                                    ObjectCreationExpression(IdentifierName(generatedVTableName))
                                                        .WithArgumentList
                                                        (
                                                            ArgumentList
                                                            (
                                                                SingletonSeparatedList(Argument(IdentifierName("_ctx")))
                                                            )
                                                        )
                                                )
                                            )
                                    )
                                )
                            ),
                            Block
                            (
                                entryPoints.Select
                                (
                                    entryPoint => ExpressionStatement
                                    (
                                        AssignmentExpression
                                        (
                                            SyntaxKind.SimpleAssignmentExpression,
                                            MemberAccessExpression
                                            (
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName("ret"),
                                                IdentifierSilk($"_{entryPoint}")
                                            ),
                                            IdentifierSilk($"_{entryPoint}")
                                        )
                                    )
                                )
                            ),
                            ReturnStatement(IdentifierName("ret"))
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
    }
}
