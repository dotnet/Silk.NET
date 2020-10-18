// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch
{
    public partial class NativeApiGenerator
    {
        private TypeDeclarationSyntax GenerateVTable
            (bool preloadVTable, Dictionary<int, string> entryPoints, bool emitAssert)
        {
            var vTableMembers = new List<MemberDeclarationSyntax>();

            var initializeStatements = new List<StatementSyntax>();

            if (!preloadVTable)
            {
                vTableMembers.Add
                (
                    SyntaxFactory.FieldDeclaration
                    (
                        SyntaxFactory.List<AttributeListSyntax>(),
                        SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PrivateKeyword)),
                        SyntaxFactory.VariableDeclaration
                        (
                            SyntaxFactory.IdentifierName("Silk.NET.Core.Contexts.INativeContext"),
                            SyntaxFactory.SingletonSeparatedList(SyntaxFactory.VariableDeclarator("_ctx"))
                        )
                    )
                );

                initializeStatements.Add
                (
                    SyntaxFactory.ExpressionStatement
                    (
                        SyntaxFactory.AssignmentExpression
                        (
                            SyntaxKind.SimpleAssignmentExpression, SyntaxFactory.IdentifierName("_ctx"),
                            SyntaxFactory.IdentifierName("ctx")
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
                            entryPoint => SyntaxFactory.ExpressionStatement
                            (
                                SyntaxFactory.AssignmentExpression
                                (
                                    SyntaxKind.SimpleAssignmentExpression,
                                    SyntaxFactory.IdentifierName($"_{entryPoint}"),
                                    SyntaxFactory.InvocationExpression
                                    (
                                        SyntaxFactory.MemberAccessExpression
                                        (
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            SyntaxFactory.IdentifierName("ctx"),
                                            SyntaxFactory.IdentifierName("GetProcAddress")
                                        ),
                                        SyntaxFactory.ArgumentList
                                        (
                                            SyntaxFactory.SingletonSeparatedList
                                            (
                                                SyntaxFactory.Argument
                                                (
                                                    SyntaxFactory.LiteralExpression
                                                    (
                                                        SyntaxKind.StringLiteralExpression,
                                                        SyntaxFactory.Literal(entryPoint)
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
                SyntaxFactory.MethodDeclaration
                        (SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)), "Initialize")
                    .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                    .WithParameterList
                    (
                        SyntaxFactory.ParameterList
                        (
                            SyntaxFactory.SeparatedList
                            (
                                new[]
                                {
                                    SyntaxFactory.Parameter
                                            (SyntaxFactory.Identifier("ctx"))
                                        .WithType
                                            (SyntaxFactory.IdentifierName("Silk.NET.Core.Contexts.INativeContext")),
                                    SyntaxFactory.Parameter
                                            (SyntaxFactory.Identifier("maxSlots"))
                                        .WithType
                                            (SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.IntKeyword)))
                                }
                            )
                        )
                    )
                    .WithBody(SyntaxFactory.Block(initializeStatements))
            );

            List<VariableDeclaratorSyntax> slotVars = new List<VariableDeclaratorSyntax>();
            foreach (var entrypoint in entryPoints.Values.Distinct())
            {
                var name = $"_{entrypoint}";
                slotVars.Add(SyntaxFactory.VariableDeclarator(name));
            }

            vTableMembers.Add
            (
                SyntaxFactory.MethodDeclaration
                    (
                        SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)),
                        "GeneratedThrowHelperInvalidSlot"
                    )
                    .WithParameterList(SyntaxFactory.ParameterList())
                    .WithModifiers
                    (
                        SyntaxFactory.TokenList
                        (
                            SyntaxFactory.Token(SyntaxKind.PrivateKeyword),
                            SyntaxFactory.Token(SyntaxKind.StaticKeyword)
                        )
                    )
                    .WithBody
                    (
                        SyntaxFactory.Block
                        (
                            SyntaxFactory.ThrowStatement
                            (
                                SyntaxFactory.ObjectCreationExpression
                                    (
                                        SyntaxFactory.QualifiedName
                                        (
                                            SyntaxFactory.IdentifierName("System"),
                                            SyntaxFactory.IdentifierName("InvalidOperationException")
                                        )
                                    )
                                    .WithArgumentList
                                    (
                                        SyntaxFactory.ArgumentList
                                        (
                                            SyntaxFactory.SingletonSeparatedList
                                            (
                                                SyntaxFactory.Argument
                                                (
                                                    SyntaxFactory.LiteralExpression
                                                    (
                                                        SyntaxKind.StringLiteralExpression,
                                                        SyntaxFactory.Literal("Invalid Slot")
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
                        SyntaxFactory.SingletonList<AttributeListSyntax>
                        (
                            SyntaxFactory.AttributeList
                            (
                                SyntaxFactory.SingletonSeparatedList<AttributeSyntax>
                                (
                                    SyntaxFactory.Attribute
                                    (
                                        SyntaxFactory.QualifiedName
                                        (
                                            SyntaxFactory.QualifiedName
                                            (
                                                SyntaxFactory.IdentifierName("System"),
                                                SyntaxFactory.IdentifierName("Diagnostics")
                                            ), SyntaxFactory.IdentifierName("DebuggerHidden")
                                        )
                                    )
                                )
                            )
                        )
                    )
            );

            vTableMembers.Add
            (
                SyntaxFactory.FieldDeclaration
                (
                    SyntaxFactory.List<AttributeListSyntax>(),
                    SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PrivateKeyword)),
                    SyntaxFactory.VariableDeclaration
                        (SyntaxFactory.IdentifierName("System.IntPtr"), SyntaxFactory.SeparatedList(slotVars))
                )
            );

            vTableMembers.Add
            (
                SyntaxFactory.MethodDeclaration(SyntaxFactory.IdentifierName("System.IntPtr"), "Load")
                    .WithParameterList
                    (
                        SyntaxFactory.ParameterList
                        (
                            SyntaxFactory.SeparatedList
                            (
                                new[]
                                {
                                    SyntaxFactory.Parameter
                                            (SyntaxFactory.Identifier("slot"))
                                        .WithType
                                            (SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.IntKeyword))),
                                    SyntaxFactory.Parameter
                                            (SyntaxFactory.Identifier("entryPoint"))
                                        .WithType
                                        (
                                            SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.StringKeyword))
                                        )
                                }
                            )
                        )
                    )
                    .WithBody(SyntaxFactory.Block(BuildLoad(ref vTableMembers, entryPoints, emitAssert, preloadVTable)))
                    .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
            );

            vTableMembers.Add
            (
                SyntaxFactory.MethodDeclaration
                        (SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)), "Purge")
                    .WithParameterList(SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList<ParameterSyntax>()))
                    .WithBody
                    (
                        SyntaxFactory.Block
                        (
                            entryPoints.Values.Distinct()
                                .Select
                                (
                                    x => SyntaxFactory.ExpressionStatement
                                    (
                                        SyntaxFactory.AssignmentExpression
                                        (
                                            SyntaxKind.SimpleAssignmentExpression,
                                            SyntaxFactory.IdentifierName($"_{x}"),
                                            SyntaxFactory.DefaultExpression
                                                (SyntaxFactory.IdentifierName("System.IntPtr"))
                                        )
                                    )
                                )
                        )
                    )
                    .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
            );

            vTableMembers.Add
            (
                SyntaxFactory.MethodDeclaration
                        (SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)), "Dispose")
                    .WithParameterList(SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList<ParameterSyntax>()))
                    .WithBody(SyntaxFactory.Block())
                    .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
            );

            return SyntaxFactory.ClassDeclaration
            (
                SyntaxFactory.List<AttributeListSyntax>(),
                SyntaxFactory.TokenList
                    (SyntaxFactory.Token(SyntaxKind.PrivateKeyword), SyntaxFactory.Token(SyntaxKind.SealedKeyword)),
                SyntaxFactory.Identifier("GeneratedVTable"), null,
                SyntaxFactory.BaseList
                (
                    SyntaxFactory.SingletonSeparatedList
                    (
                        (BaseTypeSyntax) SyntaxFactory.SimpleBaseType
                            (SyntaxFactory.IdentifierName("Silk.NET.Core.Native.IVTable"))
                    )
                ), SyntaxFactory.List<TypeParameterConstraintClauseSyntax>(), SyntaxFactory.List(vTableMembers)
            );
        }
    }
}
