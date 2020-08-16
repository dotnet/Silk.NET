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
        private static void PinMiddleware(ref MarshalContext ctx, Action next)
        {
            var statementsToHere = ctx.CurrentStatements.ToList();
            ctx.CurrentStatements = Enumerable.Empty<StatementSyntax>();
            var oldParameterExpressions = (ExpressionSyntax[])ctx.ParameterExpressions.Clone();

            for (var index = 0; index < ctx.ParameterExpressions.Length; index++)
            {
                // in this loop, update all types & expressions
                
                var shouldPin = ctx.ShouldPinParameter[index];
                if (!shouldPin) continue;
                
                var loadType = ctx.LoadTypes[index];
                loadType = ctx.Compilation.CreatePointerTypeSymbol(loadType);
                ctx.LoadTypes[index] = loadType;
                
                var name = $"pp{ctx.Slot}{index}";
                ctx.ParameterExpressions[index] = IdentifierName(name);
            }

            next();

            for (var index = 0; index < ctx.ParameterExpressions.Length; index++)
            {
                // in this loop, actually emit the `fixed` statements, with the statements of `next()` as body
                
                var shouldPin = ctx.ShouldPinParameter[index];
                if (!shouldPin) continue;

                var name = $"pp{ctx.Slot}{index}";
                var block = Block(ctx.CurrentStatements.ToArray());
                ctx.CurrentStatements = Enumerable.Empty<StatementSyntax>();
                ctx.CurrentStatements = ctx.CurrentStatements.Append(FixedStatement
                (
                    VariableDeclaration
                    (
                        IdentifierName(ctx.LoadTypes[index].ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)),
                        SingletonSeparatedList
                            (VariableDeclarator(Identifier(name), null, EqualsValueClause(PrefixUnaryExpression(SyntaxKind.AddressOfExpression, oldParameterExpressions[index]))))
                    ), block
                ));
            }

            statementsToHere.AddRange(ctx.CurrentStatements);
            ctx.CurrentStatements = statementsToHere;
        }
    }
}
