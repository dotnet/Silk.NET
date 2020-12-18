// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Silk.NET.Core.Attributes;

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
                var syntax = SyntaxFactory.ParseStatement(code);
                ctx.AddSideEffectToStage(injectPoint, _ => syntax);
            }

            ctx.TransitionTo(SilkTouchStage.Begin);
            next();
            ctx.TransitionTo(SilkTouchStage.End);
        }
    }
}
