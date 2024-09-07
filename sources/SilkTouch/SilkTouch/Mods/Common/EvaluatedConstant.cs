// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods;

#if false
public readonly struct EvaluatedConstant
{
    private byte Flags { get; init; }
    public bool IsSigned
    {
        get => (Flags & 1) == 1;
        init => Flags = (byte)(value ? Flags | 1 : Flags & 0xFE);
    }

    public int Size
    {
        get => 1 << ((Flags & (2 | 4)) >> 1);
        init
        {
            if (BitOperations.PopCount(unchecked((uint)value)) != 1 || value > 8)
            {
                throw new ArgumentException("Invalid value, must be 1, 2, 4, or 8.", nameof(value));
            }

            Flags = (byte)((Flags & ~(2 | 4)) | (BitOperations.TrailingZeroCount(value) << 1));
        }
    }

    public bool IsLiteral
    {
        get => (Flags & 8) == 8;
        init => Flags = (byte)((Flags & ~8) | (value ? 8 : 0));
    }

    public ulong UnsignedValue { get; init; }
    public long SignedValue
    {
        get => unchecked((long)UnsignedValue);
        init => UnsignedValue = unchecked((ulong)value);
    }

    public EvaluatedConstant(
        ExpressionSyntax syntax,
        int contextualSize = 0,
        bool? contextualSigned = false,
        bool checkedCtx = true
    )
    {
        var goAgain = false;
        do
        {
            goAgain = false;
            if (syntax is LiteralExpressionSyntax { Token: var tok })
            {
                (IsSigned, Size, UnsignedValue) = tok.Value switch
                {
                    // Recall that C# has the weird thing where everything is an int/long/uint/ulong until told
                    // otherwise
                    sbyte sb => (true, 4, unchecked((ulong)sb)),
                    short s => (true, 4, unchecked((ulong)s)),
                    int i => (true, 4, unchecked((ulong)i)),
                    long l and > int.MaxValue => (true, 8, unchecked((ulong)l)),
                    long l => (true, 8, unchecked((ulong)l)),
                    byte b => (false, 4, b),
                    ushort us => (false, 4, us),
                    uint ui => (false, 4, ui),
                    ulong ul => (false, 8, ul),
                    _ => throw new InvalidOperationException("Unexpected literal type.")
                };
                IsLiteral = true;
            }
            else if (syntax is PrefixUnaryExpressionSyntax unary)
            {

            }
            else if (syntax is BinaryExpressionSyntax binary) { }
            else if (syntax is ParenthesizedExpressionSyntax)
            {
                goAgain = true;
            }
            else if (
                syntax is CheckedExpressionSyntax ce
                && syntax.IsKind(SyntaxKind.UncheckedExpression)
            )
            {
                this = new EvaluatedConstant(
                    ce.Expression,
                    contextualSize,
                    contextualSigned,
                    false
                );
            }
        } while (goAgain);
    }
}
#endif
