// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public partial class NativeAPIGenerator
    {
        private static void BoolMarshaller(ref MarshalContext ctx, Action next)
        {
            for (var index = 0; index < ctx.ParameterExpressions.Length; index++)
            {
                if (ctx.LoadTypes[index] == "bool")
                {
                    switch (ctx.ParameterMarshalOptions[index]?.MarshalAs)
                    {
                        case UnmanagedType.I1:
                            ctx.LoadTypes[index] = "sbyte";
                            break;
                        case UnmanagedType.I2:
                            ctx.LoadTypes[index] = "short";
                            break;
                        case UnmanagedType.I4:
                            ctx.LoadTypes[index] = "int";
                            break;
                        case UnmanagedType.I8:
                            ctx.LoadTypes[index] = "long";
                            break;
                        case UnmanagedType.SysInt:
                            ctx.LoadTypes[index] = "nint";
                            break;
                        case UnmanagedType.SysUInt:
                            ctx.LoadTypes[index] = "nuint";
                            break;
                        case UnmanagedType.U2:
                            ctx.LoadTypes[index] = "short";
                            break;
                        case UnmanagedType.U4:
                            ctx.LoadTypes[index] = "uint";
                            break;
                        case UnmanagedType.U8:
                            ctx.LoadTypes[index] = "ulong";
                            break;
                        case UnmanagedType.VariantBool:
                            ctx.LoadTypes[index] = "short";
                            break;
                        case UnmanagedType.U1:
                        default:
                            ctx.LoadTypes[index] = "byte";
                            break;
                    }

                    LiteralExpressionSyntax @true;
                    LiteralExpressionSyntax @false;

                    if (ctx.ParameterMarshalOptions[index]?.MarshalAs == UnmanagedType.VariantBool)
                    {
                        @true = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(-1)); 
                        @false = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(0));
                    }
                    else
                    {
                        @true = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(1));
                        @false = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(0));
                    }

                    ctx.ParameterExpressions[index] = ConditionalExpression(ctx.ParameterExpressions[index], @true, @false);
                }
            }


            var resultLocalName = $"boolName{ctx.Slot}res";
            var processReturnType = !ctx.ReturnsVoid && ctx.ReturnLoadType == "bool";
            if (processReturnType)
            {
                    ctx.ReturnLoadType = "byte";

                    ctx.CurrentStatements = ctx.CurrentStatements.Prepend
                (
                    LocalDeclarationStatement
                    (
                        VariableDeclaration
                        (
                            IdentifierName(ctx.ReturnLoadType),
                            SingletonSeparatedList(VariableDeclarator(Identifier(resultLocalName)))
                        )
                    )
                );
            }

            next();

            if (processReturnType)
            {
                ctx.CurrentStatements = ctx.CurrentStatements.Append
                (
                    ExpressionStatement
                    (
                        AssignmentExpression
                        (
                            SyntaxKind.SimpleAssignmentExpression, IdentifierName(resultLocalName),
                            BinaryExpression
                            (
                                SyntaxKind.EqualsExpression, ctx.ResultExpression,
                                LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(1))
                            )
                        )
                    )
                );

                ctx.ResultExpression = IdentifierName(resultLocalName);
            }
        }
    }
}
