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

namespace Silk.NET.SilkTouch
{
    public partial class NativeApiGenerator
    {
        private static void DelegateMarshaller(ref MarshalContext ctx, Action next)
        {
            for (var index = 0; index < ctx.ParameterExpressions.Length; index++)
            {
                var options = ctx.ParameterMarshalOptions[index];

                if (ctx.LoadTypes[index].TypeKind != TypeKind.Delegate)
                    continue;
                
                ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_IntPtr);
                var name = $"dmp{ctx.Slot}{index}";
                ctx.DeclareVariable(ctx.LoadTypes[index], name);
                ctx.SetParameterToVariableAndAssign
                (
                    index, name, ConditionalExpression
                    (
                        BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, ctx.ParameterExpressions[index],
                            LiteralExpression(SyntaxKind.NullLiteralExpression)
                        ),
                        MemberAccessExpression
                        (
                            SyntaxKind.SimpleMemberAccessExpression, IdentifierName(nameof(IntPtr)),
                            IdentifierName(nameof(IntPtr.Zero))
                        ), InvocationExpression
                        ( // System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer<T>(ResultName)
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
                                            SyntaxKind.SimpleMemberAccessExpression, IdentifierName("System"),
                                            IdentifierName("Runtime")
                                        ), IdentifierName("InteropServices")
                                    ), IdentifierName("Marshal")
                                ), IdentifierName("GetFunctionPointerForDelegate")
                            ), ArgumentList(SingletonSeparatedList(Argument(ctx.ParameterExpressions[index])))
                        )
                    )
                );
            }

            var resultLocalName = $"dptr{ctx.Slot}res";
            var processReturn = ctx.ReturnLoadType.TypeKind == TypeKind.Delegate;
            var oldReturnLoadType = ctx.ReturnLoadType;
            if (processReturn)
            {
                ctx.DeclareVariable(ctx.ReturnLoadType, resultLocalName);
                
                ctx.ReturnLoadType = ctx.Compilation.GetSpecialType(SpecialType.System_IntPtr);
            }

            next();

            if (processReturn)
            {
                ctx.CurrentStatements = ctx.CurrentStatements.Append
                (
                    ExpressionStatement
                    (
                        AssignmentExpression
                        (
                            SyntaxKind.SimpleAssignmentExpression, IdentifierName(resultLocalName),
                            ConditionalExpression
                            (
                                BinaryExpression
                                (
                                    SyntaxKind.EqualsExpression, ctx.ResultExpression,
                                    MemberAccessExpression
                                    (
                                        SyntaxKind.SimpleMemberAccessExpression, IdentifierName("IntPtr"),
                                        IdentifierName("Zero")
                                    )
                                ), LiteralExpression(SyntaxKind.NullLiteralExpression), InvocationExpression
                                ( // System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer<T>(ResultName)
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
                                                    SyntaxKind.SimpleMemberAccessExpression, IdentifierName("System"),
                                                    IdentifierName("Runtime")
                                                ), IdentifierName("InteropServices")
                                            ), IdentifierName("Marshal")
                                        ),
                                        GenericName
                                        (
                                            Identifier("GetDelegateForFunctionPointer"),
                                            TypeArgumentList
                                            (
                                                SingletonSeparatedList
                                                    ((TypeSyntax) IdentifierName(oldReturnLoadType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)))
                                            )
                                        )
                                    ), ArgumentList(SingletonSeparatedList(Argument(ctx.ResultExpression)))
                                )
                            )
                        )
                    )
                );

                ctx.ResultExpression = IdentifierName(resultLocalName);
            }
        }
    }
}