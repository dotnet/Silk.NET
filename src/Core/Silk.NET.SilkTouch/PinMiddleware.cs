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
        private static void PinMiddleware(ref IMarshalContext ctx, Action next)
        {
            var vars = new (int, string)[ctx.ParameterVariables.Length];
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
                ctx.BeginBlock();
                vars[index] = (id, name);
            }

            next();

            for (var index = 0; index < ctx.ParameterVariables.Length; index++)
            {
                // in this loop, actually emit the `fixed` statements, with the statements of `next()` as body

                var (id, name) = vars[index];
                var shouldPin = ctx.ShouldPinParameter[index];
                if (!shouldPin) continue;

                var loadType = ctx.LoadTypes[index].ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
                var symbolName = ctx.MethodSymbol.Parameters[index].Name;
                ctx.EndBlock((x, ctx) => FixedStatement
                (
                    VariableDeclaration
                    (
                        IdentifierName(loadType),
                        SingletonSeparatedList
                            (VariableDeclarator(Identifier(name), null, EqualsValueClause(PrefixUnaryExpression(SyntaxKind.AddressOfExpression, IdentifierName(FormatName(symbolName))))))
                    ), x
                ));
            }
        }
    }
}
