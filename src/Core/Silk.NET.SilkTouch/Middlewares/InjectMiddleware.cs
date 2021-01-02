// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Silk.NET.Core.Attributes;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public static partial class Middlewares
    {
        public static void InjectMiddleware(ref IMarshalContext ctx, Action next)
        {
            var context = ctx;
            var injectDatas = ctx.MethodSymbol.GetAttributes().Where
            (
                x => SymbolEqualityComparer.Default.Equals
                    (x.AttributeClass, context.Compilation.GetTypeByMetadataName(typeof(InjectAttribute).FullName))
            );

            foreach(var injectData in injectDatas)
            {
                var injectPoint = (SilkTouchStage) injectData.ConstructorArguments[0].Value!;
                var code = (string)injectData.ConstructorArguments[1].Value!;
                ctx.AddSideEffectToStage(injectPoint, ctx =>
                {
                    if (injectPoint == SilkTouchStage.End)
                    {
                        if (ctx.ResultVariable.HasValue)
                        {
                            code = code.Replace
                            (
                                "%$RESULT$%",
                                ParenthesizedExpression(ctx.ResolveVariable(ctx.ResultVariable.Value).Value)
                                    .NormalizeWhitespace()
                                    .ToFullString()
                            );
                        }

                        for (var i = 0; i < ctx.ParameterVariables.Length; i++)
                        {
                            code = code.Replace
                            (
                                $"%$PARAM({ctx.MethodSymbol.Parameters[i].Name})$%",
                                ParenthesizedExpression(ctx.ResolveVariable(ctx.ParameterVariables[i]).Value)
                                    .NormalizeWhitespace()
                                    .ToFullString()
                            );
                        }
                    }

                    return ParseStatement(code);
                });
            }

            ctx.TransitionTo(SilkTouchStage.Begin);
            next();
            ctx.TransitionTo(SilkTouchStage.End);
        }
    }
}
