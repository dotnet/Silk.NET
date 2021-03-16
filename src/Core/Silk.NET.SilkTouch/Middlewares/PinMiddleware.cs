// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public static partial class Middlewares
    {
        public static void PinMiddleware(ref IMarshalContext ctx, Action next)
        {
            for (var index = 0; index < ctx.ParameterVariables.Length; index++)
            {
                // in this loop, update all types & expressions

                var shouldPin = ctx.ShouldPinParameter[index];
                if (!shouldPin) continue;
                
                var loadType = ctx.LoadTypes[index];
                loadType = ctx.Compilation.CreatePointerTypeSymbol(loadType);
                ctx.LoadTypes[index] = loadType;

                var (id, name) = ctx.DeclareSpecialVariableNoInlining(loadType, false);
                ctx.SetParameterToVariable(index, id);
                var symbolName = ctx.MethodSymbol.Parameters[index].Name;
                var l =ctx.LoadTypes[index].ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
                ctx.BeginBlock((x, ctx) => FixedStatement
                (
                    VariableDeclaration
                    (
                        IdentifierName(l),
                        SingletonSeparatedList
                            (VariableDeclarator(Identifier(name), null, EqualsValueClause(PrefixUnaryExpression(SyntaxKind.AddressOfExpression, IdentifierName(FormatName(symbolName))))))
                    ), x
                ));
            }

            next();
        }
    }
}
