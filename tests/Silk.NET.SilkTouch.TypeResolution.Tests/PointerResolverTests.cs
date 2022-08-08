// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.TypeResolution.Tests;

public sealed class PointerResolverTests
{
    [Theory, Trait("Category", "Type Resolution"), 
        InlineData("a*"),
        InlineData("a.b.c*"),
        InlineData("int*")
    ]
    public void ShouldResolve(string text)
    {
        var symbol = new UnresolvedTypeReference(text);
        var output = new PointerTypeResolver(new TypeStore());

        var finalSymbol = output.Visit(symbol);
        Assert.IsType<PointerTypeReference>(finalSymbol);
    }

    [Theory, Trait("Category", "Type Resolution"),
        InlineData(""),
        InlineData("a"),
        InlineData("*"),
        InlineData("a.b.c"),
        InlineData("longType"),
        InlineData("int"),
        InlineData("using")
    ]
    public void ShouldNotResolve(string text)
    {
        var symbol = new UnresolvedTypeReference(text);
        var output = new PointerTypeResolver(new TypeStore());

        var finalSymbol = output.Visit(symbol);
        Assert.IsNotType<PointerTypeReference>(finalSymbol);
    }
}
