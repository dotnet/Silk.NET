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
            (bool preloadVTable, List<string> entryPoints, bool emitAssert, bool vNext, string generatedVTableName)
        {
            var vTableMembers = new List<MemberDeclarationSyntax>();

            var constructorStatements = new List<StatementSyntax>();

            if (!preloadVTable)
            {
                vTableMembers.Add
                (
                    FieldDeclaration
                    (
                        List<AttributeListSyntax>(),
                        TokenList(Token(SyntaxKind.PrivateKeyword).AddTrailingSpace()),
                        VariableDeclaration
                        (
                            IdentifierName("Silk.NET.Core.Contexts.INativeContext").AddTrailingSpace(),
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
            }
            else
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
                ConstructorDeclaration("GeneratedVTable")
                    .WithModifiers(TokenList(Token(SyntaxKind.InternalKeyword).AddTrailingSpace()))
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
                                            (IdentifierName("Silk.NET.Core.Contexts.INativeContext").AddTrailingSpace())
                                }
                            )
                        )
                    )
                    .WithBody(Block(constructorStatements))
            );

            List<VariableDeclaratorSyntax> slotVars = new List<VariableDeclaratorSyntax>();
            foreach (var entrypoint in entryPoints.Distinct())
            {
                var name = $"_{entrypoint}";
                slotVars.Add(VariableDeclarator(name));
            }

            vTableMembers.Add
            (
                FieldDeclaration
                (
                    List<AttributeListSyntax>(),
                    TokenList(Token(SyntaxKind.PrivateKeyword).AddTrailingSpace()),
                    VariableDeclaration
                        (IdentifierName("System.IntPtr").AddTrailingSpace(), SeparatedList(slotVars))
                )
            );

            /*
             * create the obsolete legacy "Load" forward
             * looks something like:
             * Load(int slot, string entryPoint) => Load(entryPoint);
             */
            vTableMembers.Add
            (
                MethodDeclaration(IdentifierName("nint").AddTrailingSpace(), "Load")
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
                                            (PredefinedType(Token(SyntaxKind.IntKeyword)).AddTrailingSpace()),
                                    Parameter
                                            (Identifier("entryPoint"))
                                        .WithType
                                        (
                                            PredefinedType(Token(SyntaxKind.StringKeyword).AddTrailingSpace())
                                        )
                                }
                            )
                        )
                    )
                    .WithExpressionBody(ArrowExpressionClause(InvocationExpression(IdentifierName("Load"), ArgumentList(SingletonSeparatedList(Argument(IdentifierName("entryPoint")))))))
                    .WithBody(null)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword).AddTrailingSpace()))
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
                MethodDeclaration(IdentifierName("nint").AddTrailingSpace(), "Load")
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
                                        .WithType(PredefinedType(Token(SyntaxKind.StringKeyword).AddTrailingSpace()))
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
                                IdentifierName("entryPoint").AddTrailingSpace(),
                                SeparatedList
                                (
                                    entryPoints.Distinct()
                                        .Select
                                        (
                                            s => SwitchExpressionArm
                                            (
                                                ConstantPattern
                                                    (LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(s))),
                                                IdentifierName(FirstLetterToUpper(s))
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
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword).AddTrailingSpace()))
            );
            
            /*
             * Create a property for every entryPoint like:
             * public nint MyEntryPoint => _myEntryPoint != 0 ? _myEntryPoint : (_myEntryPoint = _ctx.Load(myEntryPoint))
             */
            vTableMembers.AddRange
            (
                entryPoints.Distinct().Select
                (
                    s => PropertyDeclaration
                            (IdentifierName("nint").AddTrailingSpace(), FirstLetterToUpper(s))
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
                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword).AddTrailingSpace()))
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                )
            );

            vTableMembers.Add
            (
                MethodDeclaration
                        (PredefinedType(Token(SyntaxKind.VoidKeyword).AddTrailingSpace()), "Purge")
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
                                            IdentifierName($"_{x}"),
                                            DefaultExpression
                                                (IdentifierName("nint"))
                                        )
                                    )
                                )
                        )
                    )
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword).AddTrailingSpace()))
            );

            vTableMembers.Add
            (
                MethodDeclaration
                        (PredefinedType(Token(SyntaxKind.VoidKeyword).AddTrailingSpace()), "Dispose")
                    .WithParameterList(ParameterList(SeparatedList<ParameterSyntax>()))
                    .WithBody(Block())
                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword).AddTrailingSpace()))
            );

            return ClassDeclaration
            (
                List<AttributeListSyntax>(),
                TokenList
                (
                    Token(SyntaxKind.PrivateKeyword).AddTrailingSpace(),
                    Token(SyntaxKind.SealedKeyword).AddTrailingSpace()
                ),
                Identifier(generatedVTableName).AddLeadingSpace(), null,
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
