// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class EmitterStructMemberFieldsTests : EmitterTest
{
    [Fact]
    public void SingleFieldIntegration()
    {
        var node = Transform
        (
            new StructSymbol
            (
                new IdentifierSymbol("Test"), new StructLayout((new[]
                {
                    new LayoutEntry(new FieldSymbol
                    (
                        new StructSymbol(new IdentifierSymbol("int"), StructLayout.Empty),
                        new IdentifierSymbol("F1")
                    ), 0)   
                }).ToImmutableArray())
            )
        );

        Assert.Equal
        (
            @"[StructLayout(LayoutKind.Explicit)]
public struct Test
{
    [FieldOffset(0)]
    public int F1;
}
", node.ToFullString()
        );
    }
    
    [Fact]
    public void MultipleFieldsIntegration()
    {
        var node = Transform
        (
            new StructSymbol
            (
                new IdentifierSymbol("Test"), new StructLayout((new[]
                {
                    new LayoutEntry(new FieldSymbol
                    (
                        new StructSymbol(new IdentifierSymbol("int"), StructLayout.Empty),
                        new IdentifierSymbol("F1")
                    ), 0),
                    new LayoutEntry(new FieldSymbol
                    (
                        new StructSymbol(new IdentifierSymbol("int"), StructLayout.Empty),
                        new IdentifierSymbol("F2")
                    ), 20),
                    new LayoutEntry(new FieldSymbol
                    (
                        new StructSymbol(new IdentifierSymbol("int"), StructLayout.Empty),
                        new IdentifierSymbol("F3")
                    ), 12)
                }).ToImmutableArray())
            )
        );

        Assert.Equal
        (
            @"[StructLayout(LayoutKind.Explicit)]
public struct Test
{
    [FieldOffset(0)]
    public int F1;
    [FieldOffset(20)]
    public int F2;
    [FieldOffset(12)]
    public int F3;
}
", node.ToFullString()
        );
    }
}
