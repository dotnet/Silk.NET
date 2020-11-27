// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.Core.Native;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public static partial class Middlewares
    {
        public static void BoolMarshaller(ref IMarshalContext ctx, Action next)
        {
            static ITypeSymbol Type(Compilation compilation, UnmanagedType? type)
            {
                switch (type)
                {
                    case UnmanagedType.I1:
                        return compilation.GetSpecialType(SpecialType.System_SByte);

                    case UnmanagedType.I2:
                        return compilation.GetSpecialType(SpecialType.System_Int16);

                    case UnmanagedType.I4:
                        return compilation.GetSpecialType(SpecialType.System_Int32);

                    case UnmanagedType.I8:
                        return compilation.GetSpecialType(SpecialType.System_Int64);

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
                        return compilation.GetSpecialType(SpecialType.System_Byte);
                }
            }

            for (var index = 0; index < ctx.ParameterVariables.Length; index++)
            {
                if (SymbolEqualityComparer.Default.Equals
                    (ctx.LoadTypes[index], ctx.Compilation.GetSpecialType(SpecialType.System_Boolean)))
                {
                    ctx.LoadTypes[index] = Type(ctx.Compilation, ctx.ParameterMarshalOptions[index]?.UnmanagedType);

                    ExpressionSyntax @true;
                    ExpressionSyntax @false;

                    if (ctx.ParameterMarshalOptions[index]?.UnmanagedType == UnmanagedType.VariantBool)
                    {
                        @true = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(-1));
                        @false = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(0));
                    }
                    else
                    {
                        @true = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(1));
                        @false = LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(0));
                    }

                    @true = CastExpression
                    (
                        IdentifierName(ctx.LoadTypes[index].ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)),
                        @true
                    );
                    @false = CastExpression
                    (
                        IdentifierName(ctx.LoadTypes[index].ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)),
                        @false
                    );

                    var id = ctx.DeclareVariable(ctx.LoadTypes[index]);
                    var parameter = ctx.ResolveVariable(ctx.ParameterVariables[index]);
                    ctx.SetVariable
                    (
                        id,
                        ctx => ConditionalExpression
                            (parameter.Value, @true, @false)
                    );
                    ctx.SetParameterToVariable(index, id);
                }
            }


            int resultLocalId = default;
            var processReturnType = !ctx.ReturnsVoid && SymbolEqualityComparer.Default.Equals
                (ctx.ReturnLoadType, ctx.Compilation.GetSpecialType(SpecialType.System_Boolean));
            if (processReturnType)
            {
                ctx.ReturnLoadType = Type(ctx.Compilation, ctx.ReturnMarshalOptions?.UnmanagedType);

                resultLocalId = ctx.DeclareVariable(ctx.Compilation.GetSpecialType(SpecialType.System_Boolean));
            }

            next();

            if (processReturnType)
            {
                var resultVariable = ctx.ResolveVariable(ctx.ResultVariable.Value);
                if (ctx.ReturnMarshalOptions?.UnmanagedType == UnmanagedType.VariantBool)
                {
                    ctx.SetVariable
                    (
                        resultLocalId,
                        ctx => BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, resultVariable.Value,
                            LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(-1))
                        )
                    );
                }
                else
                {
                    ctx.SetVariable
                    (
                        resultLocalId,
                        ctx => BinaryExpression
                        (
                            SyntaxKind.GreaterThanOrEqualExpression, resultVariable.Value,
                            LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(1))
                        )
                    );
                }

                ctx.ResultVariable = resultLocalId;
            }
        }
    }
}