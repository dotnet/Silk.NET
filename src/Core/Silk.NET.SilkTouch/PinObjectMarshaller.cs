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
        private static void PinObjectMarshaller(ref MarshalContext ctx, Action next)
        {
            for (var index = 0; index < ctx.ParameterExpressions.Length; index++)
            {
                if (!ctx.TryGetAttribute(index, "Silk.NET.Core.Native.PinObjectAttribute", out var data))
                    continue;

                PinMode pinMode;
                if (data.ConstructorArguments.Length < 1)
                    pinMode = PinMode.Persist;
                else
                    pinMode = (PinMode) (data.ConstructorArguments[0].Value ?? PinMode.Persist);

                var name = pinMode switch {
                    PinMode.Persist => "Pin",
                    PinMode.UntilNextCall => "PinUntilNextCall",
                    _ => throw new Exception()
                };

                ctx.CurrentStatements = ctx.CurrentStatements.Append
                (
                    ExpressionStatement
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
                                        Argument(ctx.ParameterExpressions[index]),
                                        Argument
                                            (LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(ctx.Slot)))
                                    }
                                )
                            )
                        )
                    )
                );
            }
            
            next();

            if (ctx.TryGetAttribute
                (ctx.LoadTypes.Length - 1, "Silk.NET.Core.Native.PinObjectAttribute", out var resultData))
            {

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

                ctx.CurrentStatements = ctx.CurrentStatements.Append
                (
                    ExpressionStatement
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
                                        Argument(ctx.ResultExpression),
                                        Argument
                                            (LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(ctx.Slot)))
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
