// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
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
                if (SymbolEqualityComparer.Default.Equals(ctx.LoadTypes[index], ctx.Compilation.GetSpecialType(SpecialType.System_Boolean)))
                {
                    switch (ctx.ParameterMarshalOptions[index]?.MarshalAs)
                    {
                        case UnmanagedType.I1:
                            ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_SByte);
                            break;
                        case UnmanagedType.I2:
                            ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_Int16);;
                            break;
                        case UnmanagedType.I4:
                            ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_Int32);;
                            break;
                        case UnmanagedType.I8:
                            ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_Int64);;
                            break;
                        case UnmanagedType.SysInt:
                            ctx.LoadTypes[index] = ctx.Compilation.CreateNativeIntegerTypeSymbol(true);
                            break;
                        case UnmanagedType.SysUInt:
                            ctx.LoadTypes[index] = ctx.Compilation.CreateNativeIntegerTypeSymbol(false);
                            break;
                        case UnmanagedType.U2:
                            ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_UInt16);
                            break;
                        case UnmanagedType.U4:
                            ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_UInt32);
                            break;
                        case UnmanagedType.U8:
                            ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_UInt64);
                            break;
                        case UnmanagedType.VariantBool:
                            ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_Int16);
                            break;
                        case UnmanagedType.U1:
                        default:
                            ctx.LoadTypes[index] = ctx.Compilation.GetSpecialType(SpecialType.System_Byte);;
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

                    var name = $"bmp{ctx.Slot}{index}";
                    ctx.DeclareVariable(ctx.LoadTypes[index], name);
                    ctx.SetParameterToVariableAndAssign(index, name, ConditionalExpression(ctx.ParameterExpressions[index], @true, @false));
                }
            }


            var resultLocalName = $"boolName{ctx.Slot}res";
            var processReturnType = !ctx.ReturnsVoid && SymbolEqualityComparer.Default.Equals(ctx.ReturnLoadType, ctx.Compilation.GetSpecialType(SpecialType.System_Boolean));
            if (processReturnType)
            {
                    ctx.ReturnLoadType = ctx.Compilation.GetSpecialType(SpecialType.System_Byte);

                    ctx.DeclareVariable(ctx.ReturnLoadType, resultLocalName);
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
