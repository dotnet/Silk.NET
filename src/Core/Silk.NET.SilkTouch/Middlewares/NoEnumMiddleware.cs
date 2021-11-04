// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Microsoft.CodeAnalysis;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch;

public static partial class Middlewares
{
    public static void NoEnumMiddleware(ref IMarshalContext ctx, Action next)
    {
        for (int i = 0; i < ctx.LoadTypes.Length - 1; i++)
        {
            var lt = ctx.LoadTypes[i];
            if (lt is INamedTypeSymbol { TypeKind: TypeKind.Enum } nts)
            {
                if (ctx.MethodSymbol.Parameters[i].RefKind != 0)
                    throw new NotImplementedException("Ref enums not yet supported");
                var target = nts.EnumUnderlyingType ?? ctx.Compilation.GetSpecialType(SpecialType.System_Int32);
                var id = ctx.DeclareVariable(target);
                var baseId = ctx.ParameterVariables[i];
                ctx.SetVariable(id, ctx => CastExpression(IdentifierName(target.ToDisplayString()), ctx.ResolveVariable(baseId).Value));
                ctx.SetParameterToVariable(i, id);
            }
        }

        int? returnLocal = null;
        INamedTypeSymbol? returnType = null;
        if (ctx.ReturnLoadType is INamedTypeSymbol { TypeKind: TypeKind.Enum } ntsr)
        {
            var target = ntsr.EnumUnderlyingType ?? ctx.Compilation.GetSpecialType(SpecialType.System_Int32);
            returnLocal = ctx.DeclareVariable(ntsr);
            ctx.ReturnLoadType = target;
            returnType = ntsr;
        }
        
        next();

        if (returnLocal.HasValue)
        {
            var result = ctx.ResultVariable!.Value;
            ctx.SetVariable(returnLocal.Value, ctx => CastExpression(IdentifierName(returnType.ToDisplayString()), ctx.ResolveVariable(result).Value));
            ctx.ResultVariable = returnLocal.Value;
        }
    }
}
