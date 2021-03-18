// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public static partial class Middlewares
    {
        public static void SpanMarshaller(ref IMarshalContext ctx, Action next)
        {
            bool[] b = new bool[ctx.ParameterVariables.Length];
            
            for (var index = 0; index < ctx.ParameterVariables.Length; index++)
            {
                if (!(ctx.LoadTypes[index] is INamedTypeSymbol named))
                    continue;
                
                if (!named.IsGenericType) continue;

                if (!SymbolEqualityComparer.Default.Equals(named.OriginalDefinition, ctx.Compilation.GetTypeByMetadataName("System.Span`1"))) continue;

                b[index] = true;
            }

            var oldParameterIds = ctx.ParameterVariables.ToArray();

            for (var index = 0; index < ctx.ParameterVariables.Length; index++)
            {
                // in this loop, update all types & expressions

                var shouldPin = b[index];
                if (!shouldPin) continue;
                
                var loadType = ctx.LoadTypes[index];
                loadType = ctx.Compilation.CreatePointerTypeSymbol((loadType as INamedTypeSymbol)!.TypeArguments[0]);
                ctx.LoadTypes[index] = loadType;

                var (id, name) = ctx.DeclareSpecialVariableNoInlining(loadType, false);
                ctx.SetParameterToVariable(index, id);
                var l = ctx.LoadTypes[index].ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
                var old = ctx.ResolveVariable(oldParameterIds[index]);
                ctx.BeginBlock((x, ctx) => FixedStatement
                (
                    VariableDeclaration
                    (
                        IdentifierName(l),
                        SingletonSeparatedList
                            (VariableDeclarator(Identifier(name), null, EqualsValueClause(old.Value)))
                    ), x
                ));
            }

            next();
            
        }
    }
}