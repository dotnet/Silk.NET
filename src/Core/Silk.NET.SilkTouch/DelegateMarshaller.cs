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
        private static void DelegateMarshaller(ref IMarshalContext ctx, Action next)
        {
            for (var index = 0; index < ctx.ParameterVariables.Length; index++)
            {
                var options = ctx.ParameterMarshalOptions[index];

                if (ctx.LoadTypes[index].TypeKind != TypeKind.Delegate)
                    continue;
                
                ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_IntPtr);
                var id = ctx.DeclareVariable(ctx.LoadTypes[index]);
                var parameterVariable = ctx.ResolveVariable(ctx.ParameterVariables[index]);
                ctx.SetVariable
                (
                    id, ctx => ConditionalExpression
                    (
                        BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, parameterVariable.Value,
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
                            ), ArgumentList(SingletonSeparatedList(Argument(parameterVariable.Value)))
                        )
                    )
                );
                ctx.SetParameterToVariable(index, id);
            }

            int resultLocalId = default;
            var processReturn = ctx.ReturnLoadType.TypeKind == TypeKind.Delegate;
            var oldReturnLoadType = ctx.ReturnLoadType;
            if (processReturn)
            {
                resultLocalId = ctx.DeclareVariable(ctx.ReturnLoadType);
                ctx.ReturnLoadType = ctx.Compilation.GetSpecialType(SpecialType.System_IntPtr);
            }

            next();

            if (processReturn)
            {
                var resultVariable = ctx.ResolveVariable(ctx.ResultVariable.Value);
                ctx.SetVariable
                (
                    resultLocalId, ctx => ConditionalExpression
                    (
                        BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, resultVariable.Value,
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
                                        (
                                            (TypeSyntax) IdentifierName
                                            (
                                                oldReturnLoadType.ToDisplayString
                                                    (SymbolDisplayFormat.FullyQualifiedFormat)
                                            )
                                        )
                                    )
                                )
                            ),
                            ArgumentList
                                (SingletonSeparatedList(Argument(resultVariable.Value)))
                        )
                    )
                );
                ctx.ResultVariable = resultLocalId;
            }
        }
    }
}