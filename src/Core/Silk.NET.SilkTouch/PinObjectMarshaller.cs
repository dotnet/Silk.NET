// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public partial class NativeApiGenerator
    {
        private static void PinObjectMarshaller(ref IMarshalContext ctx, Action next)
        {
            for (var index = 0; index < ctx.ParameterVariables.Length; index++)
            {
                if (!ctx.TryGetAttribute(index, "Silk.NET.Core.Native.PinObjectAttribute", out var data))
                    continue;

                var gcSlot = ctx.AllocateGcSlot();
                PinMode pinMode;
                if (data.ConstructorArguments.Length < 1)
                    pinMode = PinMode.Persist;
                else
                    pinMode = (PinMode) (data.ConstructorArguments[0].Value ?? PinMode.Persist);

                var name = pinMode switch
                {
                    PinMode.Persist => "Pin",
                    PinMode.UntilNextCall => "PinUntilNextCall",
                    _ => throw new Exception()
                };

                var parameterVariable = ctx.ResolveVariable(ctx.ParameterVariables[index]);
                ctx.AddSideEffect
                (
                    ctx => ExpressionStatement
                    (
                        InvocationExpression
                        (
                            MemberAccessExpression
                                (SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(name)),
                            ArgumentList
                            (
                                SeparatedList
                                (
                                    new[]
                                    {
                                        Argument(parameterVariable.Value),
                                        Argument
                                            (LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(gcSlot)))
                                    }
                                )
                            )
                        )
                    )
                );
            }

            next();

            if (!ctx.ReturnsVoid && ctx.TryGetAttribute
                (ctx.LoadTypes.Length - 1, "Silk.NET.Core.Native.PinObjectAttribute", out var resultData))
            {
                var gcSlot = ctx.AllocateGcSlot();

                PinMode pinMode;
                if (resultData.ConstructorArguments.Length < 1)
                    pinMode = PinMode.Persist;
                else
                    pinMode = (PinMode) (resultData.ConstructorArguments[0].Value ?? PinMode.Persist);

                var name = pinMode switch
                {
                    PinMode.Persist => "Pin",
                    PinMode.UntilNextCall => "PinUntilNextCall",
                    _ => throw new Exception()
                };

                var resultVariable = ctx.ResolveVariable(ctx.ResultVariable.Value);
                ctx.AddSideEffect
                (
                    ctx => ExpressionStatement
                    (
                        InvocationExpression
                        (
                            MemberAccessExpression
                                (SyntaxKind.SimpleMemberAccessExpression, ThisExpression(), IdentifierName(name)),
                            ArgumentList
                            (
                                SeparatedList
                                (
                                    new[]
                                    {
                                        Argument(resultVariable.Value),
                                        Argument
                                            (LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(gcSlot)))
                                    }
                                )
                            )
                        )
                    )
                );
            }
        }
    }

    public enum PinMode
    {
        Persist,
        UntilNextCall
    }
}
