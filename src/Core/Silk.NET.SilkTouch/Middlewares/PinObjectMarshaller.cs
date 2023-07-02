// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public static partial class Middlewares
    {
        public static void PinObjectMarshaller(ref IMarshalContext ctx, Action next)
        {
            for (var index = 0; index < ctx.ParameterVariables.Length; index++)
            {
                if (!ctx.TryGetAttribute(index, "Silk.NET.Core.Native.PinObjectAttribute", out var data))
                    continue;

                var gcSlot = ctx.AllocateGcSlot();
                PinMode pinMode;
                string[] discriminantExprs;
                if (data is null || data.ConstructorArguments.Length < 1)
                {
                    pinMode = PinMode.Persist;
                }
                else
                {
                    pinMode = (PinMode) (data.ConstructorArguments[0].Value ?? PinMode.Persist);
                }

                if (data is null ||
                    data.ConstructorArguments.Length < 2 ||
                    data.ConstructorArguments[1].Values.Length == 0)
                {
                    discriminantExprs = Array.Empty<string>();
                }
                else
                {
                    discriminantExprs = data.ConstructorArguments[1]
                        .Values
                        .Select(x => x.Value as string)
                        .Where(x => x is not null)
                        .ToArray()!;
                }

                var slotSyntax = discriminantExprs.Length == 0
                    ? LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(gcSlot))
                    : MixDiscriminants(gcSlot, discriminantExprs);

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
                                        Argument(slotSyntax)
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
                string[] discriminantExprs;
                if (resultData.ConstructorArguments.Length < 1)
                {
                    pinMode = PinMode.Persist;
                }
                else
                {
                    pinMode = (PinMode) (resultData.ConstructorArguments[0].Value ?? PinMode.Persist);
                }
                
                if (resultData.ConstructorArguments.Length < 2 || resultData.ConstructorArguments[1].Values.Length == 0)
                {
                    discriminantExprs = Array.Empty<string>();
                }
                else
                {
                    discriminantExprs = resultData.ConstructorArguments[1]
                        .Values
                        .Select(x => x.Value as string)
                        .Where(x => x is not null)
                        .ToArray()!;
                }

                var slotSyntax = discriminantExprs.Length == 0
                    ? LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(gcSlot))
                    : MixDiscriminants(gcSlot, discriminantExprs);

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
                                        Argument(slotSyntax)
                                    }
                                )
                            )
                        )
                    )
                );
            }

            static ExpressionSyntax MixDiscriminants(int slot, string[] discriminants) => InvocationExpression
            (
                MemberAccessExpression
                (
                    SyntaxKind.SimpleMemberAccessExpression,
                    MemberAccessExpression
                    (
                        SyntaxKind.SimpleMemberAccessExpression,
                        AliasQualifiedName
                        (
                            IdentifierName
                            (
                                Token(SyntaxKind.GlobalKeyword)
                            ),
                            IdentifierName("System")
                        ),
                        IdentifierName("HashCode")
                    ),
                    IdentifierName("Combine")
                ),
                ArgumentList
                (
                    SeparatedList
                    (
                        Enumerable.Repeat
                        (
                            Argument(LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(slot))),
                            1
                        ).Concat(discriminants.Select(x => Argument(ParseExpression(x))))
                    )
                )
            );
        }
    }

    public enum PinMode
    {
        Persist,
        UntilNextCall
    }
}
