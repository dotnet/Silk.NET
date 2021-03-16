// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.Core.Native;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public static partial class Middlewares
    {
        public static void GenericPointerMarshaller(ref IMarshalContext ctx, Action next)
        {
            for (int i = 0; i < ctx.LoadTypes.Length - 1; i++)
            {
                var lt = ctx.LoadTypes[i];
                if (lt is IPointerTypeSymbol pts)
                {
                    if (pts.PointedAtType is ITypeParameterSymbol tps)
                    {
                        var id = ctx.DeclareVariable
                        (
                            ctx.Compilation.CreatePointerTypeSymbol
                                (ctx.Compilation.GetSpecialType(SpecialType.System_Void))
                        );
                        var baseId = ctx.ParameterVariables[i];
                        ctx.SetVariable(id, ctx => CastExpression(IdentifierName("void*"), ctx.ResolveVariable(baseId).Value));
                        ctx.SetParameterToVariable(i, id);
                    }
                }
            }

            next();
        }
    }
}
