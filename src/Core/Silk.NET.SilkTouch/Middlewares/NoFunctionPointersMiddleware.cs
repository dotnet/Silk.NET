// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Microsoft.CodeAnalysis;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch;

public static partial class Middlewares
{
    public static void NoFunctionPointersMiddleware(ref IMarshalContext ctx, Action next)
    {
        var voidPtr = ctx.Compilation.CreatePointerTypeSymbol(ctx.Compilation.GetSpecialType(SpecialType.System_Void));
        for (int i = 0; i < ctx.LoadTypes.Length - 1; i++)
        {
            var lt = ctx.LoadTypes[i];
            if (lt is IFunctionPointerTypeSymbol)
            {
                var id = ctx.DeclareVariable(voidPtr);
                var baseId = ctx.ParameterVariables[i];
                ctx.SetVariable(id, ctx => CastExpression(IdentifierName("void*"), ctx.ResolveVariable(baseId).Value));
                ctx.SetParameterToVariable(i, id);
            }
        }

        int? returnLocal = null;
        IFunctionPointerTypeSymbol? returnType = null;
        if (ctx.ReturnLoadType is IFunctionPointerTypeSymbol p)
        {
            returnLocal = ctx.DeclareVariable(p);
            ctx.ReturnLoadType = voidPtr;
            returnType = p;
        }
        
        next();

        if (returnLocal.HasValue)
        {
            var result = ctx.ResultVariable!.Value;
            ctx.SetVariable(returnLocal.Value, ctx => CastExpression(IdentifierName(returnType!.ToDisplayString()), ctx.ResolveVariable(result).Value));
            ctx.ResultVariable = returnLocal.Value;
        }
    }
}
