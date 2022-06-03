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
                new IdentifierSymbol("Test"), new[]
                { 
                    new FieldSymbol
                    (
                        new StructSymbol(new IdentifierSymbol("int"), ImmutableArray<FieldSymbol>.Empty),
                        new IdentifierSymbol("F1")
                    )  
                }.ToImmutableArray()
            )
        );

        Assert.Equal
        (
            @"public struct Test
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
                new IdentifierSymbol("Test"), new[]
                {
                    new FieldSymbol
                    (
                        new StructSymbol(new IdentifierSymbol("int"), ImmutableArray<FieldSymbol>.Empty),
                        new IdentifierSymbol("F1")
                    ),
                    new FieldSymbol
                    (
                        new StructSymbol(new IdentifierSymbol("int"), ImmutableArray<FieldSymbol>.Empty),
                        new IdentifierSymbol("F2")
                    ),
                    new FieldSymbol
                    (
                        new StructSymbol(new IdentifierSymbol("int"), ImmutableArray<FieldSymbol>.Empty),
                        new IdentifierSymbol("F3")
                    )
                }.ToImmutableArray()
            )
        );

        Assert.Equal
        (
            @"public struct Test
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
