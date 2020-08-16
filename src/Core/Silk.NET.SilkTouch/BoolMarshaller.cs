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
    public partial class NativeApiGenerator
    {
        private static void BoolMarshaller(ref MarshalContext ctx, Action next)
        {
            static ITypeSymbol Type(Compilation compilation, UnmanagedType? type)
            {
                switch (type)
                    {
                        case UnmanagedType.I1:
                            return compilation.GetSpecialType(SpecialType.System_SByte);
                            
                        case UnmanagedType.I2:
                            return compilation.GetSpecialType(SpecialType.System_Int16);;
                            
                        case UnmanagedType.I4:
                            return compilation.GetSpecialType(SpecialType.System_Int32);;
                            
                        case UnmanagedType.I8:
                            return compilation.GetSpecialType(SpecialType.System_Int64);;
                            
                        case UnmanagedType.SysInt:
                            return compilation.CreateNativeIntegerTypeSymbol(true);
                            
                        case UnmanagedType.SysUInt:
                            return compilation.CreateNativeIntegerTypeSymbol(false);
                            
                        case UnmanagedType.U2:
                            return compilation.GetSpecialType(SpecialType.System_UInt16);
                            
                        case UnmanagedType.U4:
                            return compilation.GetSpecialType(SpecialType.System_UInt32);
                            
                        case UnmanagedType.U8:
                            return compilation.GetSpecialType(SpecialType.System_UInt64);
                            
                        case UnmanagedType.VariantBool:
                            return compilation.GetSpecialType(SpecialType.System_Int16);
                            
                        case UnmanagedType.U1:
                        default:
                            return compilation.GetSpecialType(SpecialType.System_Byte);;
                            
                    }
            }
            
            for (var index = 0; index < ctx.ParameterExpressions.Length; index++)
            {
                if (SymbolEqualityComparer.Default.Equals(ctx.LoadTypes[index], ctx.Compilation.GetSpecialType(SpecialType.System_Boolean)))
                {
                    ctx.LoadTypes[index] = Type(ctx.Compilation, ctx.ParameterMarshalOptions[index]?.MarshalAs);
                    
                    ExpressionSyntax @true;
                    ExpressionSyntax @false;

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

                    @true = CastExpression(IdentifierName(ctx.LoadTypes[index].ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)), @true);
                    @false = CastExpression(IdentifierName(ctx.LoadTypes[index].ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)), @false);

                    var name = $"bmp{ctx.Slot}{index}";
                    ctx.DeclareVariable(ctx.LoadTypes[index], name);
                    ctx.SetParameterToVariableAndAssign(index, name, ConditionalExpression(ctx.ParameterExpressions[index], @true, @false));
                }
            }


            var resultLocalName = $"boolName{ctx.Slot}res";
            var processReturnType = !ctx.ReturnsVoid && SymbolEqualityComparer.Default.Equals(ctx.ReturnLoadType, ctx.Compilation.GetSpecialType(SpecialType.System_Boolean));
            if (processReturnType)
            {
                    ctx.ReturnLoadType = Type(ctx.Compilation, ctx.ReturnMarshalOptions?.MarshalAs);

                    ctx.DeclareVariable(ctx.Compilation.GetSpecialType(SpecialType.System_Boolean), resultLocalName);
            }

            next();

            if (processReturnType)
            {                    
                ExpressionSyntax @true;
                ExpressionSyntax @false;
                
                if (ctx.ReturnMarshalOptions?.MarshalAs == UnmanagedType.VariantBool)
                {
                    @true = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(-1)); 
                    @false = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(0));
                }
                else
                {
                    @true = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(1));
                    @false = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(0));
                }

                ctx.CurrentStatements = ctx.CurrentStatements.Append
                (
                    ExpressionStatement
                    (
                        AssignmentExpression
                        (
                            SyntaxKind.SimpleAssignmentExpression, IdentifierName(resultLocalName),
                            BinaryExpression(SyntaxKind.EqualsExpression, ctx.ResultExpression, @true)
                        )
                    )
                );

                ctx.ResultExpression = IdentifierName(resultLocalName);
            }
        }
    }
}
